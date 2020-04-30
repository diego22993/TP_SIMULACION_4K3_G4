namespace simulacion_tp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_uniforme = new System.Windows.Forms.Button();
            this.btn_exponencial = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_uniforme
            // 
            this.btn_uniforme.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_uniforme.Location = new System.Drawing.Point(12, 50);
            this.btn_uniforme.Name = "btn_uniforme";
            this.btn_uniforme.Size = new System.Drawing.Size(217, 66);
            this.btn_uniforme.TabIndex = 0;
            this.btn_uniforme.Text = "Uniforme";
            this.btn_uniforme.UseVisualStyleBackColor = false;
            this.btn_uniforme.Click += new System.EventHandler(this.btn_uniforme_Click_1);
            // 
            // btn_exponencial
            // 
            this.btn_exponencial.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exponencial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exponencial.Location = new System.Drawing.Point(235, 50);
            this.btn_exponencial.Name = "btn_exponencial";
            this.btn_exponencial.Size = new System.Drawing.Size(217, 66);
            this.btn_exponencial.TabIndex = 1;
            this.btn_exponencial.Text = "Exponencial";
            this.btn_exponencial.UseVisualStyleBackColor = false;
            this.btn_exponencial.Click += new System.EventHandler(this.btn_exponencial_Click_1);
            // 
            // btn_normal
            // 
            this.btn_normal.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_normal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_normal.Location = new System.Drawing.Point(458, 50);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(217, 66);
            this.btn_normal.TabIndex = 2;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = false;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(692, 166);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_exponencial);
            this.Controls.Add(this.btn_uniforme);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btn_uniforme;
        private System.Windows.Forms.Button btn_exponencial;
        private System.Windows.Forms.Button btn_normal;
    }
}

