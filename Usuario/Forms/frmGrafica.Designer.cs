namespace Usuario.Forms
{
    partial class frmGrafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico1
            // 
            this.Grafico1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grafico1.BackColor = System.Drawing.Color.Transparent;
            this.Grafico1.BorderlineColor = System.Drawing.Color.Transparent;
            this.Grafico1.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.Grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico1.Legends.Add(legend1);
            this.Grafico1.Location = new System.Drawing.Point(0, 1);
            this.Grafico1.Name = "Grafico1";
            this.Grafico1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Grafico1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafico1.Series.Add(series1);
            this.Grafico1.Size = new System.Drawing.Size(424, 346);
            this.Grafico1.TabIndex = 0;
            // 
            // frmGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 341);
            this.Controls.Add(this.Grafico1);
            this.Name = "frmGrafica";
            this.Text = "frmGrafica";
            this.Load += new System.EventHandler(this.frmGrafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico1;
    }
}