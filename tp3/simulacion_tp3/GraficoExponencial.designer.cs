namespace simulacion_tp1
{
    partial class GraficoExponencial
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
            this.dgv_graficoExponencial = new System.Windows.Forms.DataGridView();
            this.col_limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frec_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_proEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_exponencial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salirGrafi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_exponencial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_graficoExponencial
            // 
            this.dgv_graficoExponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_graficoExponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_limiteInferior,
            this.col_limiteSuperior,
            this.col_frec_obs,
            this.col_fe,
            this.col_c,
            this.col_proEsp});
            this.dgv_graficoExponencial.Location = new System.Drawing.Point(19, 19);
            this.dgv_graficoExponencial.Name = "dgv_graficoExponencial";
            this.dgv_graficoExponencial.Size = new System.Drawing.Size(651, 178);
            this.dgv_graficoExponencial.TabIndex = 3;
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
            // col_proEsp
            // 
            this.col_proEsp.HeaderText = "P() E";
            this.col_proEsp.Name = "col_proEsp";
            // 
            // ch_exponencial
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_exponencial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_exponencial.Legends.Add(legend1);
            this.ch_exponencial.Location = new System.Drawing.Point(19, 19);
            this.ch_exponencial.Name = "ch_exponencial";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_exponencial.Series.Add(series1);
            this.ch_exponencial.Size = new System.Drawing.Size(650, 231);
            this.ch_exponencial.TabIndex = 2;
            this.ch_exponencial.Text = "chart1";
            // 
            // btn_chi
            // 
            this.btn_chi.Location = new System.Drawing.Point(12, 490);
            this.btn_chi.Name = "btn_chi";
            this.btn_chi.Size = new System.Drawing.Size(218, 23);
            this.btn_chi.TabIndex = 4;
            this.btn_chi.Text = "Realizar prueba de Chi-Cuadrado";
            this.btn_chi.UseVisualStyleBackColor = true;
            this.btn_chi.Click += new System.EventHandler(this.btn_chi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_graficoExponencial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ch_exponencial);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_salirGrafi
            // 
            this.btn_salirGrafi.Location = new System.Drawing.Point(606, 490);
            this.btn_salirGrafi.Name = "btn_salirGrafi";
            this.btn_salirGrafi.Size = new System.Drawing.Size(75, 23);
            this.btn_salirGrafi.TabIndex = 7;
            this.btn_salirGrafi.Text = "Volver";
            this.btn_salirGrafi.UseVisualStyleBackColor = true;
            this.btn_salirGrafi.Click += new System.EventHandler(this.btn_salirGrafi_Click);
            // 
            // GraficoExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 525);
            this.Controls.Add(this.btn_salirGrafi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_chi);
            this.Name = "GraficoExponencial";
            this.Text = "GraficoExponencial";
            this.Load += new System.EventHandler(this.GraficoExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_exponencial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_graficoExponencial;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_limiteInferior;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_limiteSuperior;
        public System.Windows.Forms.DataGridViewTextBoxColumn col_frec_obs;
        public System.Windows.Forms.DataVisualization.Charting.Chart ch_exponencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_c;
        private System.Windows.Forms.Button btn_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_proEsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salirGrafi;
    }
}