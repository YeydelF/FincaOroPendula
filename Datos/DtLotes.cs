using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class DtLotes
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrar()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarLotes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public string Agregar(string nombre, string dueno, string variedad, DateTime fechaSiembra, double tamano)
        {
            try
            {
                MySqlParameter res;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AgregarLote";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pNombreLote", nombre);
                comando.Parameters.AddWithValue("@pDueno", dueno);
                comando.Parameters.AddWithValue("@pVariedad", variedad);
                comando.Parameters.AddWithValue("@pFechaSiembra", fechaSiembra);
                comando.Parameters.AddWithValue("@pTamano", tamano);
                res = comando.Parameters.AddWithValue("Salida", "");
                comando.Parameters["Salida"].Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }catch(Exception)
            {
                return "ERROR";
            }
        }

    }
}
