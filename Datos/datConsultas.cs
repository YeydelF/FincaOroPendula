using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class datConsultas
    {
        Conexion con = new Conexion();
        public string ConsultaN(string sql)
        {
            string result = "";
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cm = new MySqlCommand(sql, con.conexion);
                MySqlDataAdapter DA = new MySqlDataAdapter(cm);
                DA.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    result = Convert.ToString(dt.Rows[0][0]);
                }
                return result;
            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }
        }
        public DataTable Datos(string Sql)
        {
            DataTable dt = new DataTable();
            MySqlCommand comm = new MySqlCommand(Sql, con.conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(dt);

            return dt;
        }

    }
}
