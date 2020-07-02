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
using Datos;

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
            if (validar())
            {
                try
                {

                    string fechaI = dtpFechaInicial.Value.Year.ToString() + "-" + dtpFechaInicial.Value.Month.ToString() + "-" + dtpFechaInicial.Value.Day.ToString();
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarCiclos_Load(object sender, EventArgs e)
        {
            datConsultas add = new datConsultas();
            datIPMaquina ip = new datIPMaquina();
            string localIP = ip.ObtenerMac();
            int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + localIP + "' "));
            string labor = add.ConsultaN("Select tipo_usuario from usuarios where idUsuario = '" + result + "' ");
            if (labor.ToUpper() == "INVITADO")
            {
                Bloquear();
            }
          
            MostrarCiclos();

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Bloquear()
        {
            btnGuardar.Enabled = false;
        }
      
        private Boolean validar()
        {
            if (txtNombreCiclo.Text.Trim() == "" || txtLugar.Text.Trim() == "")
            {
                MessageBox.Show("Por favor rellenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
