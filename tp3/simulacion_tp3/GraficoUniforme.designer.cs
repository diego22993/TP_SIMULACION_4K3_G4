namespace simulacion_tp1
{
    partial class GraficoUniforme
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
            this.ch_uniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_graficoUniforme = new System.Windows.Forms.DataGridView();
            this.col_limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frec_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_chi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salirGrafUnif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ch_uniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoUniforme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ch_uniforme
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_uniforme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_uniforme.Legends.Add(legend1);
            this.ch_uniforme.Location = new System.Drawing.Point(18, 19);
            this.ch_uniforme.Name = "ch_uniforme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_uniforme.Series.Add(series1);
            this.ch_uniforme.Size = new System.Drawing.Size(545, 283);
            this.ch_uniforme.TabIndex = 0;
            this.ch_uniforme.Text = "chart1";
            this.ch_uniforme.Click += new System.EventHandler(this.ch_uniforme_Click);
            // 
            // dgv_graficoUniforme
            // 
            this.dgv_graficoUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_graficoUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_limiteInferior,
            this.col_limiteSuperior,
            this.col_frec_obs,
            this.col_fe,
            this.col_c});
            this.dgv_graficoUniforme.Location = new System.Drawing.Point(16, 19);
            this.dgv_graficoUniforme.Name = "dgv_graficoUniforme";
            this.dgv_graficoUniforme.Size = new System.Drawing.Size(547, 150);
            this.dgv_graficoUniforme.TabIndex = 1;
            // 
            // col_limiteInferior
            // 
            this.col_limiteInferior.HeaderText = "Li";
            this.col_limiteInferior.Name = "col_limiteInferior";
            // 
            // col_limiteSuperior
            // 
            this.col_limiteSuperior.HeaderText = "Ls";
            this.col_limiteSuperior.Name = "col_limiteSuperior";
            // 
            // col_frec_obs
            // 
            this.col_frec_obs.HeaderText = "Fo";
            this.col_frec_obs.Name = "col_frec_obs";
            // 
            // col_fe
            // 
            this.col_fe.HeaderText = "Fe";
            this.col_fe.Name = "col_fe";
            // 
            // col_c
            // 
            this.col_c.HeaderText = "C";
            this.col_c.Name = "col_c";
            // 
            // btn_chi
            // 
            this.btn_chi.Location = new System.Drawing.Point(12, 508);
            this.btn_chi.Name = "btn_chi";
            this.btn_chi.Size = new System.Drawing.Size(196, 23);
            this.btn_chi.TabIndex = 2;
            this.btn_chi.Text = "Realizar prueba de Chi-Cuadrado";
            this.btn_chi.UseVisualStyleBackColor = true;
            this.btn_chi.Click += new System.EventHandler(this.btn_chi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_graficoUniforme);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ch_uniforme);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 308);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // btn_salirGrafUnif
            // 
            this.btn_salirGrafUnif.Location = new System.Drawing.Point(516, 508);
            this.btn_salirGrafUnif.Name = "btn_salirGrafUnif";
            this.btn_salirGrafUnif.Size = new System.Drawing.Size(75, 23);
            this.btn_salirGrafUnif.TabIndex = 5;
            this.btn_salirGrafUnif.Text = "Volver";
            this.btn_salirGrafUnif.UseVisualStyleBackColor = true;
            this.btn_salirGrafUnif.Click += new System.EventHandler(this.btn_salirGrafUnif_Click);
            // 
            // GraficoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 547);
            this.Controls.Add(this.btn_salirGrafUnif);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_chi);
            this.Name = "GraficoUniforme";
            this.Text = "GraficoUniforme";
            this.Load += new System.EventHandler(this.GraficoUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_uniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoUniforme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart ch_uniforme;
        public System.Windows.Forms.DataGridView dgv_graficoUniforme;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_limiteInferior;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_limiteSuperior;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_frec_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_c;
        private System.Windows.Forms.Button btn_chi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salirGrafUnif;
    }
}