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
using Datos;
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
            llenarDGV();


        }

        private void btnListo_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCUDH.Text.Trim() == "" || txtDH.Text.Trim() == "")
            {
                MessageBox.Show("Error, Ingrese los datos anteriores","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Arreglos();
               
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                procedimientoRegistro();
                asignarInsumo();
                objetoDm.sumarTotal();
               
               
                MessageBox.Show("Registro agregado correctamente","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiar();
                this.btnAgregar.Enabled = true;
                llenarDGV();
            }
            catch (Exception)
            {
             MessageBox.Show("Ha ocurrido un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
 
        }

        private void procedimientoRegistro()
        {
            if ((txtDH.Text == "") && (txtCUDH.Text == ""))
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
               


                objetoDm.AgregarRegistro(idLote, idActividad, idCiclo, fecha, diasHombre, costoUnitarioDH, costoTotalDH);
                
            }
        }

        public ArrayList Aid = new ArrayList();
        public ArrayList Acantidad = new ArrayList();
        public ArrayList AtotalInsumo = new ArrayList();
        datConsultas c = new datConsultas();
        int contador = 0;
      

        private void asignarInsumo()
        {

            for (int i = 0; i < Aid.Count; i++)
            {
                string g1 = Aid[i].ToString();
                string g2 = Acantidad[i].ToString();
                string g3 = AtotalInsumo[i].ToString();

                objetoDm.AgregarInsumoRegistro(g1, g2, g3);
               // MessageBox.Show("Guardo "+ i + "Id "+ g1 + "cant " + g2 + "cost "+ g3);
            }

        }

        private void limpiar()
        {
            txtDH.Clear();
            txtCUDH.Clear();
           
          
            cbxCiclo.SelectedIndex = 0;
            cbxLote.SelectedIndex = 0;
            cbxActividad.SelectedIndex = 0;
            
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

        private void cbxInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Arreglos()
        {
            try
            {
                for (int i = 0; i < dgvInsumos.RowCount; i++)
                {
                    bool x = Convert.ToBoolean(dgvInsumos.Rows[i].Cells[0].Value);
                    if (x)
                    {
                        string cantidad = dgvInsumos.Rows[i].Cells[1].Value.ToString();
                        //   string nombre = dgvInsumos.Rows[i].Cells[3].Value.ToString();
                        string id = dgvInsumos.Rows[i].Cells[2].Value.ToString();
                        string costo = dgvInsumos.Rows[i].Cells[4].Value.ToString();
                        int cant = Convert.ToInt32(cantidad);
                        double cos = Convert.ToDouble(costo);
                        double total = cant * cos;
                        Aid.Add(id);
                        Acantidad.Add(cant);
                        AtotalInsumo.Add(total);
                        contador += 1;
                      //  MessageBox.Show("Fila " + i + "ID " + id + "Nombre  " + " Costo" + costo + "Cantidad " + cantidad + "Contador " + contador2);
                    }
                    this.btnAgregar.Enabled = false;
                    this.btnFinalizar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede repetir el mismo insumo, introduzca otro");
            }
        }
        public void llenarDGV()
        {
            DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();
            columna.Name = "Agregar";
            columna.Width = 80;
            columna.HeaderText = "Agregar";
            dgvInsumos.DataSource = c.Datos("select insumos.idInsumo as 'ID',insumos.nombre as 'Nombre',insumos.costoUnitario as 'Costo'from insumos");
            dgvInsumos.Columns.Add(columna);
            dgvInsumos.Columns.Add("Cantidad", "Cantidad");




        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void dgvInsumos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgvInsumos.CurrentCell.ColumnIndex == 0)
            {
                TextBox txt = e.Control as TextBox;
                if(txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(textBox1_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                }
            }
        }
    }
}
