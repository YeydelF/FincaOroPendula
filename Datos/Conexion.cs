using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    class Conexion
    {
    public MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdoropend; Uid=root; pwd=a1234;");

     public MySqlConnection AbrirConexion()
     {
         if (conexion.State == ConnectionState.Closed)
           conexion.Open();
           return conexion;
     }

     public MySqlConnection CerrarConexion()
     {
         if (conexion.State == ConnectionState.Open)
           conexion.Close();
           return conexion;
     }

    }
}
