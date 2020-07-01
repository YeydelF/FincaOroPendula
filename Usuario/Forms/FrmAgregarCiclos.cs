using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Usuario.Forms
{
    public partial class FrmAgregarCiclos : Form
    {
        public FrmAgregarCiclos()
        {
            InitializeComponent();
        }

        private DmCiclos objetoDm = new DmCiclos();
        
        private void MostrarCiclos()
        {
            dgvMostrar.DataSource = objetoDm.MostrarCiclos();
        }

        public void Limpiar()
        {
            txtNombreCiclo.Clear();
            txtLugar.Clear();
            txtDescripcion.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
                string fechaI = dtpFechaInicial.Value.Year.ToString() +"-"+ dtpFechaInicial.Value.Month.ToString() + "-" + dtpFechaInicial.Value.Day.ToString();
                string fechaF = dtpFechaFinal.Value.Year.ToString() + "-" + dtpFechaFinal.Value.Month.ToString() + "-" + dtpFechaFinal.Value.Day.ToString();
                DateTime fechaInicial = Convert.ToDateTime(fechaI);
                DateTime fechaFinal = Convert.ToDateTime(fechaF);
                objetoDm.AgregarCiclos(txtNombreCiclo.Text, txtLugar.Text, txtDescripcion.Text, fechaInicial, fechaFinal);
                MessageBox.Show("Se guardo correctamente");
                Limpiar();
                MostrarCiclos();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarCiclos_Load(object sender, EventArgs e)
        {
            MostrarCiclos();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
