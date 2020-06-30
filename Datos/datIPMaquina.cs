using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class datIPMaquina
    {
        public string obtenerIp()
        {
            string retorno = "";
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {

                    localIP = ip.ToString();

                }

            }
            retorno = localIP;
            return retorno;
        }
        public string ObtenerMac()
        {
            string Mac = "";
            foreach (NetworkInterface NIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (NIC.OperationalStatus == OperationalStatus.Up)
                {
                    Mac += NIC.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return Mac;
        }
    }
}
