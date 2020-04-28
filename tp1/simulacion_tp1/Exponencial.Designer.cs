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
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTamaño = new System.Windows.Forms.MaskedTextBox();
            this.mtbLambda = new System.Windows.Forms.MaskedTextBox();
            this.cboIntervalos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListadoExp = new System.Windows.Forms.DataGridView();
            this.dgvExponencial = new System.Windows.Forms.DataGridView();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "lambda";
            // 
            // mtbTamaño
            // 
            this.mtbTamaño.Location = new System.Drawing.Point(66, 12);
            this.mtbTamaño.Name = "mtbTamaño";
            this.mtbTamaño.Size = new System.Drawing.Size(119, 20);
            this.mtbTamaño.TabIndex = 2;
            // 
            // mtbLambda
            // 
            this.mtbLambda.Location = new System.Drawing.Point(66, 43);
            this.mtbLambda.Name = "mtbLambda";
            this.mtbLambda.Size = new System.Drawing.Size(119, 20);
            this.mtbLambda.TabIndex = 3;
            // 
            // cboIntervalos
            // 
            this.cboIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntervalos.FormattingEnabled = true;
            this.cboIntervalos.Location = new System.Drawing.Point(66, 73);
            this.cboIntervalos.Name = "cboIntervalos";
            this.cboIntervalos.Size = new System.Drawing.Size(119, 21);
            this.cboIntervalos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intervalos";
            // 
            // dgvListadoExp
            // 
            this.dgvListadoExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListadoExp.Location = new System.Drawing.Point(226, 12);
            this.dgvListadoExp.Name = "dgvListadoExp";
            this.dgvListadoExp.Size = new System.Drawing.Size(444, 141);
            this.dgvListadoExp.TabIndex = 6;
            // 
            // dgvExponencial
            // 
            this.dgvExponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvExponencial.Location = new System.Drawing.Point(10, 186);
            this.dgvExponencial.Name = "dgvExponencial";
            this.dgvExponencial.Size = new System.Drawing.Size(660, 153);
            this.dgvExponencial.TabIndex = 7;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(10, 157);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(175, 23);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RND";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Posiocion";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Inf";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sup";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fe";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "C";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CAC";
            this.Column9.Name = "Column9";
            // 
            // Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 749);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.dgvExponencial);
            this.Controls.Add(this.dgvListadoExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboIntervalos);
            this.Controls.Add(this.mtbLambda);
            this.Controls.Add(this.mtbTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exponencial";
            this.Text = "Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTamaño;
        private System.Windows.Forms.MaskedTextBox mtbLambda;
        private System.Windows.Forms.ComboBox cboIntervalos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListadoExp;
        private System.Windows.Forms.DataGridView dgvExponencial;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}