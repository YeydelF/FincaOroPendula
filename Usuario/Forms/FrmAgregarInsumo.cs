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
        datProcedimientosEliminar por = new datProcedimientosEliminar();
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
                   string result =  objetoDm.AgregarInsumo(txtNombreInsumo.Text, cbxUnidadMedida.SelectedItem.ToString(), txtCostoUnitario.Text);
                   // MessageBox.Show(result);
                    if (result == "GUARDADO")
                    {
                        MessageBox.Show("Se guardo correctamente", "Insumo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarInsumos();
                        Limpiar();
                    }
                    else
                    {
                     MessageBox.Show("Error al guardar,revise los datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            int seleccionada = 0;
            string Nombre,cant,accion;
            double costo;
            if (dgvMostrarIns.SelectedRows.Count > 0)
            {
                seleccionada = dgvMostrarIns.CurrentRow.Index;
                Nombre = dgvMostrarIns.Rows[seleccionada].Cells[1].Value.ToString();
                cant = dgvMostrarIns.Rows[seleccionada].Cells[2].Value.ToString();
                costo = Convert.ToDouble(dgvMostrarIns.Rows[seleccionada].Cells[3].Value.ToString());
                accion = "ELIMINAR";
                // MessageBox.Show("e "+ valor);
                DialogResult opcion = MessageBox.Show("¿Está seguro que desea eliminar este insumo ?", "Eliminar insumo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string Retorno = por.EliminarActualizarInsumo(Nombre, Nombre, cant, costo, accion);

                    if (Retorno == "ERROR")
                    {
                        MessageBox.Show("Error al eliminar Insumo", "Eliminar Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Retorno == "ELIMINADO")
                    {
                        MessageBox.Show("Insumo eliminada", "Eliminar Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarInsumos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha selecionado ningun usuario", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
               
            }
        }
        private void Actualizar()
        {
            int seleccionada = 0;
            string Nombre, cant, accion,nombreN;
            double costo;
            if (txtNombreInsumo.Text.Trim() != "" || txtCostoUnitario.Text.Trim() != "")
            {
                if (dgvMostrarIns.SelectedRows.Count > 0)
                {
                    seleccionada = dgvMostrarIns.CurrentRow.Index;
                    Nombre = dgvMostrarIns.Rows[seleccionada].Cells[1].Value.ToString();
                    nombreN = txtNombreInsumo.Text;
                    cant = cbxUnidadMedida.SelectedItem.ToString();
                    costo = Convert.ToDouble(txtCostoUnitario.Text);
                    accion = "ACTUALIZAR";
                    // MessageBox.Show("e "+ valor);
                    DialogResult opcion = MessageBox.Show("¿Está seguro que desea Actualizar este insumo ?", "Actualizar insumo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // MessageBox.Show(opcion.ToString());
                    if (opcion == DialogResult.OK)
                    {
                        string Retorno = por.EliminarActualizarInsumo(Nombre, nombreN, cant, costo, accion);
                        if (Retorno == "ERROR")
                        {
                            MessageBox.Show("Error al Actualizar insumo", "Actualizar Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Retorno == "ACTUAL")
                        {
                            MessageBox.Show("Insumo actualizado", "Actualizar Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarInsumos();
                            Limpiar();
                            btnGuardar.Enabled = true;
                            btnEliminar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se ha selecionado ningun insumo", "Seleccione un Insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        Limpiar();
                        btnGuardar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }

                }
            }
        }

        private void btnAcualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        
        }

        private void dgvMostrarIns_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int seleccionada;
            seleccionada = dgvMostrarIns.CurrentRow.Index;
            string Nombre = dgvMostrarIns.Rows[seleccionada].Cells[1].Value.ToString();
            string cant = dgvMostrarIns.Rows[seleccionada].Cells[2].Value.ToString();
            string costo = (dgvMostrarIns.Rows[seleccionada].Cells[3].Value.ToString());
            txtNombreInsumo.Text = Nombre;
            txtCostoUnitario.Text = costo;
            if (cant == "LT")
            {
             cbxUnidadMedida.SelectedIndex = 0;
            } else if (cant == "gg")
            {
                cbxUnidadMedida.SelectedIndex = 1;
            }
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;

        }
    }
}
