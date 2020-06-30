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
    public class datLogin
    {
        Conexion con = new Conexion();
        public string AbrirSesion(string accion, string KeyName, string Passwd, string ip, int idUsuario,string fecha)
        {

            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "SesionUsuario";
                com.Parameters.AddWithValue("pAccion", accion);
                com.Parameters.AddWithValue("pUsuario", KeyName);
                com.Parameters.AddWithValue("pClave", Passwd);
                com.Parameters.AddWithValue("pIp", ip);
                com.Parameters.AddWithValue("pIdUsuario", idUsuario);
                com.Parameters.AddWithValue("pFecha", fecha);
                res = com.Parameters.AddWithValue("respuesta", "");
                com.Parameters["respuesta"].Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();

                return res.Value.ToString();
                //return "realizado";
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
                return "ERROR";
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
                return "ERROR";
            }

        }
    }
}
