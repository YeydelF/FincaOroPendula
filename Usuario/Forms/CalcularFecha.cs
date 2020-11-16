using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Usuario.Forms
{
    public partial class CalcularFecha : Form
    {
        public CalcularFecha()
        {
            InitializeComponent();
        }
        string dia = DateTime.Now.ToString("dd");
        string mes = DateTime.Now.ToString("MM");
        string año = DateTime.Now.ToString("yyyy");
        ArrayList arr = new ArrayList();

        private void CalcularFecha_Load(object sender, EventArgs e)
        {
            //calcularFecha();
            llenar();
           
        }
        private void llenar()
        {
            lblMes.Text = mes;
            lblAño.Text = año;
        }
        private void calcularFecha()
        {
            string dia = DateTime.Now.ToString("dd");
            string mes = DateTime.Now.ToString("MM");
            string año = DateTime.Now.ToString("yyyy");

            int m = Convert.ToInt32(mes);
            int y = Convert.ToInt32(año);

            int nm = m + 1;
            if(nm >12)
            {
                nm = 1;
                int ny = y + 1;
               
                string fecha = dia + "/" + nm + "/" + ny;
                dateTimePicker2.Text = fecha;
            }
            else
            {
             
                string fecha = dia + "/" + nm + "/" + y;
                dateTimePicker2.Text = fecha;
            }

            
        }
        private void fechaFinal(int meses)
        {
            dgvFechas.Rows.Clear();
            dgvFechas.Refresh();
            string fecha= "";
            string fac = dateTimePicker2.Value.ToString("dd");
            
            for (int i =0;i< meses; i++)
            {
                int m = Convert.ToInt32(lblMes.Text.Trim());
                int y = Convert.ToInt32(lblAño.Text.Trim());
                int nm = m + 1;
                if (nm > 12)
                {
                    nm = 1;
                    int ny = y + 1;
                   // lblFecha.Text = dia + "/" + nm + "/" + ny;
                 
                    lblMes.Text = nm+"";
                    lblAño.Text = ny + "";
                    fecha = dia + "/" + lblMes.Text + "/" + lblAño.Text;
                    arr.Add(fecha);
                 

                   
                     Console.WriteLine(lblMes.Text + "/"+ lblAño.Text);
                }
                else
                {
                  //  lblFecha.Text = dia + "/" + nm + "/" + y;
                  
                    lblMes.Text = nm + "";
                    lblAño.Text = y + "";
                    fecha = dia + "/" + lblMes.Text + "/" + lblAño.Text;
                    arr.Add(fecha);
                    
                     Console.WriteLine(lblMes.Text + "/" + lblAño.Text);
                }

            }
            fecha = dia + "/"+lblMes.Text + "/"+ lblAño.Text;
           // lblFecha.Text = fecha;
            dateTimePicker1.Text = fecha;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtmeses.Text.Trim());
            fechaFinal(n);
            cargar();
          calcularFecha();
            lblMes.Text = mes;
            lblAño.Text = año;
            arr.Clear();
           
        }
        private void cargar()
        {
            for (int i=0; i < arr.Count; i++)
            {
                string n = arr[i].ToString();
                dgvFechas.Rows.Add(n.ToString());
            }
          
               
            
        }
    }
}
