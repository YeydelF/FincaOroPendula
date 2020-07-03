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
    public partial class FrmVerRegistros : Form
    {
        
        public FrmVerRegistros()
        {
            InitializeComponent();
        }
        DmGeneral objetoG = new DmGeneral();
        DmLotes lotes = new DmLotes();
        DmInsumos insumos = new DmInsumos();
        DmRegistro registro = new DmRegistro();
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerRegistros_Load(object sender, EventArgs e)
        {
            llenarCbx();
        }

        private void btnAcepar_Click(object sender, EventArgs e)
        {
            string idLote = cbxLotes.SelectedValue.ToString();
            dgvActividades.DataSource =  lotes.Rlotes(idLote);
            btnVerMas.Enabled = true;
        }
        
        private void btnVerMas_Click(object sender, EventArgs e)
        {
            mostrarDestalles();
            btnVerMas.Enabled = false;
        }

        private void llenarCbx()
        {
            cbxLotes.DataSource = objetoG.llenarCbx("SELECT nombreLote, idLote FROM lotes;");
            cbxLotes.DisplayMember = "nombreLote";
            cbxLotes.ValueMember = "idLote";
        }

        
        DataTable TbRegistro = new DataTable();
        public void mostrarDestalles()
        {
            string idRegistro = dgvActividades.CurrentRow.Cells[0].Value.ToString();
            TbRegistro = registro.RRegistro(idRegistro);
            dgvInsumos.DataSource = insumos.RInsumo(idRegistro);

            lblCiclo.Text = TbRegistro.Rows[0][0].ToString();
            lblLugar.Text = TbRegistro.Rows[0][1].ToString();
            lblLote.Text = TbRegistro.Rows[0][2].ToString();
            lblVariedad.Text = TbRegistro.Rows[0][3].ToString();
            lblNum.Text = TbRegistro.Rows[0][4].ToString();
            lblFecha.Text = TbRegistro.Rows[0][5].ToString();
            lblActividad.Text = TbRegistro.Rows[0][6].ToString();
            lblDh.Text = TbRegistro.Rows[0][7].ToString();
            lblcudh.Text = TbRegistro.Rows[0][8].ToString();
            lblctDh.Text = TbRegistro.Rows[0][9].ToString();
            lblCtInsumo.Text = TbRegistro.Rows[0][10].ToString();
            lblTotal.Text = TbRegistro.Rows[0][11].ToString();
        }
    }
}
