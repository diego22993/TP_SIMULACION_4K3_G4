namespace simulacion_tp1
{
    partial class Normal
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
            this.txt_media = new System.Windows.Forms.TextBox();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_normal = new System.Windows.Forms.DataGridView();
            this.btn_generarNormal = new System.Windows.Forms.Button();
            this.txt_cantAGenerar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.txt_cantIntervalos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.col_normales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aleatoriosNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnrnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_normal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(122, 72);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 20);
            this.txt_media.TabIndex = 1;
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Location = new System.Drawing.Point(122, 108);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(100, 20);
            this.txt_desviacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desviacion:";
            // 
            // dgv_normal
            // 
            this.dgv_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_normal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_normales,
            this.col_aleatoriosNormal,
            this.Columnrnd2,
            this.Columnx});
            this.dgv_normal.Location = new System.Drawing.Point(249, 17);
            this.dgv_normal.Name = "dgv_normal";
            this.dgv_normal.Size = new System.Drawing.Size(437, 281);
            this.dgv_normal.TabIndex = 6;
            // 
            // btn_generarNormal
            // 
            this.btn_generarNormal.Location = new System.Drawing.Point(6, 275);
            this.btn_generarNormal.Name = "btn_generarNormal";
            this.btn_generarNormal.Size = new System.Drawing.Size(75, 23);
            this.btn_generarNormal.TabIndex = 7;
            this.btn_generarNormal.Text = "Generar";
            this.btn_generarNormal.UseVisualStyleBackColor = true;
            this.btn_generarNormal.Click += new System.EventHandler(this.btn_generarNormal_Click);
            // 
            // txt_cantAGenerar
            // 
            this.txt_cantAGenerar.Location = new System.Drawing.Point(122, 37);
            this.txt_cantAGenerar.Name = "txt_cantAGenerar";
            this.txt_cantAGenerar.Size = new System.Drawing.Size(100, 20);
            this.txt_cantAGenerar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad a generar";
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(87, 275);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(75, 23);
            this.btn_graficar.TabIndex = 10;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = true;
            this.btn_graficar.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // txt_cantIntervalos
            // 
            this.txt_cantIntervalos.Location = new System.Drawing.Point(122, 149);
            this.txt_cantIntervalos.Name = "txt_cantIntervalos";
            this.txt_cantIntervalos.Size = new System.Drawing.Size(100, 20);
            this.txt_cantIntervalos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Intervalos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.dgv_normal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_media);
            this.groupBox1.Controls.Add(this.txt_cantIntervalos);
            this.groupBox1.Controls.Add(this.txt_desviacion);
            this.groupBox1.Controls.Add(this.btn_graficar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cantAGenerar);
            this.groupBox1.Controls.Add(this.btn_generarNormal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 304);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(168, 275);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(629, 324);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // col_normales
            // 
            this.col_normales.HeaderText = "n";
            this.col_normales.Name = "col_normales";
            // 
            // col_aleatoriosNormal
            // 
            this.col_aleatoriosNormal.HeaderText = "RND1";
            this.col_aleatoriosNormal.Name = "col_aleatoriosNormal";
            // 
            // Columnrnd2
            // 
            this.Columnrnd2.HeaderText = "RND2";
            this.Columnrnd2.Name = "Columnrnd2";
            // 
            // Columnx
            // 
            this.Columnx.HeaderText = "x";
            this.Columnx.Name = "Columnx";
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 359);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Normal";
            this.Text = "Normal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_normal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_normal;
        private System.Windows.Forms.Button btn_generarNormal;
       public System.Windows.Forms.TextBox txt_cantAGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.TextBox txt_cantIntervalos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_normales;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aleatoriosNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnrnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnx;
    }
}