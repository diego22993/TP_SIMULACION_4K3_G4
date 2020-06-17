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
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadIteraciones = new System.Windows.Forms.MaskedTextBox();
            this.cmbCantidadCabinas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gridTiempo = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTiempoCobro = new System.Windows.Forms.MaskedTextBox();
            this.txtIndiceLlegada = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTamaño = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntreLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PróximaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtención1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacionamiento20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtención2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACRecaudación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutosAceptados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutosRechazados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(167, 134);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(91, 22);
            this.txtHoraInicio.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Hora de Inicio";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(167, 163);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(91, 22);
            this.txtHoraFin.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hora de Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cabinas de Cobro";
            // 
            // txtCantidadIteraciones
            // 
            this.txtCantidadIteraciones.Location = new System.Drawing.Point(167, 105);
            this.txtCantidadIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadIteraciones.Name = "txtCantidadIteraciones";
            this.txtCantidadIteraciones.Size = new System.Drawing.Size(91, 22);
            this.txtCantidadIteraciones.TabIndex = 27;
            // 
            // cmbCantidadCabinas
            // 
            this.cmbCantidadCabinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadCabinas.FormattingEnabled = true;
            this.cmbCantidadCabinas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCantidadCabinas.Location = new System.Drawing.Point(167, 73);
            this.cmbCantidadCabinas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCantidadCabinas.Name = "cmbCantidadCabinas";
            this.cmbCantidadCabinas.Size = new System.Drawing.Size(91, 24);
            this.cmbCantidadCabinas.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad de Iteraciones";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(52, 244);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(173, 28);
            this.btnSimular.TabIndex = 24;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gridTiempo
            // 
            this.gridTiempo.AllowUserToAddRows = false;
            this.gridTiempo.AllowUserToDeleteRows = false;
            this.gridTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiempo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gridTiempo.Location = new System.Drawing.Point(317, 132);
            this.gridTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.gridTiempo.Name = "gridTiempo";
            this.gridTiempo.RowHeadersWidth = 51;
            this.gridTiempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTiempo.Size = new System.Drawing.Size(501, 140);
            this.gridTiempo.TabIndex = 23;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "minutos";
            this.Column6.HeaderText = "Tiempo(min)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "probabilidad";
            this.Column7.HeaderText = "P";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "acumulada";
            this.Column8.HeaderText = "PAC";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "inferior";
            this.Column9.HeaderText = "INF";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "superior";
            this.Column10.HeaderText = "SUP";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // txtTiempoCobro
            // 
            this.txtTiempoCobro.Location = new System.Drawing.Point(167, 43);
            this.txtTiempoCobro.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoCobro.Name = "txtTiempoCobro";
            this.txtTiempoCobro.Size = new System.Drawing.Size(91, 22);
            this.txtTiempoCobro.TabIndex = 22;
            // 
            // txtIndiceLlegada
            // 
            this.txtIndiceLlegada.Location = new System.Drawing.Point(167, 13);
            this.txtIndiceLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndiceLlegada.Name = "txtIndiceLlegada";
            this.txtIndiceLlegada.Size = new System.Drawing.Size(91, 22);
            this.txtIndiceLlegada.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tiempo de Cobro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Índice de LLegada";
            // 
            // gridTamaño
            // 
            this.gridTamaño.AllowUserToAddRows = false;
            this.gridTamaño.AllowUserToDeleteRows = false;
            this.gridTamaño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTamaño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridTamaño.Location = new System.Drawing.Point(317, 13);
            this.gridTamaño.Margin = new System.Windows.Forms.Padding(4);
            this.gridTamaño.Name = "gridTamaño";
            this.gridTamaño.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridTamaño.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTamaño.Size = new System.Drawing.Size(460, 111);
            this.gridTamaño.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tamanio";
            this.Column1.HeaderText = "Tamaño";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "probabilidad";
            this.Column2.HeaderText = "P";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "acumulada";
            this.Column3.HeaderText = "PAC";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "inferior";
            this.Column4.HeaderText = "INF";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "superior";
            this.Column5.HeaderText = "SUP";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj,
            this.RND1,
            this.TiempoEntreLlegadas,
            this.PróximaLlegada,
            this.RND2,
            this.TiempoAtención1,
            this.Estacionamiento1,
            this.Estacionamiento2,
            this.Estacionamiento3,
            this.Estacionamiento4,
            this.Estacionamiento5,
            this.Estacionamiento6,
            this.Estacionamiento7,
            this.Estacionamiento8,
            this.Estacionamiento9,
            this.Estacionamiento10,
            this.Estacionamiento11,
            this.Estacionamiento12,
            this.Estacionamiento13,
            this.Estacionamiento14,
            this.Estacionamiento15,
            this.Estacionamiento16,
            this.Estacionamiento17,
            this.Estacionamiento18,
            this.Estacionamiento19,
            this.Estacionamiento20,
            this.TiempoAtención2,
            this.FinCobro,
            this.Estado,
            this.Cola,
            this.Estado2,
            this.Cola2,
            this.ACRecaudación,
            this.AutosAceptados,
            this.AutosRechazados,
            this.RND3});
            this.dgvResultados.Location = new System.Drawing.Point(13, 280);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(1663, 398);
            this.dgvResultados.TabIndex = 33;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.MinimumWidth = 6;
            this.Evento.Name = "Evento";
            this.Evento.Width = 125;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.MinimumWidth = 6;
            this.Reloj.Name = "Reloj";
            this.Reloj.Width = 125;
            // 
            // RND1
            // 
            this.RND1.HeaderText = "RND";
            this.RND1.MinimumWidth = 6;
            this.RND1.Name = "RND1";
            this.RND1.Width = 125;
            // 
            // TiempoEntreLlegadas
            // 
            this.TiempoEntreLlegadas.HeaderText = "Tiempo Entre Llegadas";
            this.TiempoEntreLlegadas.MinimumWidth = 6;
            this.TiempoEntreLlegadas.Name = "TiempoEntreLlegadas";
            this.TiempoEntreLlegadas.Width = 125;
            // 
            // PróximaLlegada
            // 
            this.PróximaLlegada.HeaderText = "Próxima Llegada";
            this.PróximaLlegada.MinimumWidth = 6;
            this.PróximaLlegada.Name = "PróximaLlegada";
            this.PróximaLlegada.Width = 125;
            // 
            // RND2
            // 
            this.RND2.HeaderText = "RND";
            this.RND2.MinimumWidth = 6;
            this.RND2.Name = "RND2";
            this.RND2.Width = 125;
            // 
            // TiempoAtención1
            // 
            this.TiempoAtención1.HeaderText = "Tiempo Atención";
            this.TiempoAtención1.MinimumWidth = 6;
            this.TiempoAtención1.Name = "TiempoAtención1";
            this.TiempoAtención1.Width = 125;
            // 
            // Estacionamiento1
            // 
            this.Estacionamiento1.HeaderText = "Estacionamiento 1";
            this.Estacionamiento1.MinimumWidth = 6;
            this.Estacionamiento1.Name = "Estacionamiento1";
            this.Estacionamiento1.Width = 125;
            // 
            // Estacionamiento2
            // 
            this.Estacionamiento2.HeaderText = "Estacionamiento 2";
            this.Estacionamiento2.MinimumWidth = 6;
            this.Estacionamiento2.Name = "Estacionamiento2";
            this.Estacionamiento2.Width = 125;
            // 
            // Estacionamiento3
            // 
            this.Estacionamiento3.HeaderText = "Estacionamiento 3";
            this.Estacionamiento3.MinimumWidth = 6;
            this.Estacionamiento3.Name = "Estacionamiento3";
            this.Estacionamiento3.Width = 125;
            // 
            // Estacionamiento4
            // 
            this.Estacionamiento4.HeaderText = "Estacionamiento 4";
            this.Estacionamiento4.MinimumWidth = 6;
            this.Estacionamiento4.Name = "Estacionamiento4";
            this.Estacionamiento4.Width = 125;
            // 
            // Estacionamiento5
            // 
            this.Estacionamiento5.HeaderText = "Estacionamiento 5";
            this.Estacionamiento5.MinimumWidth = 6;
            this.Estacionamiento5.Name = "Estacionamiento5";
            this.Estacionamiento5.Width = 125;
            // 
            // Estacionamiento6
            // 
            this.Estacionamiento6.HeaderText = "Estacionamiento 6";
            this.Estacionamiento6.MinimumWidth = 6;
            this.Estacionamiento6.Name = "Estacionamiento6";
            this.Estacionamiento6.Width = 125;
            // 
            // Estacionamiento7
            // 
            this.Estacionamiento7.HeaderText = "Estacionamiento 7";
            this.Estacionamiento7.MinimumWidth = 6;
            this.Estacionamiento7.Name = "Estacionamiento7";
            this.Estacionamiento7.Width = 125;
            // 
            // Estacionamiento8
            // 
            this.Estacionamiento8.HeaderText = "Estacionamiento 8";
            this.Estacionamiento8.MinimumWidth = 6;
            this.Estacionamiento8.Name = "Estacionamiento8";
            this.Estacionamiento8.Width = 125;
            // 
            // Estacionamiento9
            // 
            this.Estacionamiento9.HeaderText = "Estacionamiento 9";
            this.Estacionamiento9.MinimumWidth = 6;
            this.Estacionamiento9.Name = "Estacionamiento9";
            this.Estacionamiento9.Width = 125;
            // 
            // Estacionamiento10
            // 
            this.Estacionamiento10.HeaderText = "Estacionamiento 10";
            this.Estacionamiento10.MinimumWidth = 6;
            this.Estacionamiento10.Name = "Estacionamiento10";
            this.Estacionamiento10.Width = 125;
            // 
            // Estacionamiento11
            // 
            this.Estacionamiento11.HeaderText = "Estacionamiento 11";
            this.Estacionamiento11.MinimumWidth = 6;
            this.Estacionamiento11.Name = "Estacionamiento11";
            this.Estacionamiento11.Width = 125;
            // 
            // Estacionamiento12
            // 
            this.Estacionamiento12.HeaderText = "Estacionamiento 12";
            this.Estacionamiento12.MinimumWidth = 6;
            this.Estacionamiento12.Name = "Estacionamiento12";
            this.Estacionamiento12.Width = 125;
            // 
            // Estacionamiento13
            // 
            this.Estacionamiento13.HeaderText = "Estacionamiento 13";
            this.Estacionamiento13.MinimumWidth = 6;
            this.Estacionamiento13.Name = "Estacionamiento13";
            this.Estacionamiento13.Width = 125;
            // 
            // Estacionamiento14
            // 
            this.Estacionamiento14.HeaderText = "Estacionamiento 14";
            this.Estacionamiento14.MinimumWidth = 6;
            this.Estacionamiento14.Name = "Estacionamiento14";
            this.Estacionamiento14.Width = 125;
            // 
            // Estacionamiento15
            // 
            this.Estacionamiento15.HeaderText = "Estacionamiento 15";
            this.Estacionamiento15.MinimumWidth = 6;
            this.Estacionamiento15.Name = "Estacionamiento15";
            this.Estacionamiento15.Width = 125;
            // 
            // Estacionamiento16
            // 
            this.Estacionamiento16.HeaderText = "Estacionamiento 16";
            this.Estacionamiento16.MinimumWidth = 6;
            this.Estacionamiento16.Name = "Estacionamiento16";
            this.Estacionamiento16.Width = 125;
            // 
            // Estacionamiento17
            // 
            this.Estacionamiento17.HeaderText = "Estacionamiento 17";
            this.Estacionamiento17.MinimumWidth = 6;
            this.Estacionamiento17.Name = "Estacionamiento17";
            this.Estacionamiento17.Width = 125;
            // 
            // Estacionamiento18
            // 
            this.Estacionamiento18.HeaderText = "Estacionamiento 18";
            this.Estacionamiento18.MinimumWidth = 6;
            this.Estacionamiento18.Name = "Estacionamiento18";
            this.Estacionamiento18.Width = 125;
            // 
            // Estacionamiento19
            // 
            this.Estacionamiento19.HeaderText = "Estacionamiento 19";
            this.Estacionamiento19.MinimumWidth = 6;
            this.Estacionamiento19.Name = "Estacionamiento19";
            this.Estacionamiento19.Width = 125;
            // 
            // Estacionamiento20
            // 
            this.Estacionamiento20.HeaderText = "Estacionamiento 20";
            this.Estacionamiento20.MinimumWidth = 6;
            this.Estacionamiento20.Name = "Estacionamiento20";
            this.Estacionamiento20.Width = 125;
            // 
            // TiempoAtención2
            // 
            this.TiempoAtención2.HeaderText = "Tiempo Atención";
            this.TiempoAtención2.MinimumWidth = 6;
            this.TiempoAtención2.Name = "TiempoAtención2";
            this.TiempoAtención2.Width = 125;
            // 
            // FinCobro
            // 
            this.FinCobro.HeaderText = "Fin Cobro";
            this.FinCobro.MinimumWidth = 6;
            this.FinCobro.Name = "FinCobro";
            this.FinCobro.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Cola
            // 
            this.Cola.HeaderText = "Cola";
            this.Cola.MinimumWidth = 6;
            this.Cola.Name = "Cola";
            this.Cola.Width = 125;
            // 
            // Estado2
            // 
            this.Estado2.HeaderText = "Estado 2";
            this.Estado2.MinimumWidth = 6;
            this.Estado2.Name = "Estado2";
            this.Estado2.Width = 125;
            // 
            // Cola2
            // 
            this.Cola2.HeaderText = "Cola 2";
            this.Cola2.MinimumWidth = 6;
            this.Cola2.Name = "Cola2";
            this.Cola2.Width = 125;
            // 
            // ACRecaudación
            // 
            this.ACRecaudación.HeaderText = "AC Recaudación";
            this.ACRecaudación.MinimumWidth = 6;
            this.ACRecaudación.Name = "ACRecaudación";
            this.ACRecaudación.Width = 125;
            // 
            // AutosAceptados
            // 
            this.AutosAceptados.HeaderText = "Autos Aceptados";
            this.AutosAceptados.MinimumWidth = 6;
            this.AutosAceptados.Name = "AutosAceptados";
            this.AutosAceptados.Width = 125;
            // 
            // AutosRechazados
            // 
            this.AutosRechazados.HeaderText = "Autos Rechazados";
            this.AutosRechazados.MinimumWidth = 6;
            this.AutosRechazados.Name = "AutosRechazados";
            this.AutosRechazados.Width = 125;
            // 
            // RND3
            // 
            this.RND3.HeaderText = "RND";
            this.RND3.MinimumWidth = 6;
            this.RND3.Name = "RND3";
            this.RND3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 691);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadIteraciones);
            this.Controls.Add(this.cmbCantidadCabinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.gridTiempo);
            this.Controls.Add(this.txtTiempoCobro);
            this.Controls.Add(this.txtIndiceLlegada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTamaño);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtHoraFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCantidadIteraciones;
        private System.Windows.Forms.ComboBox cmbCantidadCabinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView gridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.MaskedTextBox txtTiempoCobro;
        private System.Windows.Forms.MaskedTextBox txtIndiceLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridView dgvResultados;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RND1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntreLlegadas;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PróximaLlegada;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RND2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtención1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento9;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento10;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento11;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento12;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento13;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento14;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento15;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento16;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento17;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento18;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento19;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estacionamiento20;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtención2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FinCobro;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cola;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cola2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ACRecaudación;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AutosAceptados;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AutosRechazados;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RND3;
    }
}

