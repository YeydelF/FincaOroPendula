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
        datConsultas add = new datConsultas();
        datIPMaquina ip = new datIPMaquina();
        datProcedimientosEliminar pro = new datProcedimientosEliminar();
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
                if (txtNombreActividad.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor agregar nombre", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objetoDm.AgregarActividades(txtNombreActividad.Text, txtDescripcion.Text);
                    MessageBox.Show("Se guardo correctamente");
                    Limpiar();
                    MostrarActividades();
                }
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
            string localIP = ip.ObtenerMac();
            int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + localIP + "' "));
            string labor = add.ConsultaN("Select tipo_usuario from usuarios where idUsuario = '" + result + "' ");
            if(labor.ToUpper() == "INVITADO")
            {
                Bloquear();
            }
            MostrarActividades();
           
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Bloquear()
        {
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            int seleccionada = 0;
            string valor;
            if (dgvMostrar.SelectedRows.Count > 0)
            {
                seleccionada = dgvMostrar.CurrentRow.Index;
                valor = dgvMostrar.Rows[seleccionada].Cells[0].Value.ToString();
                // MessageBox.Show("e "+ valor);
                DialogResult opcion = MessageBox.Show("¿Está seguro que desea eliminar esta actividad ?", "Eliminar Actividad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    string Retorno = pro.EliminarActividad(valor);
                    if (Retorno == "ERROR")
                    {
                        MessageBox.Show("Error al eliminar actividad", "Eliminar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Retorno == "ELIMINADO")
                    {
                        MessageBox.Show("Actividad eliminada", "Eliminar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarActividades();
                    }

                }
                else
                {
                    MessageBox.Show("No se ha selecionado ningun usuario", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
    }
}
