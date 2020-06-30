using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
    public class DmLotes
    {
        private DtLotes objetoDt = new DtLotes();

        public DataTable MostrarLotes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.mostrar();
            return tabla;
        }

        public void AgregarLotes(string nombre, string dueno, string variedad, DateTime fechaSiembra, double tamano)
        {
            objetoDt.Agregar(nombre, dueno, variedad, fechaSiembra, tamano);
        }

    }
}
