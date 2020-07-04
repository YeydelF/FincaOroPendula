using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
   public class Conexion
    {
    public MySqlConnection conexion = new MySqlConnection("server=localhost; database=bd_fincaoropendula; Uid=root; pwd=yeydel;");

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
