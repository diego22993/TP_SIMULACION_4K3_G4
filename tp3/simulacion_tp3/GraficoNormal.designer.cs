namespace simulacion_tp1
{
    partial class GraficoNormal
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
            this.dgv_graficoNormal = new System.Windows.Forms.DataGridView();
            this.col_limiteInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_limiteSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_frec_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_normal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salirGrafNorm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_normal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_graficoNormal
            // 
            this.dgv_graficoNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_graficoNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_limiteInferior,
            this.col_limiteSuperior,
            this.col_frec_obs,
            this.col_fe,
            this.col_p,
            this.col_c});
            this.dgv_graficoNormal.Location = new System.Drawing.Point(21, 19);
            this.dgv_graficoNormal.Name = "dgv_graficoNormal";
            this.dgv_graficoNormal.Size = new System.Drawing.Size(645, 150);
            this.dgv_graficoNormal.TabIndex = 5;
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
            // col_p
            // 
            this.col_p.HeaderText = "P()";
            this.col_p.Name = "col_p";
            // 
            // col_c
            // 
            this.col_c.HeaderText = "C";
            this.col_c.Name = "col_c";
            // 
            // ch_normal
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_normal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_normal.Legends.Add(legend1);
            this.ch_normal.Location = new System.Drawing.Point(6, 19);
            this.ch_normal.Name = "ch_normal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_normal.Series.Add(series1);
            this.ch_normal.Size = new System.Drawing.Size(660, 232);
            this.ch_normal.TabIndex = 4;
            this.ch_normal.Text = "chart1";
            // 
            // btn_chi
            // 
            this.btn_chi.Location = new System.Drawing.Point(12, 467);
            this.btn_chi.Name = "btn_chi";
            this.btn_chi.Size = new System.Drawing.Size(197, 23);
            this.btn_chi.TabIndex = 6;
            this.btn_chi.Text = "Realizar prueba Chi-Cuadrado";
            this.btn_chi.UseVisualStyleBackColor = true;
            this.btn_chi.Click += new System.EventHandler(this.btn_chi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_normal);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_graficoNormal);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 178);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // btn_salirGrafNorm
            // 
            this.btn_salirGrafNorm.Location = new System.Drawing.Point(619, 467);
            this.btn_salirGrafNorm.Name = "btn_salirGrafNorm";
            this.btn_salirGrafNorm.Size = new System.Drawing.Size(75, 23);
            this.btn_salirGrafNorm.TabIndex = 9;
            this.btn_salirGrafNorm.Text = "Volver";
            this.btn_salirGrafNorm.UseVisualStyleBackColor = true;
            // 
            // GraficoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 512);
            this.Controls.Add(this.btn_salirGrafNorm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_chi);
            this.Name = "GraficoNormal";
            this.Text = "GraficoNormal";
            this.Load += new System.EventHandler(this.GraficoNormal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_graficoNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_normal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_graficoNormal;
        public System.Windows.Forms.DataVisualization.Charting.Chart ch_normal;
        private System.Windows.Forms.Button btn_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_limiteInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_limiteSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_frec_obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_c;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salirGrafNorm;
    }
}