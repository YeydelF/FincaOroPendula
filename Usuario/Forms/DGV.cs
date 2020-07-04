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
    public partial class DGV : Form
    {
        public DGV()
        {
            InitializeComponent();
        }

        private void DGV_Load(object sender, EventArgs e)
        {
            datConsultas c = new datConsultas();
            
            DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();
            columna.Name = "Agregar";
            columna.Width = 70;
            columna.HeaderText = "Agregar";
            dgvInsumos.DataSource = c.Datos("select insumos.idInsumo as 'ID',insumos.nombre as 'Nombre',insumos.costoUnitario as 'Costo'from insumos");
            dgvInsumos.Columns.Add(columna);
            dgvInsumos.Columns.Add("Cantidad","Cantidad");
           
        }
    }
}
