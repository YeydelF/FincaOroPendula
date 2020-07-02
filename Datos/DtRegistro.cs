using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
   public class DtRegistro
    {
        private Conexion conexion = new Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public void agregarRegistro(int idLote, int idActividad, int idCiclo, DateTime fecha, double diasHombre, double cu_DH, double ct_DH)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("pIdLote", idLote);
            comando.Parameters.AddWithValue("pIdActividad", idActividad);
            comando.Parameters.AddWithValue("pIdCiclo", idCiclo);
            comando.Parameters.AddWithValue("pFecha", fecha);
            comando.Parameters.AddWithValue("pDiasHombre", diasHombre);
            comando.Parameters.AddWithValue("pCUdh", cu_DH);
            comando.Parameters.AddWithValue("pCTdh", ct_DH);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void agregarInsumoRegistro(int idInsumo, double cantInsumo, double costoPorInsumo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarInsumoRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("pIdInsumo", idInsumo);
            comando.Parameters.AddWithValue("pCantInsumo", cantInsumo);
            comando.Parameters.AddWithValue("pCostporInsumo", costoPorInsumo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public double obtenerPrecioInsumo(int idInsumo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT insumos.costoUnitario FROM insumos WHERE insumos.idInsumo = @id;";
            comando.Parameters.AddWithValue("@id", idInsumo);
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            double precio = Convert.ToDouble(tabla.Rows[0][0].ToString());
            comando.Parameters.Clear();
            tabla.Clear();
            return precio;

        }

        public void sumarTotal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Totales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
