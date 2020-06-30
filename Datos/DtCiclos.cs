using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DtCiclos
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrar()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCiclos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Agregar(string nombre, string lugar, string descripcion, DateTime fechaInicial, DateTime fechaFinal)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarCiclo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pNombre", nombre);
            comando.Parameters.AddWithValue("@pLugar", lugar);
            comando.Parameters.AddWithValue("@pDescripcion", descripcion);
            comando.Parameters.AddWithValue("@pFechaInicial",fechaInicial);
            comando.Parameters.AddWithValue("@pFechaFinal", fechaFinal);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


    }
}
