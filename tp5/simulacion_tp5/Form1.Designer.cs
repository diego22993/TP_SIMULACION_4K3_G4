﻿namespace simulacion_tp5
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
            this.gridTamaño = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndiceLlegada = new System.Windows.Forms.MaskedTextBox();
            this.txtTiempoDeCobro = new System.Windows.Forms.MaskedTextBox();
            this.gridTiempo = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gridSimulacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCantCajas = new System.Windows.Forms.ComboBox();
            this.txtCantidadIteraciones = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinutosInicio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutosFin = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTamaño
            // 
            this.gridTamaño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTamaño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridTamaño.Location = new System.Drawing.Point(183, 29);
            this.gridTamaño.Name = "gridTamaño";
            this.gridTamaño.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridTamaño.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTamaño.Size = new System.Drawing.Size(348, 104);
            this.gridTamaño.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indice de LLegada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo de Cobro";
            // 
            // txtIndiceLlegada
            // 
            this.txtIndiceLlegada.Location = new System.Drawing.Point(108, 29);
            this.txtIndiceLlegada.Name = "txtIndiceLlegada";
            this.txtIndiceLlegada.Size = new System.Drawing.Size(69, 20);
            this.txtIndiceLlegada.TabIndex = 3;
            // 
            // txtTiempoDeCobro
            // 
            this.txtTiempoDeCobro.Location = new System.Drawing.Point(108, 56);
            this.txtTiempoDeCobro.Name = "txtTiempoDeCobro";
            this.txtTiempoDeCobro.Size = new System.Drawing.Size(69, 20);
            this.txtTiempoDeCobro.TabIndex = 4;
            // 
            // gridTiempo
            // 
            this.gridTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiempo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gridTiempo.Location = new System.Drawing.Point(549, 29);
            this.gridTiempo.Name = "gridTiempo";
            this.gridTiempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTiempo.Size = new System.Drawing.Size(370, 128);
            this.gridTiempo.TabIndex = 5;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 203);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(130, 23);
            this.btnSimular.TabIndex = 6;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gridSimulacion
            // 
            this.gridSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSimulacion.Location = new System.Drawing.Point(12, 232);
            this.gridSimulacion.Name = "gridSimulacion";
            this.gridSimulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSimulacion.Size = new System.Drawing.Size(990, 150);
            this.gridSimulacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cant Iteraciones";
            // 
            // cboCantCajas
            // 
            this.cboCantCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCantCajas.FormattingEnabled = true;
            this.cboCantCajas.Location = new System.Drawing.Point(108, 84);
            this.cboCantCajas.Name = "cboCantCajas";
            this.cboCantCajas.Size = new System.Drawing.Size(69, 21);
            this.cboCantCajas.TabIndex = 9;
            // 
            // txtCantidadIteraciones
            // 
            this.txtCantidadIteraciones.Location = new System.Drawing.Point(108, 113);
            this.txtCantidadIteraciones.Name = "txtCantidadIteraciones";
            this.txtCantidadIteraciones.Size = new System.Drawing.Size(69, 20);
            this.txtCantidadIteraciones.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cant Cabinas Cobro";
            // 
            // txtMinutosInicio
            // 
            this.txtMinutosInicio.Location = new System.Drawing.Point(108, 141);
            this.txtMinutosInicio.Name = "txtMinutosInicio";
            this.txtMinutosInicio.Size = new System.Drawing.Size(69, 20);
            this.txtMinutosInicio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minutos de Inicio";
            // 
            // txtMinutosFin
            // 
            this.txtMinutosFin.Location = new System.Drawing.Point(108, 168);
            this.txtMinutosFin.Name = "txtMinutosFin";
            this.txtMinutosFin.Size = new System.Drawing.Size(69, 20);
            this.txtMinutosFin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minutos de Fin";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tamaño";
            this.Column1.HeaderText = "Tamaño";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "probabilidad";
            this.Column2.HeaderText = "P";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "acumulada";
            this.Column3.HeaderText = "PAC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "inferior";
            this.Column4.HeaderText = "INF";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "superior";
            this.Column5.HeaderText = "SUP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tiempo";
            this.Column6.HeaderText = "TIEMPO (min)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "probabilidad";
            this.Column7.HeaderText = "P";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "acumulada";
            this.Column8.HeaderText = "PAC";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "inferior";
            this.Column9.HeaderText = "INF";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "superior";
            this.Column10.HeaderText = "SUP";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.txtMinutosFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMinutosInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadIteraciones);
            this.Controls.Add(this.cboCantCajas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridSimulacion);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.gridTiempo);
            this.Controls.Add(this.txtTiempoDeCobro);
            this.Controls.Add(this.txtIndiceLlegada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTamaño);
            this.Name = "Form1";
            this.Text = "Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIndiceLlegada;
        private System.Windows.Forms.MaskedTextBox txtTiempoDeCobro;
        private System.Windows.Forms.DataGridView gridTiempo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView gridSimulacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCantCajas;
        private System.Windows.Forms.MaskedTextBox txtCantidadIteraciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtMinutosInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMinutosFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

