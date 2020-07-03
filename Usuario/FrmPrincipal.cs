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
namespace Usuario
{
    public partial class FrmPrincipal : Form
    {
       datOpcion op = new datOpcion();
        datObtenerFecha of = new datObtenerFecha();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private Form formActivo = null;

        private void abrirForm(Form NuevoForm)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = NuevoForm;
            NuevoForm.TopLevel = false;
            NuevoForm.FormBorderStyle = FormBorderStyle.None;
            NuevoForm.Dock = DockStyle.Fill;
          //  PContenedor.Controls.Add(NuevoForm);
          //  PContenedor.Tag = NuevoForm;
            NuevoForm.BringToFront();
            NuevoForm.Show();


        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          /*  Boolean opci = op.getOpcion();
            MessageBox.Show(opci+" ");
            if (opci == false)
            {
             CerrarSesion();
             MessageBox.Show("Sesión cerrada");
            }*/
             Application.Exit();
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnReducir.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReducir_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Normal;
            btnReducir.Visible = false;
            btnMax.Visible = true;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //insumos
            abrirForm(new Forms.FrmAgregarInsumo());
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //actividad
            abrirForm(new Forms.FrmAgregarActividad());
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //lotes
            abrirForm(new Forms.FrmAgregarLotes());
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //ciclos
            abrirForm(new Forms.FrmAgregarCiclos());
        }

        private void labelBar_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        public void CerrarSesion()
        {
            datIPMaquina ip = new datIPMaquina();

            string localIP = ip.ObtenerMac();


           datConsultas add = new datConsultas();
            int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + localIP + "' "));
            //MessageBox.Show(result + " ");
            string nom = Convert.ToString(add.ConsultaN("SELECT nombreUsuario from usuarios where idUsuario ='" + result + "' "));
            string clav = Convert.ToString(add.ConsultaN("SELECT claveUsuario from usuarios where idUsuario ='" + result + "' "));
            datLogin s = new datLogin();
            string fecha = of.ObtenerFecha();
            string res = Convert.ToString(s.AbrirSesion("Salir", nom, clav, localIP, result,fecha));
            if (res == "CERRADA")
            {
                this.Close();
            }
        }
      

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            lblecha.Text = of.ObtenerFechaSencilla();
            labelBar.Text = "";
            datConsultas add = new datConsultas();
            datIPMaquina ip = new datIPMaquina();
            string localIP = ip.ObtenerMac();
            int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + localIP + "' "));
            string nom = Convert.ToString(add.ConsultaN("SELECT Nombre from usuarios where idUsuario ='" + result + "' "));
            string labor = add.ConsultaN("Select tipo_usuario from usuarios where idUsuario = '"+ result +"' ");
            string lab = ("Finca Oropendula  '" + nom.ToUpper() + "'   '"+labor+"'");
            labelBar.Text =lab;
            string may = labor.ToUpper();
            //MessageBox.Show(may);
           if(may.Equals("ADMINISTRADOR"))//Aqui deberia bloquearse o dar permisos al administrador
            {
             
           
             //   MessageBox.Show("1");
            }
            else if (may.Equals("INVITADO") )//Aqui deberia bloquearse o dar persmisos al invitado
            {
          
              //  MessageBox.Show("1");
            }
          
        }

        private void lblecha_Click(object sender, EventArgs e)
        {

        }

        private void manejoDePlantacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmManejoDePlantanciones());
        }

        private void verRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Forms.FrmVerRegistros());
        }
    }
}
