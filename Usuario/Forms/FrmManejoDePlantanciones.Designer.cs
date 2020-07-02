namespace Usuario.Forms
{
    partial class FrmManejoDePlantanciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManejoDePlantanciones));
            this.PTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GbAgregar = new System.Windows.Forms.GroupBox();
            this.gbInsumos = new System.Windows.Forms.GroupBox();
            this.txtCantInsumo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxInsumo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsumUtilizados = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCUDH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxActividad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxLote = new System.Windows.Forms.ComboBox();
            this.cbxCiclo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PContenedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbAgregar.SuspendLayout();
            this.gbInsumos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.PTop.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(345, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de gastos/Manejo de plantaciones";
            // 
            // PContenedor
            // 
            this.PContenedor.Controls.Add(this.btnFinalizar);
            this.PContenedor.Controls.Add(this.groupBox2);
            this.PContenedor.Controls.Add(this.groupBox1);
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 34);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1370, 715);
            this.PContenedor.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(699, 633);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(96, 31);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GbAgregar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxActividad);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(356, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 424);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // GbAgregar
            // 
            this.GbAgregar.Controls.Add(this.gbInsumos);
            this.GbAgregar.Controls.Add(this.btnListo);
            this.GbAgregar.Controls.Add(this.label8);
            this.GbAgregar.Controls.Add(this.txtInsumUtilizados);
            this.GbAgregar.ForeColor = System.Drawing.Color.White;
            this.GbAgregar.Location = new System.Drawing.Point(10, 207);
            this.GbAgregar.Name = "GbAgregar";
            this.GbAgregar.Size = new System.Drawing.Size(761, 202);
            this.GbAgregar.TabIndex = 4;
            this.GbAgregar.TabStop = false;
            this.GbAgregar.Text = "Insumos ";
            // 
            // gbInsumos
            // 
            this.gbInsumos.Controls.Add(this.txtCantInsumo);
            this.gbInsumos.Controls.Add(this.btnAgregar);
            this.gbInsumos.Controls.Add(this.label10);
            this.gbInsumos.Controls.Add(this.cbxInsumo);
            this.gbInsumos.Controls.Add(this.label9);
            this.gbInsumos.Location = new System.Drawing.Point(100, 64);
            this.gbInsumos.Name = "gbInsumos";
            this.gbInsumos.Size = new System.Drawing.Size(552, 121);
            this.gbInsumos.TabIndex = 5;
            this.gbInsumos.TabStop = false;
            this.gbInsumos.Visible = false;
            // 
            // txtCantInsumo
            // 
            this.txtCantInsumo.Location = new System.Drawing.Point(385, 33);
            this.txtCantInsumo.Name = "txtCantInsumo";
            this.txtCantInsumo.Size = new System.Drawing.Size(151, 27);
            this.txtCantInsumo.TabIndex = 3;
            this.txtCantInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantInsumo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(233, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 31);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cantidad:";
            // 
            // cbxInsumo
            // 
            this.cbxInsumo.FormattingEnabled = true;
            this.cbxInsumo.Location = new System.Drawing.Point(82, 33);
            this.cbxInsumo.Name = "cbxInsumo";
            this.cbxInsumo.Size = new System.Drawing.Size(190, 29);
            this.cbxInsumo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Insumo:";
            // 
            // btnListo
            // 
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.Location = new System.Drawing.Point(360, 29);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(96, 31);
            this.btnListo.TabIndex = 4;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad de insumos utilizados:";
            // 
            // txtInsumUtilizados
            // 
            this.txtInsumUtilizados.Location = new System.Drawing.Point(267, 31);
            this.txtInsumUtilizados.Name = "txtInsumUtilizados";
            this.txtInsumUtilizados.Size = new System.Drawing.Size(71, 27);
            this.txtInsumUtilizados.TabIndex = 3;
            this.txtInsumUtilizados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsumUtilizados_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCUDH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDH);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 113);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Días/Hombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "D/H:";
            // 
            // txtCUDH
            // 
            this.txtCUDH.Location = new System.Drawing.Point(150, 72);
            this.txtCUDH.Name = "txtCUDH";
            this.txtCUDH.Size = new System.Drawing.Size(188, 27);
            this.txtCUDH.TabIndex = 3;
            this.txtCUDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUDH_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "C/U:";
            // 
            // txtDH
            // 
            this.txtDH.Location = new System.Drawing.Point(150, 20);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(188, 27);
            this.txtDH.TabIndex = 3;
            this.txtDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDH_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Actividad: ";
            // 
            // cbxActividad
            // 
            this.cbxActividad.FormattingEnabled = true;
            this.cbxActividad.Location = new System.Drawing.Point(160, 43);
            this.cbxActividad.Name = "cbxActividad";
            this.cbxActividad.Size = new System.Drawing.Size(188, 29);
            this.cbxActividad.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cbxLote);
            this.groupBox1.Controls.Add(this.cbxCiclo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(391, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(491, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(202, 27);
            this.dtpFecha.TabIndex = 2;
            // 
            // cbxLote
            // 
            this.cbxLote.FormattingEnabled = true;
            this.cbxLote.Location = new System.Drawing.Point(160, 96);
            this.cbxLote.Name = "cbxLote";
            this.cbxLote.Size = new System.Drawing.Size(188, 29);
            this.cbxLote.TabIndex = 1;
            // 
            // cbxCiclo
            // 
            this.cbxCiclo.FormattingEnabled = true;
            this.cbxCiclo.Location = new System.Drawing.Point(160, 40);
            this.cbxCiclo.Name = "cbxCiclo";
            this.cbxCiclo.Size = new System.Drawing.Size(188, 29);
            this.cbxCiclo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lote: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciclo productivo: ";
            // 
            // FrmManejoDePlantanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.PTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmManejoDePlantanciones";
            this.Text = "FrmManejoDePlantanciones";
            this.Load += new System.EventHandler(this.FrmManejoDePlantanciones_Load);
            this.PTop.ResumeLayout(false);
            this.PTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PContenedor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbAgregar.ResumeLayout(false);
            this.GbAgregar.PerformLayout();
            this.gbInsumos.ResumeLayout(false);
            this.gbInsumos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxLote;
        private System.Windows.Forms.ComboBox cbxCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GbAgregar;
        private System.Windows.Forms.GroupBox gbInsumos;
        private System.Windows.Forms.TextBox txtCantInsumo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxInsumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInsumUtilizados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCUDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxActividad;
    }
}