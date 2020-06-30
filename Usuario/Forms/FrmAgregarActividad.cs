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
    public partial class FrmAgregarActividad : Form
    {
        datObtenerFecha pf = new datObtenerFecha();
        public FrmAgregarActividad()
        {
            InitializeComponent();
        }

        private DmActividades objetoDm = new DmActividades();
        
        private void MostrarActividades()
        {
            dgvMostrar.DataSource = objetoDm.MostrarActividades();
        }

        public void Limpiar()
        {
            txtNombreActividad.Clear();
            txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoDm.AgregarActividades(txtNombreActividad.Text, txtDescripcion.Text);
                MessageBox.Show("Se guardo correctamente");
                Limpiar();
                MostrarActividades();
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

        private void FrmAgregarActividad_Load(object sender, EventArgs e)
        {
            
            MostrarActividades();
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
