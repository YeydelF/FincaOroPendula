using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class datEliminarUser
    {
        Conexion con = new Conexion();
        public string EliminarUsuario(string NombreUDelete, string NombreUAdmin, string Pass, string Fecha, string Hora, string ip)
        {
            con.conexion.Close();
            MySqlCommand com = new MySqlCommand();
            MySqlParameter res;
            try
            {
                con.conexion.Open();
                com.Connection = con.conexion;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "EliminarUsuario";
                com.Parameters.AddWithValue("pNombreUDelete", NombreUDelete);
                com.Parameters.AddWithValue("pNombreUAdmin", NombreUAdmin);
                com.Parameters.AddWithValue("pPass", Pass);
                com.Parameters.AddWithValue("pFecha", Fecha);
                com.Parameters.AddWithValue("pHora", Hora);
                com.Parameters.AddWithValue("pIpMaquina", ip);
                res = com.Parameters.AddWithValue("Res", "");
                com.Parameters["Res"].Direction = ParameterDirection.Output;
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