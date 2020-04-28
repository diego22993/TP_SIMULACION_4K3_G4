namespace simulacion_tp1
{
    partial class GraficoPoisson
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
            this.dgv_graficoPoisson = new System.Windows.Forms.DataGridView();
            this.ch_poisson = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.col_limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frec_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoPoisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_poisson)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_graficoPoisson
            // 
            this.dgv_graficoPoisson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_graficoPoisson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_limiteInferior,
            this.col_limiteSuperior,
            this.col_frec_obs,
            this.col_prob,
            this.col_fe,
            this.col_c});
            this.dgv_graficoPoisson.Location = new System.Drawing.Point(6, 19);
            this.dgv_graficoPoisson.Name = "dgv_graficoPoisson";
            this.dgv_graficoPoisson.Size = new System.Drawing.Size(642, 150);
            this.dgv_graficoPoisson.TabIndex = 3;
            // 
            // ch_poisson
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_poisson.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_poisson.Legends.Add(legend1);
            this.ch_poisson.Location = new System.Drawing.Point(6, 19);
            this.ch_poisson.Name = "ch_poisson";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_poisson.Series.Add(series1);
            this.ch_poisson.Size = new System.Drawing.Size(642, 261);
            this.ch_poisson.TabIndex = 2;
            this.ch_poisson.Text = "chart1";
            // 
            // btn_chi
            // 
            this.btn_chi.Location = new System.Drawing.Point(12, 510);
            this.btn_chi.Name = "btn_chi";
            this.btn_chi.Size = new System.Drawing.Size(201, 23);
            this.btn_chi.TabIndex = 4;
            this.btn_chi.Text = "Realizar prueba Chi-Cuadrado";
            this.btn_chi.UseVisualStyleBackColor = true;
            this.btn_chi.Click += new System.EventHandler(this.btn_chi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_graficoPoisson);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ch_poisson);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(598, 510);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Volver";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
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
            // col_prob
            // 
            this.col_prob.HeaderText = "P()";
            this.col_prob.Name = "col_prob";
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
            // GraficoPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 539);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_chi);
            this.Name = "GraficoPoisson";
            this.Text = "GraficoPoisson";
            this.Load += new System.EventHandler(this.GraficoPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoPoisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_poisson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_graficoPoisson;
        public System.Windows.Forms.DataVisualization.Charting.Chart ch_poisson;
        private System.Windows.Forms.Button btn_chi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_limiteInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_limiteSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_frec_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_c;
    }
}