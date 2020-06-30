using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DtActividades
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrar()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarActividades";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Agregar(string nombre, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarActividades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pNombre", nombre);
            comando.Parameters.AddWithValue("@pDescripcion", descripcion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}
