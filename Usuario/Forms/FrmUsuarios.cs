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
namespace Usuario.Forms
{
    public partial class FrmUsuarios : Form
    {
        datObtenerFecha fe = new datObtenerFecha();
        datUsuario u = new datUsuario();
        datIPMaquina ip = new datIPMaquina();
        datConsultas c = new datConsultas();
        
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        public void Usuario()
        {
            string NUadmin = "";
            string NombreUsuario = txtNombreUsuario.Text;
            string Nombre = txtNombre.Text;
            string Pass = txtPass.Text;
            string tipo = cbxUsuario.SelectedItem.ToString();
            string fecha = fe.ObtenerFechaSinHora();
            string hora = fe.ObtenerHora();
            string ipMaquina = ip.ObtenerMac();
            string idUsuario = c.ConsultaN("select idUsuario from ip where ipFisico = '"+ipMaquina+"'");
            if(idUsuario != null)
            {
                int id = Convert.ToInt32( c.ConsultaN("select idUsuario from ip where ipFisico = '" + ipMaquina + "'"));
                NUadmin = c.ConsultaN("select Nombre from usuarios where idUsuario = '"+ id +"'");
            }
            int estado = 0;
            string Accion = "AGREGAR";
            string consulta = u.AgregarUsuario(Accion,Nombre,NUadmin,Pass,estado,tipo,ipMaquina,fecha,hora,NombreUsuario);
            if (consulta == "NOEXISTE")
            {
                MessageBox.Show("El usuario ha sido guardado","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (consulta == "EXISTE") 
            {
             MessageBox.Show("El usuario ya existe", "Existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dtgUsuarios.DataSource = c.Datos("SELECT Nombre as 'Nombre',nombreUsuario as 'Usuario',tipo_usuario  as 'Tipo de Usuario' FROM usuarios");
        }
    }
}
