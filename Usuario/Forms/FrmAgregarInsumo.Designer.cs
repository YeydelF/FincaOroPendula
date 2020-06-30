namespace Usuario.Forms
{
    partial class FrmAgregarInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarInsumo));
            this.PTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMostrarIns = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarIns)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar insumo";
            // 
            // PContenedor
            // 
            this.PContenedor.Controls.Add(this.groupBox1);
            this.PContenedor.Controls.Add(this.dgvMostrarIns);
            this.PContenedor.Controls.Add(this.label2);
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 34);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1370, 715);
            this.PContenedor.TabIndex = 2;
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
            // dgvMostrarIns
            // 
            this.dgvMostrarIns.AllowUserToAddRows = false;
            this.dgvMostrarIns.AllowUserToDeleteRows = false;
            this.dgvMostrarIns.AllowUserToResizeColumns = false;
            this.dgvMostrarIns.AllowUserToResizeRows = false;
            this.dgvMostrarIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarIns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvMostrarIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarIns.Location = new System.Drawing.Point(12, 186);
            this.dgvMostrarIns.Name = "dgvMostrarIns";
            this.dgvMostrarIns.Size = new System.Drawing.Size(629, 264);
            this.dgvMostrarIns.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.cbxUnidadMedida);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.txtNombreInsumo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(690, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
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
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(28, 62);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(365, 27);
            this.txtNombreInsumo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidad de medida: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costo Unitario: ";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(28, 208);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(365, 27);
            this.txtCostoUnitario.TabIndex = 1;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "LT",
            "qq"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(28, 134);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(365, 29);
            this.cbxUnidadMedida.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(542, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAgregarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.PTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAgregarInsumo";
            this.Text = "FrmAgregarInsumo";
            this.Load += new System.EventHandler(this.FrmAgregarInsumo_Load);
            this.PTop.ResumeLayout(false);
            this.PTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarIns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTop;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMostrarIns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}