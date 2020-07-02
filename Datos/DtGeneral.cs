using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
   public class DtGeneral
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable llenarCbx(string sql)
        {
            DataTable DT = new DataTable();
            try
            {
                MySqlCommand CM = new MySqlCommand(sql, conexion.AbrirConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(CM);
                DA.Fill(DT);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            return DT;

        }
    }
}
