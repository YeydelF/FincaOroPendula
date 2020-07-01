using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Datos
{

    public class datUsuario
    {
        Conexion con = new Conexion();
       
        public string AgregarUsuario(string accion,string nombre, string NombreUsuarioAdmin, string NombreClave, int Estado, string tipoUsuario, string ipMaquina,string Fecha,string Hora, string NombreUsuario)
        {
            con.conexion.Close();
            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "AgregarUsuario";
                com.Parameters.AddWithValue("Accion", accion);
                com.Parameters.AddWithValue("pNombre", nombre);
                com.Parameters.AddWithValue("pNombreUsuarioAdmin", NombreUsuarioAdmin);
                com.Parameters.AddWithValue("pNombreClave", NombreClave);
                com.Parameters.AddWithValue("pEstado", Estado);
                com.Parameters.AddWithValue("pTipoUsuario", tipoUsuario);
                com.Parameters.AddWithValue("pIpMaquina", ipMaquina);
                com.Parameters.AddWithValue("pFecha", Fecha);
                com.Parameters.AddWithValue("pHora", Hora);
                com.Parameters.AddWithValue("pNombreUsuario", NombreUsuario);
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
