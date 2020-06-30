using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
    public class DmActividades
    {
       private DtActividades objetoDt = new DtActividades();

        public DataTable MostrarActividades()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.mostrar();
            return tabla;
        }

        public void AgregarActividades(string nombre, string descripcion)
        {
            objetoDt.Agregar(nombre, descripcion);
        }
    }
}
