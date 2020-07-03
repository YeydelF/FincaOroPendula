using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
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

        public string Agregar(string nombre, string UnidadMedida,double CostoUnitario)
        {
            conexion.conexion.Close();
            try {
                MySqlParameter res;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AgregarInsumo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pNombre", nombre);
                comando.Parameters.AddWithValue("@pUnidadMedida", UnidadMedida);
                comando.Parameters.AddWithValue("@pCostoUnitario", CostoUnitario);
                res = comando.Parameters.AddWithValue("Salida", "");
                comando.Parameters["Salida"].Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
               // MessageBox.Show(res.Value.ToString());
                return res.Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR";
            }

           
        }

    }
}
