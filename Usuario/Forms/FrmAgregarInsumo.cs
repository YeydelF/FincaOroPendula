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
    public partial class FrmAgregarInsumo : Form
    {
        public FrmAgregarInsumo()
        {
            InitializeComponent();
        }

        private DmInsumos objetoDm = new DmInsumos();

        private void FrmAgregarInsumo_Load(object sender, EventArgs e)
        {
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
