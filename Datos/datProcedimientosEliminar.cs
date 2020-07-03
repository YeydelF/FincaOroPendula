using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class datProcedimientosEliminar
    {
        Conexion con = new Conexion();
        public string EliminarActividad(string Nombre)
        {
            con.conexion.Close();
            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "EliminarActividad";
                com.Parameters.AddWithValue("pNombre", Nombre);
                res = com.Parameters.AddWithValue("Salida", "");
                com.Parameters["Salida"].Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();

                return res.Value.ToString();

                //return "realizado";
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex);
                MessageBox.Show("MySqlException " + ex.ToString());
                con.conexion.Close();
                return "ERROR";

            }
            catch (Exception ex1)
            {
                con.conexion.Close();
                MessageBox.Show("Excepcion global" + ex1.ToString());

                return "ERROR";
            }
        }

        public string EliminarActualizarInsumo(string Nombre,string NuevoNombre, string UnidadMedida, double CostoUnitario,string Accion)
        {
            con.conexion.Close();
            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Insumos";
                com.Parameters.AddWithValue("pNombre", Nombre);
                com.Parameters.AddWithValue("pNuevoNombre", NuevoNombre);
                com.Parameters.AddWithValue("pUnidadMedida", UnidadMedida);
                com.Parameters.AddWithValue("pCostoUnitario", CostoUnitario);
                com.Parameters.AddWithValue("pAccion", Accion);
                res = com.Parameters.AddWithValue("pSalida", "");
                com.Parameters["pSalida"].Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();

                return res.Value.ToString();

                //return "realizado";
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex);
                MessageBox.Show("MySqlException " + ex.ToString());
                con.conexion.Close();
                return "ERROR";

            }
            catch (Exception ex1)
            {
                con.conexion.Close();
                MessageBox.Show("Excepcion global" + ex1.ToString());

                return "ERROR";
            }
        }
       
        public string EliminarLote(string Nombre)
        {
            con.conexion.Close();
            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "EliminarLote";
                com.Parameters.AddWithValue("pNombre", Nombre);
                res = com.Parameters.AddWithValue("Salida", "");
                com.Parameters["Salida"].Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();

                return res.Value.ToString();

                //return "realizado";
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex);
                MessageBox.Show("MySqlException " + ex.ToString());
                con.conexion.Close();
                return "ERROR";

            }
            catch (Exception ex1)
            {
                con.conexion.Close();
                MessageBox.Show("Excepcion global" + ex1.ToString());

                return "ERROR";
            }
        }
    }
}
