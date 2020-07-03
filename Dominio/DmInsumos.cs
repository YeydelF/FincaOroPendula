using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Windows.Forms;
namespace Dominio
{
    public class DmInsumos
    {
        private DtInsumos objetoDt = new DtInsumos();

        public DataTable MostrarInsumos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.mostrar();
            return tabla;
        }

        public string AgregarInsumo(string nombre, string UnidadMedida, string CostoUnitario)
        {
            string result = objetoDt.Agregar(nombre, UnidadMedida, Convert.ToDouble(CostoUnitario));
           // MessageBox.Show(result);
            return result;
        }

        public DataTable RInsumo(string idRegistro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.RInsumos(Convert.ToInt32(idRegistro));
            return tabla;
        }
    }
}
