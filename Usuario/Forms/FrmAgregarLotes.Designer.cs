namespace Usuario.Forms
{
    partial class FrmAgregarLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarLotes));
            this.PTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.dtpFechaSiembra = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxVariedad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PContenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PTop
            // 
            this.PTop.Controls.Add(this.btnCerrar);
            this.PTop.Controls.Add(this.label1);
            this.PTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTop.ForeColor = System.Drawing.Color.White;
            this.PTop.Location = new System.Drawing.Point(0, 0);
            this.PTop.Margin = new System.Windows.Forms.Padding(5);
            this.PTop.Name = "PTop";
            this.PTop.Size = new System.Drawing.Size(1370, 34);
            this.PTop.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1334, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Lote";
            // 
            // PContenedor
            // 
            this.PContenedor.Controls.Add(this.groupBox1);
            this.PContenedor.Controls.Add(this.dgvMostrar);
            this.PContenedor.Controls.Add(this.label2);
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 34);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1370, 715);
            this.PContenedor.TabIndex = 2;
            // 
            // dtpFechaSiembra
            // 
            this.dtpFechaSiembra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSiembra.Location = new System.Drawing.Point(28, 250);
            this.dtpFechaSiembra.Name = "dtpFechaSiembra";
            this.dtpFechaSiembra.Size = new System.Drawing.Size(365, 27);
            this.dtpFechaSiembra.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaSiembra);
            this.groupBox1.Controls.Add(this.cbxVariedad);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtTamano);
            this.groupBox1.Controls.Add(this.txtDueno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreLote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(690, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // cbxVariedad
            // 
            this.cbxVariedad.FormattingEnabled = true;
            this.cbxVariedad.Items.AddRange(new object[] {
            "Catimor",
            "Marsellesa",
            "Paca"});
            this.cbxVariedad.Location = new System.Drawing.Point(28, 185);
            this.cbxVariedad.Name = "cbxVariedad";
            this.cbxVariedad.Size = new System.Drawing.Size(365, 29);
            this.cbxVariedad.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(544, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(28, 307);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(365, 27);
            this.txtTamano.TabIndex = 1;
            // 
            // txtDueno
            // 
            this.txtDueno.Location = new System.Drawing.Point(28, 125);
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(365, 27);
            this.txtDueno.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tamaño (M²):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Variedad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de siembra:";
            // 
            // txtNombreLote
            // 
            this.txtNombreLote.Location = new System.Drawing.Point(28, 65);
            this.txtNombreLote.Name = "txtNombreLote";
            this.txtNombreLote.Size = new System.Drawing.Size(365, 27);
            this.txtNombreLote.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dueño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 186);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(629, 264);
            this.dgvMostrar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(287, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista";
            // 
            // FrmAgregarLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.PTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAgregarLotes";
            this.Text = "FrmAgregarLotes";
            this.Load += new System.EventHandler(this.FrmAgregarLotes_Load);
            this.PTop.ResumeLayout(false);
            this.PTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTop;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.TextBox txtNombreLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVariedad;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaSiembra;
    }
}