namespace simulacion_tp4
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
            this.gridDemanda = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEntrega = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDaniada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtKo = new System.Windows.Forms.TextBox();
            this.txtKs = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSemanas = new System.Windows.Forms.TextBox();
            this.txtSemanaDesde = new System.Windows.Forms.TextBox();
            this.txtSemanaHasta = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gridSimulacion = new System.Windows.Forms.DataGridView();
            this.semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDaniada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daniada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daniadaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDaniada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDemanda
            // 
            this.gridDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.probabilidad,
            this.acumulada,
            this.inferior,
            this.superior});
            this.gridDemanda.Location = new System.Drawing.Point(406, 12);
            this.gridDemanda.Margin = new System.Windows.Forms.Padding(2);
            this.gridDemanda.Name = "gridDemanda";
            this.gridDemanda.RowHeadersWidth = 51;
            this.gridDemanda.RowTemplate.Height = 24;
            this.gridDemanda.Size = new System.Drawing.Size(404, 121);
            this.gridDemanda.TabIndex = 1;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Demanda";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 70;
            // 
            // probabilidad
            // 
            this.probabilidad.DataPropertyName = "probabilidad";
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.MinimumWidth = 6;
            this.probabilidad.Name = "probabilidad";
            this.probabilidad.Width = 70;
            // 
            // acumulada
            // 
            this.acumulada.DataPropertyName = "acumulada";
            this.acumulada.HeaderText = "Acumulada";
            this.acumulada.MinimumWidth = 6;
            this.acumulada.Name = "acumulada";
            this.acumulada.ReadOnly = true;
            this.acumulada.Width = 70;
            // 
            // inferior
            // 
            this.inferior.DataPropertyName = "inferior";
            this.inferior.HeaderText = "Inferior";
            this.inferior.MinimumWidth = 6;
            this.inferior.Name = "inferior";
            this.inferior.ReadOnly = true;
            this.inferior.Width = 70;
            // 
            // superior
            // 
            this.superior.DataPropertyName = "superior";
            this.superior.HeaderText = "Superior";
            this.superior.MinimumWidth = 6;
            this.superior.Name = "superior";
            this.superior.ReadOnly = true;
            this.superior.Width = 70;
            // 
            // gridEntrega
            // 
            this.gridEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridEntrega.Location = new System.Drawing.Point(830, 12);
            this.gridEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.gridEntrega.Name = "gridEntrega";
            this.gridEntrega.RowHeadersWidth = 51;
            this.gridEntrega.RowTemplate.Height = 24;
            this.gridEntrega.Size = new System.Drawing.Size(404, 95);
            this.gridEntrega.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entrega";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "probabilidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "acumulada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Acumulada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "inferior";
            this.dataGridViewTextBoxColumn4.HeaderText = "Inferior";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "superior";
            this.dataGridViewTextBoxColumn5.HeaderText = "Superior";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // gridDaniada
            // 
            this.gridDaniada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDaniada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.gridDaniada.Location = new System.Drawing.Point(830, 110);
            this.gridDaniada.Margin = new System.Windows.Forms.Padding(2);
            this.gridDaniada.Name = "gridDaniada";
            this.gridDaniada.RowHeadersWidth = 51;
            this.gridDaniada.RowTemplate.Height = 24;
            this.gridDaniada.Size = new System.Drawing.Size(404, 72);
            this.gridDaniada.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dañada";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "probabilidad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "acumulada";
            this.dataGridViewTextBoxColumn8.HeaderText = "Acumulada";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "inferior";
            this.dataGridViewTextBoxColumn9.HeaderText = "Inferior";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "superior";
            this.dataGridViewTextBoxColumn10.HeaderText = "Superior";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ks";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(124, 10);
            this.txtKm.Margin = new System.Windows.Forms.Padding(2);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(76, 20);
            this.txtKm.TabIndex = 8;
            this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
            // 
            // txtKo
            // 
            this.txtKo.Location = new System.Drawing.Point(124, 32);
            this.txtKo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKo.Name = "txtKo";
            this.txtKo.Size = new System.Drawing.Size(76, 20);
            this.txtKo.TabIndex = 9;
            this.txtKo.TextChanged += new System.EventHandler(this.txtKo_TextChanged);
            // 
            // txtKs
            // 
            this.txtKs.Location = new System.Drawing.Point(124, 55);
            this.txtKs.Margin = new System.Windows.Forms.Padding(2);
            this.txtKs.Name = "txtKs";
            this.txtKs.Size = new System.Drawing.Size(76, 20);
            this.txtKs.TabIndex = 10;
            this.txtKs.TextChanged += new System.EventHandler(this.txtKs_TextChanged);
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(124, 78);
            this.txtStockInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(76, 20);
            this.txtStockInicial.TabIndex = 11;
            this.txtStockInicial.TextChanged += new System.EventHandler(this.txtStockInicial_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad de semanas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Semana desde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Semana hasta";
            // 
            // txtSemanas
            // 
            this.txtSemanas.Location = new System.Drawing.Point(124, 101);
            this.txtSemanas.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemanas.Name = "txtSemanas";
            this.txtSemanas.Size = new System.Drawing.Size(76, 20);
            this.txtSemanas.TabIndex = 16;
            this.txtSemanas.TextChanged += new System.EventHandler(this.txtSemanas_TextChanged);
            // 
            // txtSemanaDesde
            // 
            this.txtSemanaDesde.Location = new System.Drawing.Point(124, 124);
            this.txtSemanaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemanaDesde.Name = "txtSemanaDesde";
            this.txtSemanaDesde.Size = new System.Drawing.Size(76, 20);
            this.txtSemanaDesde.TabIndex = 17;
            this.txtSemanaDesde.TextChanged += new System.EventHandler(this.txtSemanaDesde_TextChanged);
            // 
            // txtSemanaHasta
            // 
            this.txtSemanaHasta.Location = new System.Drawing.Point(124, 146);
            this.txtSemanaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemanaHasta.Name = "txtSemanaHasta";
            this.txtSemanaHasta.Size = new System.Drawing.Size(76, 20);
            this.txtSemanaHasta.TabIndex = 18;
            this.txtSemanaHasta.TextChanged += new System.EventHandler(this.txtSemanaHasta_TextChanged);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(242, 149);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(56, 19);
            this.btnSimular.TabIndex = 19;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gridSimulacion
            // 
            this.gridSimulacion.AllowUserToAddRows = false;
            this.gridSimulacion.AllowUserToDeleteRows = false;
            this.gridSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semana,
            this.rndDaniada,
            this.daniada2,
            this.daniadaTotal,
            this.disponible,
            this.stockInicio,
            this.rndDemanda,
            this.demanda2,
            this.venta,
            this.stockFin,
            this.faltante,
            this.km,
            this.ks,
            this.ko,
            this.total,
            this.totalAcumulado,
            this.rndPedido,
            this.semanas,
            this.llega});
            this.gridSimulacion.Location = new System.Drawing.Point(9, 187);
            this.gridSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.gridSimulacion.Name = "gridSimulacion";
            this.gridSimulacion.ReadOnly = true;
            this.gridSimulacion.RowHeadersWidth = 51;
            this.gridSimulacion.RowTemplate.Height = 24;
            this.gridSimulacion.Size = new System.Drawing.Size(1226, 476);
            this.gridSimulacion.TabIndex = 20;
            // 
            // semana
            // 
            this.semana.DataPropertyName = "semana";
            this.semana.HeaderText = "Semana";
            this.semana.MinimumWidth = 6;
            this.semana.Name = "semana";
            this.semana.ReadOnly = true;
            this.semana.Width = 60;
            // 
            // rndDaniada
            // 
            this.rndDaniada.DataPropertyName = "rndDaniada";
            this.rndDaniada.HeaderText = "Rnd";
            this.rndDaniada.MinimumWidth = 6;
            this.rndDaniada.Name = "rndDaniada";
            this.rndDaniada.ReadOnly = true;
            this.rndDaniada.Width = 60;
            // 
            // daniada2
            // 
            this.daniada2.DataPropertyName = "daniada";
            this.daniada2.HeaderText = "Dañadas";
            this.daniada2.MinimumWidth = 6;
            this.daniada2.Name = "daniada2";
            this.daniada2.ReadOnly = true;
            this.daniada2.Width = 60;
            // 
            // daniadaTotal
            // 
            this.daniadaTotal.DataPropertyName = "daniadaTotal";
            this.daniadaTotal.HeaderText = "Total";
            this.daniadaTotal.MinimumWidth = 6;
            this.daniadaTotal.Name = "daniadaTotal";
            this.daniadaTotal.ReadOnly = true;
            this.daniadaTotal.Width = 60;
            // 
            // disponible
            // 
            this.disponible.DataPropertyName = "disponible";
            this.disponible.HeaderText = "Disponibles";
            this.disponible.MinimumWidth = 6;
            this.disponible.Name = "disponible";
            this.disponible.ReadOnly = true;
            this.disponible.Width = 70;
            // 
            // stockInicio
            // 
            this.stockInicio.DataPropertyName = "stockInicio";
            this.stockInicio.HeaderText = "Stock";
            this.stockInicio.MinimumWidth = 6;
            this.stockInicio.Name = "stockInicio";
            this.stockInicio.ReadOnly = true;
            this.stockInicio.Width = 60;
            // 
            // rndDemanda
            // 
            this.rndDemanda.DataPropertyName = "rndDemanda";
            this.rndDemanda.HeaderText = "Rnd.";
            this.rndDemanda.MinimumWidth = 6;
            this.rndDemanda.Name = "rndDemanda";
            this.rndDemanda.ReadOnly = true;
            this.rndDemanda.Width = 60;
            // 
            // demanda2
            // 
            this.demanda2.DataPropertyName = "demanda";
            this.demanda2.HeaderText = "Demanda";
            this.demanda2.MinimumWidth = 6;
            this.demanda2.Name = "demanda2";
            this.demanda2.ReadOnly = true;
            this.demanda2.Width = 60;
            // 
            // venta
            // 
            this.venta.DataPropertyName = "venta";
            this.venta.HeaderText = "Venta";
            this.venta.MinimumWidth = 6;
            this.venta.Name = "venta";
            this.venta.ReadOnly = true;
            this.venta.Width = 60;
            // 
            // stockFin
            // 
            this.stockFin.DataPropertyName = "stockFin";
            this.stockFin.HeaderText = "Stock";
            this.stockFin.MinimumWidth = 6;
            this.stockFin.Name = "stockFin";
            this.stockFin.ReadOnly = true;
            this.stockFin.Width = 60;
            // 
            // faltante
            // 
            this.faltante.DataPropertyName = "faltante";
            this.faltante.HeaderText = "Faltante";
            this.faltante.MinimumWidth = 6;
            this.faltante.Name = "faltante";
            this.faltante.ReadOnly = true;
            this.faltante.Width = 60;
            // 
            // km
            // 
            this.km.DataPropertyName = "km";
            this.km.HeaderText = "Km";
            this.km.MinimumWidth = 6;
            this.km.Name = "km";
            this.km.ReadOnly = true;
            this.km.Width = 60;
            // 
            // ks
            // 
            this.ks.DataPropertyName = "ks";
            this.ks.HeaderText = "Ks";
            this.ks.MinimumWidth = 6;
            this.ks.Name = "ks";
            this.ks.ReadOnly = true;
            this.ks.Width = 60;
            // 
            // ko
            // 
            this.ko.DataPropertyName = "ko";
            this.ko.HeaderText = "Ko";
            this.ko.MinimumWidth = 6;
            this.ko.Name = "ko";
            this.ko.ReadOnly = true;
            this.ko.Width = 60;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 60;
            // 
            // totalAcumulado
            // 
            this.totalAcumulado.DataPropertyName = "totalAcumulado";
            this.totalAcumulado.HeaderText = "Total Ac.";
            this.totalAcumulado.MinimumWidth = 6;
            this.totalAcumulado.Name = "totalAcumulado";
            this.totalAcumulado.ReadOnly = true;
            this.totalAcumulado.Width = 60;
            // 
            // rndPedido
            // 
            this.rndPedido.DataPropertyName = "rndPedido";
            this.rndPedido.HeaderText = "Rnd.";
            this.rndPedido.MinimumWidth = 6;
            this.rndPedido.Name = "rndPedido";
            this.rndPedido.ReadOnly = true;
            this.rndPedido.Width = 60;
            // 
            // semanas
            // 
            this.semanas.DataPropertyName = "semanas";
            this.semanas.HeaderText = "Semanas";
            this.semanas.MinimumWidth = 6;
            this.semanas.Name = "semanas";
            this.semanas.ReadOnly = true;
            this.semanas.Width = 60;
            // 
            // llega
            // 
            this.llega.DataPropertyName = "llega";
            this.llega.HeaderText = "Llega";
            this.llega.MinimumWidth = 6;
            this.llega.Name = "llega";
            this.llega.ReadOnly = true;
            this.llega.Width = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "R";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(242, 10);
            this.txtQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(76, 20);
            this.txtQ.TabIndex = 23;
            this.txtQ.TextChanged += new System.EventHandler(this.txtQ_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(242, 32);
            this.txtR.Margin = new System.Windows.Forms.Padding(2);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(76, 20);
            this.txtR.TabIndex = 24;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 674);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridSimulacion);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtSemanaHasta);
            this.Controls.Add(this.txtSemanaDesde);
            this.Controls.Add(this.txtSemanas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockInicial);
            this.Controls.Add(this.txtKs);
            this.Controls.Add(this.txtKo);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDaniada);
            this.Controls.Add(this.gridEntrega);
            this.Controls.Add(this.gridDemanda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridDemanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDaniada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDemanda;
        private System.Windows.Forms.DataGridView gridEntrega;
        private System.Windows.Forms.DataGridView gridDaniada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn inferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn superior;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtKo;
        private System.Windows.Forms.TextBox txtKs;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemanas;
        private System.Windows.Forms.TextBox txtSemanaDesde;
        private System.Windows.Forms.TextBox txtSemanaHasta;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView gridSimulacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.DataGridViewTextBoxColumn semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDaniada;
        private System.Windows.Forms.DataGridViewTextBoxColumn daniada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn daniadaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda2;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn ks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ko;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanas;
        private System.Windows.Forms.DataGridViewTextBoxColumn llega;
    }
}

