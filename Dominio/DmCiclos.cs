using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
    public class DmCiclos
    {
        private DtCiclos objetoDt = new DtCiclos();

        public DataTable MostrarCiclos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.mostrar();
            return tabla;
        }

        public void AgregarCiclos(string nombre, string lugar, string descripcion, DateTime fechaInicial, DateTime fechaFinal)
        {
            objetoDt.Agregar(nombre, lugar, descripcion, fechaInicial, fechaFinal);
        }


    }
}
