using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Datos
{
   public class datObtenerFecha
    {
        public string ObtenerFecha()
        {
            //DateTime fecha =  DateTime.Today;
            string fe = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            return fe;
        }
        public string ObtenerFechaSinHora()
        {
            //DateTime fecha =  DateTime.Today;
            string fe = DateTime.Now.ToString("dd-MM-yyyy");
            return fe;
        }
        public string ObtenerHora()
        {
            //DateTime fecha =  DateTime.Today;
            string h = DateTime.Now.ToString("hh:mm:ss");
            return h;
        }
        public string ObtenerFechaSencilla()
        {
            //string fe = DateTime.Now.ToString("dd-MM-yyyy");
            string fe = DateTime.Now.ToLongDateString();
            return fe;
        }

    }
}
