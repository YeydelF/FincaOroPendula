using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace Usuario.Forms
{
    public partial class frmGrafica : Form
    {
        public frmGrafica()
        {
            InitializeComponent();
        }

        private void frmGrafica_Load(object sender, EventArgs e)
        {
            datConsultas c = new datConsultas();
            Grafico1.Series.Add("Pinche");
            Grafico1.Series["Pinche"].LegendText = "Grafica de máquinas";
            Grafico1.Series["Pinche"].XValueMember = "Nombre";
            Grafico1.Series["Pinche"].YValueMembers = "Edad";
            Grafico1.DataSource = c.Datos("SELECT Nombre,Edad from Grafica;");
        }
    }
}
