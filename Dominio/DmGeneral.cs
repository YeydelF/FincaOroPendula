using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
   public class DmGeneral
    {
        private DtGeneral objetoDt = new DtGeneral();

        public DataTable llenarCbx(string sql)
        {
            DataTable tabla = new DataTable();
            tabla = objetoDt.llenarCbx(sql);
            return tabla;
        }
    }
}
