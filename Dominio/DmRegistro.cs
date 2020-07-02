using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
   public class DmRegistro
    {
        private DtRegistro objetoDt = new DtRegistro();

        public void AgregarRegistro(string idLote, string idActividad, string idCiclo, DateTime fecha, double diasHombre, double cu_DH, double ct_DH)
        {
            objetoDt.agregarRegistro(Convert.ToInt32(idLote), Convert.ToInt32(idActividad), Convert.ToInt32(idCiclo), fecha, diasHombre, cu_DH, ct_DH);
        }

        public void AgregarInsumoRegistro(string idInsumo, string cantInsumo, string costoPorInsumo)
        {
            objetoDt.agregarInsumoRegistro(Convert.ToInt32(idInsumo), Convert.ToDouble(cantInsumo), Convert.ToDouble(costoPorInsumo));
        }

        public double obtenerPrecioInsumo(string idInsumo)
        {
            double precio = objetoDt.obtenerPrecioInsumo(Convert.ToInt32(idInsumo));

            return precio;

        }

        public void sumarTotal()
        {
            objetoDt.sumarTotal();
        }
    }
}
