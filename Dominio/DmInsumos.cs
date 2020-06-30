using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

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

        public void AgregarInsumo(string nombre, string UnidadMedida, string CostoUnitario)
        {
            objetoDt.Agregar(nombre, UnidadMedida, Convert.ToDouble(CostoUnitario));
        }

    }
}
