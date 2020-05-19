namespace simulacion_tp5
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
            this.gridTipo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndiceLlegada = new System.Windows.Forms.MaskedTextBox();
            this.txtTiempoDeCobro = new System.Windows.Forms.MaskedTextBox();
            this.gridTiempo = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gridSimulacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTipo
            // 
            this.gridTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipo.Location = new System.Drawing.Point(265, 29);
            this.gridTipo.Name = "gridTipo";
            this.gridTipo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTipo.Size = new System.Drawing.Size(412, 150);
            this.gridTipo.TabIndex = 0;
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
            this.txtIndiceLlegada.Size = new System.Drawing.Size(71, 20);
            this.txtIndiceLlegada.TabIndex = 3;
            // 
            // txtTiempoDeCobro
            // 
            this.txtTiempoDeCobro.Location = new System.Drawing.Point(108, 56);
            this.txtTiempoDeCobro.Name = "txtTiempoDeCobro";
            this.txtTiempoDeCobro.Size = new System.Drawing.Size(71, 20);
            this.txtTiempoDeCobro.TabIndex = 4;
            // 
            // gridTiempo
            // 
            this.gridTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiempo.Location = new System.Drawing.Point(683, 29);
            this.gridTiempo.Name = "gridTiempo";
            this.gridTiempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTiempo.Size = new System.Drawing.Size(412, 150);
            this.gridTiempo.TabIndex = 5;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(17, 156);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.gridSimulacion);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.gridTiempo);
            this.Controls.Add(this.txtTiempoDeCobro);
            this.Controls.Add(this.txtIndiceLlegada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTipo);
            this.Name = "Form1";
            this.Text = "Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIndiceLlegada;
        private System.Windows.Forms.MaskedTextBox txtTiempoDeCobro;
        private System.Windows.Forms.DataGridView gridTiempo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView gridSimulacion;
    }
}

