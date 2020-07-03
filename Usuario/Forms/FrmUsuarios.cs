using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Microsoft.VisualBasic;
namespace Usuario.Forms
{
    public partial class FrmUsuarios : Form
    {
        datObtenerFecha fe = new datObtenerFecha();
        datUsuario u = new datUsuario();
        datIPMaquina ip = new datIPMaquina();
        datConsultas c = new datConsultas();
        datEliminarUser e = new datEliminarUser();
        datConsultas add = new datConsultas();
        dtValidacionBox V = new dtValidacionBox();
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        //Metodo Agregar Usuario
        public void Usuario()
        {

            if (txtNombre.Text.Trim() != "" && txtNombreUsuario.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                string NUadmin = "";
                string NombreUsuario = txtNombreUsuario.Text;
                string Nombre = txtNombre.Text;
                string Pass = txtPass.Text;
                string tipo = cbxUsuario.SelectedItem.ToString();
                string fecha = fe.ObtenerFechaSinHora();
                string hora = fe.ObtenerHora();
                string ipMaquina = ip.ObtenerMac();
                string idUsuario = c.ConsultaN("select idUsuario from ip where ipFisico = '" + ipMaquina + "'");
                if (idUsuario != null)
                {
                    int id = Convert.ToInt32(c.ConsultaN("select idUsuario from ip where ipFisico = '" + ipMaquina + "'"));
                    NUadmin = c.ConsultaN("select Nombre from usuarios where idUsuario = '" + id + "'");
                }
                int estado = 0;
                string Accion = "AGREGAR";
                string consulta = u.AgregarUsuario(Accion, Nombre, NUadmin, Pass, estado, tipo, ipMaquina, fecha, hora, NombreUsuario.ToLower());
                if (consulta == "NOEXISTE")
                {
                    MessageBox.Show("El usuario ha sido guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    clean();
                }
                else if (consulta == "EXISTE")
                {
                    MessageBox.Show("El usuario ya existe", "Existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uno de los campos estan vacios", "Llenar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario();
            

        }
       
        //Metodo para cargar datos en el dataGrid
        private void Mostrar()
        {
            dtgUsuarios.DataSource = c.Datos("SELECT Nombre as 'Nombre',nombreUsuario as 'Usuario',tipo_usuario  as 'Tipo de Usuario' FROM usuarios");
        }
        //Limpiar textos
        private void clean()
        {
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtPass.Clear();
        }
        //Eliminar usuario
        public void Eliminar()
        {
            int seleccionada = 0;
            string valor,Ip,fecha,hora;
           
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                    seleccionada = dtgUsuarios.CurrentRow.Index;
                    valor = dtgUsuarios.Rows[seleccionada].Cells[1].Value.ToString();
                    DialogResult opcion =  MessageBox.Show("¿Está seguro que desea eliminar este usuario ?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string PassAdmin = Interaction.InputBox("Ingrese su contraseña de usuario ", "Ingresar Contraseña");
                    Ip = ip.ObtenerMac();
                    fecha = fe.ObtenerFechaSinHora();
                    hora = fe.ObtenerHora();
                    int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + Ip + "' "));
                    string nom = Convert.ToString(add.ConsultaN("SELECT nombreUsuario from usuarios where idUsuario ='" + result + "' "));

                    string Retorno = e.EliminarUsuario(valor, nom, PassAdmin, fecha, hora, Ip);
                    if (Retorno == "ERROR")
                    {
                        MessageBox.Show("Error al eliminar usuario", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Retorno == "ELIMINADO")
                    {
                        MessageBox.Show("Usuario Eliminado", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                    }
                  }
                }
            else
            {
                 MessageBox.Show("No se ha selecionado ningun usuario", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Mostrar();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        //----------------------Eventos Click----------------------------
        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                Label.Text = "30";
            }
            else
            {
                string tam = txtNombre.Text;
                int val = 30 - (tam.Length);
                Label.Text = Convert.ToString(val);
            }
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Trim() == "")
            {
                Label.Text = "20";
            }
            else
            {
                string tam = txtNombreUsuario.Text;
                int val = 20 - (tam.Length);
                Label.Text = Convert.ToString(val);
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "")
            {
                Label.Text = "20";
            }
            else
            {
                string tam = txtPass.Text;
                int val = 20 - (tam.Length);
                Label.Text = Convert.ToString(val);
            }
        }
        //---------------------------------------------------------------------
        //-----------------Eventos KeyPress-----------------------------------
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.ValidarTexto(30,Label,e);
            V.ValidacionSoloLetra(e);
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.ValidarTexto(20, Label, e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.ValidarTexto(20, Label, e);
        }
    }
}
