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
using System.Collections;

namespace Usuario.Forms
{
    public partial class FrmManejoDePlantanciones : Form
    {
        public FrmManejoDePlantanciones()
        {
            InitializeComponent();
        }
        private DmRegistro objetoDm = new DmRegistro();
        private DmGeneral objetoG = new DmGeneral();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManejoDePlantanciones_Load(object sender, EventArgs e)
        {
            llenarCbx();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            int insumosUtilizados = Convert.ToInt32(txtInsumUtilizados.Text);

            if (insumosUtilizados == 0)
            {
                procedimientoRegistro();
                btnFinalizar.Enabled = true;
                btnListo.Enabled = false;
            }
            else
            {
                gbInsumos.Visible = true;
                procedimientoRegistro();
                btnListo.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarInsumo();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            asignarInsumo();
            objetoDm.sumarTotal();
            MessageBox.Show("Registro agregado correctamente");
            limpiar();
        }

        private void llenarCbx()
        {
            cbxCiclo.DataSource = objetoG.llenarCbx("SELECT ciclo.nombre, ciclo.idCiclo FROM ciclo;");
            cbxCiclo.DisplayMember = "nombre";
            cbxCiclo.ValueMember = "idCiclo";

            cbxLote.DataSource = objetoG.llenarCbx("SELECT nombreLote, idLote FROM lotes;");
            cbxLote.DisplayMember = "nombreLote";
            cbxLote.ValueMember = "idLote";

            cbxActividad.DataSource = objetoG.llenarCbx("SELECT nombre, idActividad FROM actividades");
            cbxActividad.DisplayMember = "nombre";
            cbxActividad.ValueMember = "idActividad";

            cbxInsumo.DataSource = objetoG.llenarCbx("SELECT nombre, idInsumo FROM insumos");
            cbxInsumo.DisplayMember = "nombre";
            cbxInsumo.ValueMember = "idInsumo";
        }

        private void procedimientoRegistro()
        {
            if ((txtDH.Text == "") && (txtCUDH.Text == "") && (txtCantInsumo.Text == "") && (txtInsumUtilizados.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                string idLote = cbxLote.SelectedValue.ToString();
                string idActividad = cbxActividad.SelectedValue.ToString();
                string idCiclo = cbxCiclo.SelectedValue.ToString();
                string f = dtpFecha.Value.Year.ToString() + "-" + dtpFecha.Value.Month.ToString() + "-" + dtpFecha.Value.Day.ToString();
                DateTime fecha = Convert.ToDateTime(f);
                double diasHombre = Convert.ToDouble(txtDH.Text);
                double costoUnitarioDH = Convert.ToDouble(txtCUDH.Text);
                double costoTotalDH = diasHombre * costoUnitarioDH;
                string cantInsumoUtilizada = txtInsumUtilizados.Text;


                objetoDm.AgregarRegistro(idLote, idActividad, idCiclo, fecha, diasHombre, costoUnitarioDH, costoTotalDH);
                
            }
        }

        public ArrayList Aid = new ArrayList();
        public ArrayList Acantidad = new ArrayList();
        public ArrayList AtotalInsumo = new ArrayList();
        int contador = 0;
        private void agregarInsumo()
        {
            int insumosUtilizados = Convert.ToInt32(txtInsumUtilizados.Text);

            int idInsumo = Convert.ToInt32(cbxInsumo.SelectedValue);
            double cantidad = Convert.ToDouble(txtCantInsumo.Text);
            double precioInsumo = objetoDm.obtenerPrecioInsumo(idInsumo.ToString());
            double totalInsumo = cantidad * precioInsumo;
            double Total = 0;

            if ((cbxInsumo.SelectedItem != null) && (txtCantInsumo.Text != ""))
            {
                
                Total = Total + totalInsumo;
                Aid.Add(idInsumo);
                Acantidad.Add(cantidad);
                AtotalInsumo.Add(totalInsumo);


                cbxInsumo.SelectedIndex = 0;
                txtCantInsumo.Text = "";
                contador++;
                if (contador == insumosUtilizados)
                {
                    btnAgregar.Enabled = false;
                    btnFinalizar.Enabled = true;
                }

                
            }
        }

        private void asignarInsumo()
        {
            int insumosUtilizados = Convert.ToInt32(txtInsumUtilizados.Text);

            for (int i = 0; i < insumosUtilizados; i++)
            {
                objetoDm.AgregarInsumoRegistro(Aid[i].ToString(), Acantidad[i].ToString(), AtotalInsumo[i].ToString());
            }

        }

        private void limpiar()
        {
            txtDH.Clear();
            txtCUDH.Clear();
            txtInsumUtilizados.Clear();
            txtCantInsumo.Clear();
            cbxCiclo.SelectedIndex = 0;
            cbxLote.SelectedIndex = 0;
            cbxActividad.SelectedIndex = 0;
            cbxInsumo.SelectedIndex = 0;
            btnListo.Enabled = true;
        }

        private void txtDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCUDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInsumUtilizados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
