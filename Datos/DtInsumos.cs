using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DtInsumos
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrar()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarInsumos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RInsumos(int idRegistro)
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RInsumos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pIdRegistro", idRegistro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Agregar(string nombre, string UnidadMedida,double CostoUnitario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarInsumo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pNombre", nombre);
            comando.Parameters.AddWithValue("@pUnidadMedida", UnidadMedida);
            comando.Parameters.AddWithValue("@pCostoUnitario", CostoUnitario);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}
