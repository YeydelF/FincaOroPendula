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
    public partial class FrmAgregarInsumo : Form
    {
        public FrmAgregarInsumo()
        {
            InitializeComponent();
        }

        private DmInsumos objetoDm = new DmInsumos();

        private void FrmAgregarInsumo_Load(object sender, EventArgs e)
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

            MostrarInsumos();
            cbxUnidadMedida.SelectedIndex = 0;
        }

        private void MostrarInsumos()
        {
            dgvMostrarIns.DataSource = objetoDm.MostrarInsumos();
        }

        public void Limpiar()
        {
            txtNombreInsumo.Clear();
            txtCostoUnitario.Clear();
            cbxUnidadMedida.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {

                    objetoDm.AgregarInsumo(txtNombreInsumo.Text, cbxUnidadMedida.SelectedItem.ToString(), txtCostoUnitario.Text);
                    MessageBox.Show("Se guardo correctamente");
                    MostrarInsumos();
                    Limpiar();
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
            if (txtCostoUnitario.Text.Trim() == "" || txtNombreInsumo.Text.Trim() == "")
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
