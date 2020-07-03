namespace Usuario.Forms
{
    partial class FrmVerRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerRegistros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.btnAcepar = new System.Windows.Forms.Button();
            this.cbxLotes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblVariedad = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCtInsumo = new System.Windows.Forms.Label();
            this.lblctDh = new System.Windows.Forms.Label();
            this.lblcudh = new System.Windows.Forms.Label();
            this.lblDh = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PContenedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1289, 48);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(694, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir lote:";
            // 
            // PContenedor
            // 
            this.PContenedor.Controls.Add(this.btnAcepar);
            this.PContenedor.Controls.Add(this.cbxLotes);
            this.PContenedor.Controls.Add(this.panel1);
            this.PContenedor.Controls.Add(this.btnCerrar);
            this.PContenedor.Controls.Add(this.groupBox2);
            this.PContenedor.Controls.Add(this.label1);
            this.PContenedor.Controls.Add(this.groupBox1);
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 0);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1329, 698);
            this.PContenedor.TabIndex = 2;
            // 
            // btnAcepar
            // 
            this.btnAcepar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcepar.ForeColor = System.Drawing.Color.White;
            this.btnAcepar.Location = new System.Drawing.Point(804, 60);
            this.btnAcepar.Name = "btnAcepar";
            this.btnAcepar.Size = new System.Drawing.Size(93, 29);
            this.btnAcepar.TabIndex = 6;
            this.btnAcepar.Text = "Aceptar";
            this.btnAcepar.UseVisualStyleBackColor = true;
            this.btnAcepar.Click += new System.EventHandler(this.btnAcepar_Click);
            // 
            // cbxLotes
            // 
            this.cbxLotes.FormattingEnabled = true;
            this.cbxLotes.Location = new System.Drawing.Point(557, 61);
            this.cbxLotes.Name = "cbxLotes";
            this.cbxLotes.Size = new System.Drawing.Size(205, 29);
            this.cbxLotes.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-17, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 10);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerMas);
            this.groupBox2.Controls.Add(this.dgvActividades);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(432, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de actividades";
            // 
            // btnVerMas
            // 
            this.btnVerMas.Enabled = false;
            this.btnVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMas.ForeColor = System.Drawing.Color.White;
            this.btnVerMas.Location = new System.Drawing.Point(477, 79);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(93, 29);
            this.btnVerMas.TabIndex = 7;
            this.btnVerMas.Text = "Ver más";
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToResizeColumns = false;
            this.dgvActividades.AllowUserToResizeRows = false;
            this.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActividades.ColumnHeadersHeight = 30;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActividades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActividades.EnableHeadersVisualStyles = false;
            this.dgvActividades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.dgvActividades.Location = new System.Drawing.Point(6, 26);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActividades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActividades.RowHeadersWidth = 20;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvActividades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividades.Size = new System.Drawing.Size(448, 147);
            this.dgvActividades.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInsumos);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblVariedad);
            this.groupBox1.Controls.Add(this.lblLote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblActividad);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblCtInsumo);
            this.groupBox1.Controls.Add(this.lblctDh);
            this.groupBox1.Controls.Add(this.lblcudh);
            this.groupBox1.Controls.Add(this.lblDh);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblLugar);
            this.groupBox1.Controls.Add(this.lblCiclo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(156, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AllowUserToResizeColumns = false;
            this.dgvInsumos.AllowUserToResizeRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInsumos.ColumnHeadersHeight = 30;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsumos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInsumos.EnableHeadersVisualStyles = false;
            this.dgvInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.dgvInsumos.Location = new System.Drawing.Point(546, 115);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.RowHeadersWidth = 20;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvInsumos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInsumos.Size = new System.Drawing.Size(361, 122);
            this.dgvInsumos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(263, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblVariedad
            // 
            this.lblVariedad.Location = new System.Drawing.Point(714, 65);
            this.lblVariedad.Name = "lblVariedad";
            this.lblVariedad.Size = new System.Drawing.Size(165, 21);
            this.lblVariedad.TabIndex = 0;
            this.lblVariedad.Text = "variedad";
            this.lblVariedad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLote
            // 
            this.lblLote.Location = new System.Drawing.Point(372, 65);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(178, 21);
            this.lblLote.TabIndex = 0;
            this.lblLote.Text = "Nombre lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(622, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Variedad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblActividad.Location = new System.Drawing.Point(177, 142);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(110, 21);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblFecha.Location = new System.Drawing.Point(84, 142);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 21);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(1031, 142);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCtInsumo
            // 
            this.lblCtInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblCtInsumo.Location = new System.Drawing.Point(913, 142);
            this.lblCtInsumo.Name = "lblCtInsumo";
            this.lblCtInsumo.Size = new System.Drawing.Size(102, 21);
            this.lblCtInsumo.TabIndex = 0;
            this.lblCtInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblctDh
            // 
            this.lblctDh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblctDh.Location = new System.Drawing.Point(448, 142);
            this.lblctDh.Name = "lblctDh";
            this.lblctDh.Size = new System.Drawing.Size(102, 21);
            this.lblctDh.TabIndex = 0;
            this.lblctDh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcudh
            // 
            this.lblcudh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblcudh.Location = new System.Drawing.Point(379, 142);
            this.lblcudh.Name = "lblcudh";
            this.lblcudh.Size = new System.Drawing.Size(50, 21);
            this.lblcudh.TabIndex = 0;
            this.lblcudh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDh
            // 
            this.lblDh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblDh.Location = new System.Drawing.Point(306, 142);
            this.lblDh.Name = "lblDh";
            this.lblDh.Size = new System.Drawing.Size(53, 21);
            this.lblDh.TabIndex = 0;
            this.lblDh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.lblNum.Location = new System.Drawing.Point(15, 142);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 21);
            this.lblNum.TabIndex = 0;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(1031, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(913, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Costo Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(448, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Costo Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(377, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "C/U";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(306, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "D/H";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(177, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Actividad";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(84, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(319, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lote:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLugar
            // 
            this.lblLugar.Location = new System.Drawing.Point(435, 44);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(311, 21);
            this.lblLugar.TabIndex = 0;
            this.lblLugar.Text = "Lugar";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCiclo
            // 
            this.lblCiclo.Location = new System.Drawing.Point(431, 23);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(315, 21);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Ciclo Productivo";
            this.lblCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmVerRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1329, 698);
            this.Controls.Add(this.PContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmVerRegistros";
            this.Text = "FrmAgregarActividad";
            this.Load += new System.EventHandler(this.FrmVerRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcepar;
        private System.Windows.Forms.ComboBox cbxLotes;
        private System.Windows.Forms.Button btnVerMas;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label lblVariedad;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCtInsumo;
        private System.Windows.Forms.Label lblctDh;
        private System.Windows.Forms.Label lblcudh;
        private System.Windows.Forms.Label lblDh;
    }
}