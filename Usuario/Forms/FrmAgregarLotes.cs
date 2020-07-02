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
    public partial class FrmAgregarLotes : Form
    {
        public FrmAgregarLotes()
        {
            InitializeComponent();
        }

        private DmLotes objetoDm = new DmLotes();
        
        private void MostrarLotes()
        {
            dgvMostrar.DataSource = objetoDm.MostrarLotes();
        }

        public void Limpiar()
        {
            txtNombreLote.Clear();
            txtDueno.Clear();
            cbxVariedad.SelectedIndex = 0;
            txtTamano.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    string fecha = dtpFechaSiembra.Value.Year.ToString() + "-" + dtpFechaSiembra.Value.Month.ToString() + "-" + dtpFechaSiembra.Value.Day.ToString();
                    DateTime fechaSiembra = Convert.ToDateTime(fecha);
                    objetoDm.AgregarLotes(txtNombreLote.Text, txtDueno.Text, cbxVariedad.SelectedItem.ToString(), fechaSiembra, Convert.ToDouble(txtTamano.Text));
                    MessageBox.Show("Se guardo correctamente");
                    Limpiar();
                    MostrarLotes();
                }
                catch (FormatException)
                {
                    MessageBox.Show("El valor del tamaño es erróneo");
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



        //private void txtDia_Enter(object sender, EventArgs e)
        //{
        //    if (txtDia.Text == "Día")
        //    {
        //        txtDia.Text = "";
        //        txtDia.ForeColor = Color.Black;
        //    }
        //}

        //private void txtDia_Leave(object sender, EventArgs e)
        //{
        //    if (txtDia.Text == "")
        //    {
        //        txtDia.Text = "Día";
        //        txtDia.ForeColor = Color.DimGray;
        //    }
        //}

        //private void txtMes_Enter(object sender, EventArgs e)
        //{
        //    if (txtMes.Text == "Mes")
        //    {
        //        txtMes.Text = "";
        //        txtMes.ForeColor = Color.Black;
        //    }
        //}

        //private void txtMes_Leave(object sender, EventArgs e)
        //{
        //    if (txtMes.Text == "")
        //    {
        //        txtMes.Text = "Mes";
        //        txtMes.ForeColor = Color.DimGray;
        //    }
        //}

        //private void txtAño_Enter(object sender, EventArgs e)
        //{
        //    if (txtAño.Text == "Año")
        //    {
        //        txtAño.Text = "";
        //        txtAño.ForeColor = Color.Black;
        //    }
        //}

        //private void txtAño_Leave(object sender, EventArgs e)
        //{
        //    if (txtAño.Text == "")
        //    {
        //        txtAño.Text = "Año";
        //        txtAño.ForeColor = Color.DimGray;
        //    }
        //}

        private void FrmAgregarLotes_Load(object sender, EventArgs e)
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

            MostrarLotes();
            cbxVariedad.SelectedIndex = 0;
        }
        public void Bloquear()
        {
            btnGuardar.Enabled = false;
        }
        private Boolean validar()
        {
            if (txtNombreLote.Text.Trim() == "" || txtTamano.Text.Trim() == "" || txtDueno.Text.Trim() == "")
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
