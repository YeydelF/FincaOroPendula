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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.mensaje2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mensaje1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMostrarIns = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAcualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarIns)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PContenedor
            // 
            this.PContenedor.Controls.Add(this.mensaje2);
            this.PContenedor.Controls.Add(this.pictureBox1);
            this.PContenedor.Controls.Add(this.Mensaje1);
            this.PContenedor.Controls.Add(this.label1);
            this.PContenedor.Controls.Add(this.btnCerrar);
            this.PContenedor.Controls.Add(this.panel1);
            this.PContenedor.Controls.Add(this.groupBox2);
            this.PContenedor.Controls.Add(this.groupBox1);
            this.PContenedor.Controls.Add(this.label2);
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 0);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1360, 625);
            this.PContenedor.TabIndex = 2;
            this.PContenedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PContenedor_MouseDoubleClick);
            // 
            // mensaje2
            // 
            this.mensaje2.AutoSize = true;
            this.mensaje2.Font = new System.Drawing.Font("Arial", 10F);
            this.mensaje2.ForeColor = System.Drawing.Color.White;
            this.mensaje2.Location = new System.Drawing.Point(84, 580);
            this.mensaje2.Name = "mensaje2";
            this.mensaje2.Size = new System.Drawing.Size(449, 16);
            this.mensaje2.TabIndex = 13;
            this.mensaje2.Text = "Para Cancelar la actualización presione doble click en cualquier lugar.";
            this.mensaje2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 558);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Mensaje1
            // 
            this.Mensaje1.AutoSize = true;
            this.Mensaje1.Font = new System.Drawing.Font("Arial", 10F);
            this.Mensaje1.ForeColor = System.Drawing.Color.White;
            this.Mensaje1.Location = new System.Drawing.Point(84, 558);
            this.Mensaje1.Name = "Mensaje1";
            this.Mensaje1.Size = new System.Drawing.Size(436, 16);
            this.Mensaje1.TabIndex = 11;
            this.Mensaje1.Text = "Para actualizar un insumo, presione doble click en el inicio de la fila.";
            this.Mensaje1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(590, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestionar los Insumos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1340, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 5);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMostrarIns);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 405);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // dgvMostrarIns
            // 
            this.dgvMostrarIns.AllowUserToAddRows = false;
            this.dgvMostrarIns.AllowUserToDeleteRows = false;
            this.dgvMostrarIns.AllowUserToResizeColumns = false;
            this.dgvMostrarIns.AllowUserToResizeRows = false;
            this.dgvMostrarIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarIns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvMostrarIns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarIns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarIns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarIns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarIns.ColumnHeadersHeight = 30;
            this.dgvMostrarIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarIns.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarIns.EnableHeadersVisualStyles = false;
            this.dgvMostrarIns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.dgvMostrarIns.Location = new System.Drawing.Point(6, 33);
            this.dgvMostrarIns.Name = "dgvMostrarIns";
            this.dgvMostrarIns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarIns.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarIns.RowHeadersWidth = 20;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvMostrarIns.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrarIns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarIns.Size = new System.Drawing.Size(642, 366);
            this.dgvMostrarIns.TabIndex = 2;
            this.dgvMostrarIns.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMostrarIns_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAcualizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.cbxUnidadMedida);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.txtNombreInsumo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(733, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // btnAcualizar
            // 
            this.btnAcualizar.FlatAppearance.BorderSize = 3;
            this.btnAcualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAcualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAcualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcualizar.Location = new System.Drawing.Point(410, 309);
            this.btnAcualizar.Name = "btnAcualizar";
            this.btnAcualizar.Size = new System.Drawing.Size(96, 38);
            this.btnAcualizar.TabIndex = 5;
            this.btnAcualizar.Text = "Actualizar";
            this.btnAcualizar.UseVisualStyleBackColor = true;
            this.btnAcualizar.Click += new System.EventHandler(this.btnAcualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(277, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 38);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(141, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "LT",
            "qq"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(141, 162);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(365, 26);
            this.cbxUnidadMedida.TabIndex = 2;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(141, 236);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(365, 26);
            this.txtCostoUnitario.TabIndex = 1;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(141, 90);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(365, 26);
            this.txtNombreInsumo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costo Unitario: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidad de medida: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
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
            // FrmAgregarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1360, 625);
            this.Controls.Add(this.PContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAgregarInsumo";
            this.Text = "Gestión de Insumos";
            this.Load += new System.EventHandler(this.FrmAgregarInsumo_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmAgregarInsumo_MouseDoubleClick);
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarIns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMostrarIns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAcualizar;
        private System.Windows.Forms.Label Mensaje1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mensaje2;
    }
}