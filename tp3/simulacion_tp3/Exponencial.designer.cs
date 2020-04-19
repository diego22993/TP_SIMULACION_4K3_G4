namespace simulacion_tp1
{
    partial class Exponencial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tamañoE = new System.Windows.Forms.TextBox();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generarE = new System.Windows.Forms.Button();
            this.dgv_exponencial = new System.Windows.Forms.DataGridView();
            this.txt_cantidadExp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_graficarExp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.col_numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aleatorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exponencial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la muestra:";
            // 
            // txt_tamañoE
            // 
            this.txt_tamañoE.Location = new System.Drawing.Point(142, 51);
            this.txt_tamañoE.Name = "txt_tamañoE";
            this.txt_tamañoE.Size = new System.Drawing.Size(100, 20);
            this.txt_tamañoE.TabIndex = 1;
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(142, 98);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(100, 20);
            this.txt_lambda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lambda:";
            // 
            // btn_generarE
            // 
            this.btn_generarE.Location = new System.Drawing.Point(11, 260);
            this.btn_generarE.Name = "btn_generarE";
            this.btn_generarE.Size = new System.Drawing.Size(75, 23);
            this.btn_generarE.TabIndex = 4;
            this.btn_generarE.Text = "Generar";
            this.btn_generarE.UseVisualStyleBackColor = true;
            this.btn_generarE.Click += new System.EventHandler(this.btn_generarE_Click);
            // 
            // dgv_exponencial
            // 
            this.dgv_exponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_numeros,
            this.col_aleatorios,
            this.ColumnX});
            this.dgv_exponencial.Location = new System.Drawing.Point(295, 19);
            this.dgv_exponencial.Name = "dgv_exponencial";
            this.dgv_exponencial.Size = new System.Drawing.Size(360, 264);
            this.dgv_exponencial.TabIndex = 5;
            // 
            // txt_cantidadExp
            // 
            this.txt_cantidadExp.Location = new System.Drawing.Point(142, 144);
            this.txt_cantidadExp.Name = "txt_cantidadExp";
            this.txt_cantidadExp.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidadExp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de intervalos:";
            // 
            // btn_graficarExp
            // 
            this.btn_graficarExp.Location = new System.Drawing.Point(105, 260);
            this.btn_graficarExp.Name = "btn_graficarExp";
            this.btn_graficarExp.Size = new System.Drawing.Size(75, 23);
            this.btn_graficarExp.TabIndex = 8;
            this.btn_graficarExp.Text = "Graficar";
            this.btn_graficarExp.UseVisualStyleBackColor = true;
            this.btn_graficarExp.Click += new System.EventHandler(this.btn_graficarExp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.dgv_exponencial);
            this.groupBox1.Controls.Add(this.btn_graficarExp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tamañoE);
            this.groupBox1.Controls.Add(this.txt_cantidadExp);
            this.groupBox1.Controls.Add(this.txt_lambda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_generarE);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 289);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prueba Exponencial";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(200, 260);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(603, 307);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // col_numeros
            // 
            this.col_numeros.HeaderText = "n";
            this.col_numeros.Name = "col_numeros";
            // 
            // col_aleatorios
            // 
            this.col_aleatorios.HeaderText = "RND";
            this.col_aleatorios.Name = "col_aleatorios";
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "x";
            this.ColumnX.Name = "ColumnX";
            // 
            // Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 342);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Exponencial";
            this.Text = "Exponencial";
            this.Load += new System.EventHandler(this.Exponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exponencial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tamañoE;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generarE;
        private System.Windows.Forms.DataGridView dgv_exponencial;
        private System.Windows.Forms.TextBox txt_cantidadExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_graficarExp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aleatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
    }
}