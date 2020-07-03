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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        datLogin s = new datLogin();
        datIPMaquina ip = new datIPMaquina();
        datConsultas add = new datConsultas();
       FrmPrincipal2 p = new FrmPrincipal2();//Muesra el frame principal
        datObtenerFecha of = new datObtenerFecha();
        //----------Metodo iniciar sesión ---------------------------
        public void Iniciar()
        {

            string usuario;
            string cont;
            string resultante;
            int result = 0;
            usuario = txtUser.Text;
            cont = txtPass.Text;
            if (txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "")//que los campos no esten vacios
            {
                MessageBox.Show("Por favor rellene los campos correspondientes", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string localIP = ip.ObtenerMac();//Obtener mac de la maquina para logiarse y guardar historial
                string rg = add.ConsultaN("SELECT idUsuario from Usuarios where nombreUsuario ='" + usuario + "' and claveUsuario = '" + cont + "' ");//Obtener el idUsuario, para saber si esta iniciada la sesion

                if (rg != "")// que no mande la consulta un dato nulo
                {
                    result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from Usuarios where nombreUsuario ='" + usuario + "' and claveUsuario = '" + cont + "' "));//iniciar sesion sin login, por que ya esta iniciada
                }
                else
                {
                    result = 0;//Inicar sesion con Login, no hay sesión iniciada
                }
                

                //  s.AbrirSesion("1",usuario,cont);
                string fecha = of.ObtenerFecha();//Obtener fecha para el historial
                resultante = s.AbrirSesion("Entrar", usuario, cont, localIP, result,fecha);
                if (resultante == "ERROR")//si el procedimiento envia error, es que algun dato esta malo
                {
                   
                    MessageBox.Show("El Usuario o Contraseña es Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (resultante == "INICIAR")//El procedimiento envia que todo esta bien y que se puede iniciar sesion
                {
                   
                   p.Show();
                  //  p.Text = "Principal " + txtUser.Text;//Enviar a el titulo del frame el nombre del usuario que se logió
                    this.Close();


                }
                else if (resultante == "OPEN")//ya esta iniciada la sesion, respuesta enviada por el procedimiento
                {
                    MessageBox.Show("La Sesión está iniciada", "Sesión Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //------------------------------------------------------------------------------
        //Metodo Obtener fecha y hora
       
       //----------------------------
        //Eventos Click y KeyPress
        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                Label.Text = "20";
            }
            else
            {
                string tam = txtUser.Text;
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

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtValidacionBox V = new dtValidacionBox();
            V.ValidarTexto(20, Label, e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtValidacionBox V = new dtValidacionBox();
            V.ValidarTexto(20, Label, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar();
          /*  datOpcion op = new datOpcion();//objeto de la clase opcion
            if (cbRecordar.Checked)//si el checkbox esta seleccionado
            {
                op.setOpcion(true);//envia si al metodo de la clase
            }
            else
            {
                op.setOpcion(false);//envia no al metodo de la clase
            }*/
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64,173,108);//cambia de color el boton
            string IpLocal = ip.ObtenerMac();//obtiene mac, para consulta
            string revisar = add.ConsultaN("SELECT idUsuario from ip where ipFisico = '" + IpLocal + "' ");//consulta

          //  MessageBox.Show(" " + revisar + " " + IpLocal);
            if (revisar != "")//si no es nulo el valor resivido por la base de datos
            {
                int result = Convert.ToInt32(add.ConsultaN("SELECT idUsuario from ip where ipFisico ='" + IpLocal + "' "));//obtener id de usuario
                string nom = Convert.ToString(add.ConsultaN("SELECT nombreUsuario from usuarios where idUsuario ='" + result + "' "));//obtener el nombre de usuario
                string clav = Convert.ToString(add.ConsultaN("SELECT claveUsuario from usuarios where idUsuario ='" + result + "' "));//obtener la clave de usuario
                string fecha = of.ObtenerFecha();//obtine la fecha
                string res = Convert.ToString(s.AbrirSesion("Entrar", nom, clav, IpLocal, result,fecha));//iniciar el procedimiento de almacenado
                if (res == "OPEN")//si la sesion esta abierta en la BD
                {
                    p.Show();
                  //  p.Text = "Principal " + nom;
                    this.Close();
                }
               
            }

        }//Metodo Load del FrmLogin

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------
    }
}
