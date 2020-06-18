using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_tp5
{
    public partial class Form1 : Form
    {
        List<FilaTamanio> tamanio = new List<FilaTamanio>();
        List<FilaTiempo> tiempo = new List<FilaTiempo>();

        public Form1()
        {
            InitializeComponent();
            inicializarGrid();
        }

        public void inicializarGrid()
        {
            txtIndiceLlegada.Text = "13";
            txtTiempoCobro.Text = "2";
            cmbColas.SelectedIndex = 0;
            txtHoraInicio.Text = "0";
            txtHoraFin.Text = "25";
            txtCantidadIteraciones.Text = "5";
            tamanio.Add(new FilaTamanio("Pequeño", .45, .45, 000, .50));
            tamanio.Add(new FilaTamanio("Grande", .25, .70, .45, .70));
            tamanio.Add(new FilaTamanio("Utilitario", .30, .45, .70, 001));
            dgvTipos.DataSource = tamanio;
            tiempo.Add(new FilaTiempo(60, .50, .50, 000, .50));
            tiempo.Add(new FilaTiempo(120, .30, .80, .50, .80));
            tiempo.Add(new FilaTiempo(180, .15, .95, .80, .95));
            tiempo.Add(new FilaTiempo(240, .05, 001, .95, 001));
            dgvTiempos.DataSource = tiempo;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (valido())
            {
                actualizarTipo();
                actualizarTiempo();
                simular();
            }
            else
            {
                MessageBox.Show("Debe Ingresar todos los datos", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private bool valido()
        {
            return txtIndiceLlegada.Text != "" && txtTiempoCobro.Text != "" && txtCantidadIteraciones.Text != "" && txtHoraInicio.Text != "" && txtHoraFin.Text != "";
        }

        private void actualizarTipo()
        {
            double probabilidadTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < tamanio.Count; i++)
            {
                probabilidadTotal += tamanio[i].Probabilidad;
            }
            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La Probabilidad total debe dar 1", "Probabilidad del Tipo Automovil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                probabilidadAcumulada = 0;
                for (int i = 0; i < tamanio.Count; i++)
                {
                    probabilidadAcumulada += tamanio[i].Probabilidad;
                    tamanio[i].Acumulada = probabilidadAcumulada;
                    tamanio[i].Inferior = probabilidadInferior;
                    tamanio[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                dgvTipos.DataSource = tamanio;
                dgvTipos.Refresh();
            }
        }

        private void actualizarTiempo()
        {
            double probabilidadAcumuladaTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < tiempo.Count; i++)
            {
                probabilidadAcumuladaTotal += tiempo[i].Probabilidad;
            }
            if (probabilidadAcumuladaTotal != 1)
            {
                MessageBox.Show("La Probabilidad Total debe ser igual a 1", "Probabilidad del Tiempo de Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                probabilidadAcumulada = 0;
                for (int i = 0; i < tiempo.Count; i++)
                {
                    probabilidadAcumulada += Math.Round(tiempo[i].Probabilidad, 2);
                    tiempo[i].Acumulada = Math.Round(probabilidadAcumulada, 2);
                    tiempo[i].Inferior = Math.Round(probabilidadInferior, 2);
                    tiempo[i].Superior = Math.Round(probabilidadAcumulada, 2);
                    probabilidadInferior = Math.Round(probabilidadAcumulada, 2);
                }
                dgvTiempos.DataSource = tiempo;
                dgvTiempos.Refresh();
            }
        }

        public void simular()
        {
            for (int a = 0; a < 19; a++)
            {
                dgvResultados.Columns.Add("Column", "Tipo Auto");
                dgvResultados.Columns.Add("Column", "Hora Llegada");
                dgvResultados.Columns.Add("Column", "Estado");
                dgvResultados.Columns.Add("Column", "Lugar");
                dgvResultados.Columns.Add("Column", "Hora Salida");
            }

            int iteraciones = int.Parse(txtCantidadIteraciones.Text);
            double desde = double.Parse(txtHoraInicio.Text);
            double hasta = double.Parse(txtHoraFin.Text);
            double indice = double.Parse(txtIndiceLlegada.Text);
            double cobro = double.Parse(txtTiempoCobro.Text);
            int contador = 0;

            Random random = new Random();
            Random random2 = new Random();

            double numero3;
            int numero4;

            double minimoColoreado;
            int flagColor;
            double minimoEstacionamiento;
            bool flagEstacionamiento = false;
            double minimoEsperando;
            int flagContador;

            double tiempo;
            double tiempoSiguiente;
            double demora;
            double funcion;
            double demoraSiguiente;

            //Dim hEuler As New Double
            //hEuler = txtH.Text

            dgvResultados.Columns[1].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[2].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[3].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[4].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[5].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[6].DefaultCellStyle.Format = "N0";
            dgvResultados.Columns[7].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[8].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[9].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[10].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[11].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[12].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[13].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[14].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[15].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[16].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[17].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[18].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[19].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[20].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[21].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[22].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[23].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[24].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[25].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[26].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[27].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[28].DefaultCellStyle.Format = "N2";
            dgvResultados.Columns[33].DefaultCellStyle.Format = "C2";

            //dgvEuler.Columns(0).DefaultCellStyle.Format = "N2"
            //dgvEuler.Columns(1).DefaultCellStyle.Format = "N2"
            //dgvEuler.Columns(2).DefaultCellStyle.Format = "N2"
            //dgvEuler.Columns(3).DefaultCellStyle.Format = "N2"
            //dgvEuler.Columns(4).DefaultCellStyle.Format = "N2"

            for (int r = 37; r < dgvResultados.ColumnCount - 1; r += 5)
            {
                dgvResultados.Columns[r].DefaultCellStyle.Format = "N0";
                dgvResultados.Columns[r + 1].DefaultCellStyle.Format = "N2";
                dgvResultados.Columns[r + 2].DefaultCellStyle.Format = "N0";
                dgvResultados.Columns[r + 4].DefaultCellStyle.Format = "N2";
            }

            double tipo1 = double.Parse(dgvTipos.Rows[0].Cells[3].Value.ToString());
            double tipo2 = double.Parse(dgvTipos.Rows[0].Cells[4].Value.ToString());
            double tipo3 = double.Parse(dgvTipos.Rows[1].Cells[3].Value.ToString());
            double tipo4 = double.Parse(dgvTipos.Rows[1].Cells[4].Value.ToString());
            double tipo5 = double.Parse(dgvTipos.Rows[2].Cells[3].Value.ToString());
            double tipo6 = double.Parse(dgvTipos.Rows[2].Cells[4].Value.ToString());
            double tipo7 = double.Parse(dgvTipos.Rows[3].Cells[3].Value.ToString());
            double tipo8 = double.Parse(dgvTipos.Rows[3].Cells[4].Value.ToString());

            double tiempo1 = double.Parse(dgvTiempos.Rows[0].Cells[3].Value.ToString());
            double tiempo2 = double.Parse(dgvTiempos.Rows[0].Cells[4].Value.ToString());
            double tiempo3 = double.Parse(dgvTiempos.Rows[1].Cells[3].Value.ToString());
            double tiempo4 = double.Parse(dgvTiempos.Rows[1].Cells[4].Value.ToString());
            double tiempo5 = double.Parse(dgvTiempos.Rows[2].Cells[3].Value.ToString());
            double tiempo6 = double.Parse(dgvTiempos.Rows[2].Cells[4].Value.ToString());
            double tiempo7 = double.Parse(dgvTiempos.Rows[3].Cells[3].Value.ToString());
            double tiempo8 = double.Parse(dgvTiempos.Rows[3].Cells[4].Value.ToString());

            //Primera Iteración
            double minimo = 0;
            int cocheraOcupada = 0;

            if (cmbColas.SelectedIndex == 0)
            {
                dgvResultados.Columns[31].Visible = false;
                dgvResultados.Columns[32].Visible = false;
            }
            else
            {
                dgvResultados.Columns[31].Visible = true;
                dgvResultados.Columns[32].Visible = true;
            }

            //Código Nuevo
            string evento;
            string evento_1;
            string evento_2;

            double reloj;
            double rnd1;
            double[] rnda1 = new double[199];
            double tiempoEntreLlegadas;
            double proximaLlegada;
            double rnd2;
            double[] rnda2 = new double[199];
            int tiempoAtencion;
            double nuevoFinCobro;

            double[] estacionamiento = new double[19];

            string[] tipoAuto = new string[19];
            double[] horaLlegadaAuto = new double[19];
            string[] estadoAuto = new string[19];
            int[] lugarAuto = new int[19];
            double[] horaSalidaAuto = new double[19];

            //Blanquea
            for (int j = 0; j < 19; j++)
            {
                estacionamiento[j] = 0;
                tipoAuto[j] = null;
                horaLlegadaAuto[j] = 0;
                estadoAuto[j] = null;
                lugarAuto[j] = 0;
                horaSalidaAuto[j] = 0;
            }

            double tiempoCobro;
            double finCobro = 0;
            double finCobro_1;
            string estadoCola1;
            int cola1;
            string estadoCola2;
            int cola2;
            double acRecaudacion;
            int autosAceptados;
            int autosRechazados;
            double rnd3;
            double[] rnda3 = new double[199];
            //int[] rnda4 = new int[199];

            string columna37 = "";
            double columna38;
            int columna39 = 0;

            //Primera Fila

            //dgvResultados.Rows(0).Cells(0).Value = "Inicializacion"
            evento = "Inicializacion";
            evento_1 = evento;
            evento_2 = evento;
            finCobro_1 = finCobro;
            //dgvResultados.Rows(0).Cells(1).Value = 0.00
            reloj = 0.00;

            //dgvResultados.Rows(0).Cells(29).Value = "Libre"
            estadoCola1 = "Libre";

            //dgvResultados.Rows(0).Cells(30).Value = 0
            cola1 = 0;

            //dgvResultados.Rows(0).Cells(31).Value = "Libre"
            estadoCola2 = "Libre";

            //dgvResultados.Rows(0).Cells(32).Value = 0
            cola2 = 0;

            //dgvResultados.Rows(0).Cells(33).Value = 0
            acRecaudacion = 0;

            //dgvResultados.Rows(0).Cells(34).Value = 0
            autosAceptados = 0;

            //dgvResultados.Rows(0).Cells(35).Value = 0
            autosRechazados = 0;

            //dgvResultados.Rows(0).Cells(2).Value = rnd1
            //Carga los arreglos con random.
            for (int j = 0; j < 199; j++)
            {
                rnda1[j] = random.NextDouble();
                rnda2[j] = random.NextDouble();
                rnda3[j] = random.NextDouble();
            }
            rnd1 = rnda1[0];

            tiempoEntreLlegadas = (indice * (-1)) * Math.Log(1 - rnd1);
            proximaLlegada = tiempoEntreLlegadas + reloj;

            rnd2 = 0;
            rnd3 = 0;
            numero4 = 0;

            tiempoAtencion = 0;

            //Agrega la Primera Fila.
            dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, null, null, null, null,
                                                   null, null, null, null, null, null,
                                                   null, null, null, null, null, null,
                                                   null, null, null, null, null, null,
                                                   null, null, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null,
                                                   null, null, null, null);
            int i;
            i = 1;
            int count;
            count = 0;























































            do{
                i += 1;
                if (i > 199){
                    i = 0;
                }else{
                    i = i;
                }

                rnd1 = rnda1[i];
                rnd2 = rnda2[i];
                rnd3 = rnda3[i];

                evento_2 = evento_1;
                evento_1 = evento;
                evento = columna37;
                //cobro = CInt(txtCobro.Text)
                cobro = 2;
                nuevoFinCobro = cobro + reloj;
                finCobro_1 = finCobro;

                if (evento_1 == "Inicializacion"){
                    evento = "Llegada Auto";
                    reloj = proximaLlegada;
                }

                //Borra el estacionamiento "j".
                for (int j = 0; j < 19; j++){
                    if (estacionamiento[j] == reloj){
                        estacionamiento[j] = 0;
                    }
                }

                //(2)Definición del primer Random.
                //(3)Definición del Tiempo entre Llegadas.

                tiempoEntreLlegadas = (indice * (-1)) * Math.Log(1 - rnd1);

                if (evento != "Llegada Auto"){
                    rnd1 = 0;
                    rnd2 = 0;
                    tiempoEntreLlegadas = 0;
                }else{
                    //(4)Definición de la Próxima Llegada.
                    proximaLlegada = tiempoEntreLlegadas + reloj;
                }

                //(5)Definición del segundo Random.
                if (evento == "Llegada Auto"){
                    if (cocheraOcupada < 21){
                        cocheraOcupada += 1;
                    }else{
                        cocheraOcupada = cocheraOcupada;
                    }
                }else{
                    rnd2 = 0;
                }

                //(6)Definición del Tiempo de Atención(Fin estadia).
                if (rnd2 != 0){
                    if (rnd2 >= tiempo1 && rnd2 < tiempo3){
                        tiempoAtencion = 1;
                    }

                    if (rnd2 >= tiempo3 && rnd2 < tiempo5){
                        tiempoAtencion = 2;
                    }

                    if(rnd2 >= tiempo5 && rnd2 < tiempo7){
                        tiempoAtencion = 3;
                    }

                    if (rnd2 >= tiempo7 && rnd2 <= tiempo8){
                        tiempoAtencion = 4;
                    }
                }else{
                        tiempoAtencion = 0;
                }

                //(7 - 26)Definición del Tiempo de Estacionamiento.
                if (rnd2 != 0){
                    bool lleno;
                    lleno = false;
                    numero4 = 0;
                    for (numero4 = 0; numero4 < 19; numero4++){
                        if (estacionamiento[numero4] != 0){
                            lleno = true;
                        }else{
                            lleno = false;
                            estacionamiento[numero4] = (tiempoAtencion * 60) + reloj;
                            columna37 = numero4.ToString();
                            break;
                        }
                    }
                    if (lleno == true){
                        autosRechazados += 1;
                        rnd2 = 0;
                        tiempoAtencion = 0;
                        //estacionamiento[numero4] = 0
                        tiempoCobro = 0;
                        finCobro = 0;
                    }
                }

                //(27)Definición del Tiempo de Cobro(Fin de Cobro).
                //(28)Definición del Tiempo de Fin de Cobro.
                //Mostrar el tiempo de próxima llegada de la fila anterior.

                //Deja de mostrar el tiempo Fin de Cobro cuando es el evento actual.
                //if( finCobro = reloj Then
                //    finCobro = Nothing
                //End if(

                //Definición del primer evento luego de la Inicialización.
                    if (proximaLlegada == minimo){
                        columna37 = "Llegada Auto";
                        columna38 = proximaLlegada;
                    }

                //Definición de los datos de los autos.
                    for (int j = 0; j < 19; j++)
                    {    //(34)Definición del Random para el tipo de auto.
                        if (tipoAuto[j] == null && evento == "Llegada Auto"){
                            if (cocheraOcupada < 21){
                                numero3 = rnd3;
                                //Definición del Tipo de Auto.
                                if (rnd3 >= tipo1 && rnd3 < tipo3){
                                    tipoAuto[j] = "Auto Pequeño";
                                    horaLlegadaAuto[j] = reloj;
                                    estadoAuto[j] = "Estacionado";
                                    lugarAuto[j] = numero4 + 1;
                                    horaSalidaAuto[j] = 0;
                                    break;
                                }

                                if (rnd3 >= tipo3 && rnd3 < tipo5){
                                    tipoAuto[j] = "Auto Grande";
                                    horaLlegadaAuto[j] = reloj;
                                    estadoAuto[j] = "Estacionado";
                                    lugarAuto[j] = numero4 + 1;
                                    horaSalidaAuto[j] = 0;
                                    break;
                                }

                                if (rnd3 >= tipo5 && rnd3 <= tipo6){
                                    tipoAuto[j] = "Utilitario";
                                    horaLlegadaAuto[j] = reloj;
                                    estadoAuto[j] = "Estacionado";
                                    lugarAuto[j] = numero4 + 1;
                                    horaSalidaAuto[j] = 0;
                                    break;
                                }else{
                                    numero3 = 0;
                                }
                            }
                            //else { 
                            //null;
                        }
                    }
                
                                //Cálculo de la Demora por Euler.
                                if( evento == "Fin de Estadía") { 
                                    if( cmbColas.SelectedIndex == 0){
                                        for(int j = 0; j<19; j++) { 
                                           if( tipoAuto[j] == "Auto Grande" && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){
                                                tiempo = 0;
                                                tiempoSiguiente = 0;// + hEuler;
                                                demora = 2;
                                           //dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                           //     While demora <= 180
                                           //         funcion = cola1 + 0.2 * cobro + tiempoSiguiente ^ 2
                                           //         tiempoSiguiente = tiempo + hEuler
                                           //         demoraSiguiente = demora + funcion * hEuler
                                           //         dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                           //         tiempo = tiempoSiguiente
                                           //         demora = demoraSiguiente
                                           //     End While
                                                tiempoCobro = tiempo;
                                                horaSalidaAuto[j] = tiempo + reloj;
                                                break;
                                            }
                                            if((tipoAuto[j] == "Utilitario" || tipoAuto[j] == "Auto Pequeño") && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){ 
                                                tiempo = 0;
                                                tiempoSiguiente = 0;// + hEuler
                                                demora = 2;
                                           //     dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                           //     While demora <= 130
                                           //         funcion = cola1 + 0.2 * cobro + tiempoSiguiente ^ 2
                                           //         tiempoSiguiente = tiempo + hEuler
                                           //         demoraSiguiente = demora + funcion * hEuler
                                           //         dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                           //         tiempo = tiempoSiguiente
                                           //         demora = demoraSiguiente
                                           //     End While
                                                tiempoCobro = tiempo;
                                                horaSalidaAuto[j] = tiempo + reloj;
                                                break;
                                            }
                                       }
                                    }else {//if( cmbColas.SelectedIndex = 1 Then
                                        if( cola2 >= cola1){
                                            for(int j= 0; j<19;j++){
                                                if(tipoAuto[j] == "Auto Grande" && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){
                                                    tiempo = 0;
                                                    tiempoSiguiente = 0;// + hEuler
                                                    demora = 2;
                                        //            dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                        //            While demora <= 180
                                        //                funcion = cola2 + 0.2 * cobro + tiempoSiguiente ^ 2
                                        //                tiempoSiguiente = tiempo + hEuler
                                        //                demoraSiguiente = demora + funcion * hEuler
                                        //                dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                        //                tiempo = tiempoSiguiente
                                        //                demora = demoraSiguiente
                                        //            End While
                                                    tiempoCobro = tiempo;
                                                    horaSalidaAuto[j] = tiempo + reloj;
                                                    break;
                                                }
                                                if((tipoAuto[j] == "Utilitario" || tipoAuto[j] == "Auto Pequeño") && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){
                                                    tiempo = 0;
                                                    tiempoSiguiente = 0;// + hEuler
                                                    demora = 2;
                                        //            dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                        //            While demora <= 130
                                        //                funcion = cola2 + 0.2 * cobro + tiempoSiguiente ^ 2
                                        //                tiempoSiguiente = tiempo + hEuler
                                        //                demoraSiguiente = demora + funcion * hEuler
                                        //                dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                        //                tiempo = tiempoSiguiente
                                        //                demora = demoraSiguiente
                                        //            End While
                                                    tiempoCobro = tiempo;
                                                    horaSalidaAuto[j] = tiempo + reloj;
                                                    break;
                                                }
                                            }
                                        }else{
                                            for(int j=0; j<19;j++){
                                                if( tipoAuto[j] == "Auto Grande" && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){
                                                    tiempo = 0;
                                                    tiempoSiguiente = 0;// + hEuler
                                                    demora = 2;
                                        //            dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                        //            While demora <= 180
                                        //                funcion = cola1 + 0.2 * cobro + tiempoSiguiente ^ 2
                                        //                tiempoSiguiente = tiempo + hEuler
                                        //                demoraSiguiente = demora + funcion * hEuler
                                        //                dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                        //                tiempo = tiempoSiguiente
                                        //                demora = demoraSiguiente
                                        //            End While
                                                    tiempoCobro = tiempo;
                                                    horaSalidaAuto[j] = tiempo + reloj;
                                                    break;
                                                }
                                                if((tipoAuto[j] == "Utilitario" || tipoAuto[j] == "Auto Pequeño") && (((horaLlegadaAuto[j] + 60) == reloj) || ((horaLlegadaAuto[j] + 120) == reloj) || ((horaLlegadaAuto[j] + 180) == reloj) || ((horaLlegadaAuto[j] + 240) == reloj))){
                                                    tiempo = 0;
                                                    tiempoSiguiente = 0;//+ hEuler
                                                    demora = 2;
                                        //            dgvEuler.Rows.Add(reloj, tiempo, demora, 0, 0, 0)
                                        //            While demora <= 130
                                        //                funcion = cola1 + 0.2 * cobro + tiempoSiguiente ^ 2
                                        //                tiempoSiguiente = tiempo + hEuler
                                        //                demoraSiguiente = demora + funcion * hEuler
                                        //                dgvEuler.Rows.Add(reloj, tiempo, demora, funcion, tiempoSiguiente, demoraSiguiente)
                                        //                tiempo = tiempoSiguiente
                                        //                demora = demoraSiguiente
                                        //            End While
                                                    tiempoCobro = tiempo;
                                                    horaSalidaAuto[j] = tiempo + reloj;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }

                                //Cambiar el estado del auto si es el caso. (VER Y CORREGIR)
                                for(int j =0; j<19;j++){
                                    //Pregunto si es un Fin de Estadía, y compruebo cuál es el auto que se va de la cochera, para poder cambiar el estado del mismo.
                                    flagEstacionamiento = false;
                                    flagContador = 0;
                                    if( estadoAuto[j] == "Siendo Cobrado" ){
                                        flagContador += 1;
                                        flagEstacionamiento = true;
                                    }
                                    if( horaSalidaAuto[j] != 0 && horaSalidaAuto[j] > reloj){
                                        if( cmbColas.SelectedIndex == 0){
                                            if( cola1 == 0 && estadoCola1 == "Libre"){
                                                estadoAuto[j] = "Siendo Cobrado";
                                            }else{
                                                if( estadoCola1 == "Ocupado"){
                                                    if( estadoAuto[j] == "Siendo Cobrado"){
                                                        estadoAuto[j] = "Siendo Cobrado";
                                                    }else{
                                                        estadoAuto[j] = "Esperando Cobro";
                                                    }
                                                }
                                            }

                                            if( flagContador >= 1 && ((horaLlegadaAuto[j] + reloj == 60) || (horaLlegadaAuto[j] + reloj == 120) || (horaLlegadaAuto[j] + reloj == 180) || (horaLlegadaAuto[j] + reloj == 240))){
                                                estadoAuto[j] = "Esperando Cobro";
                                            }
                                            minimoEsperando = 0;//////////////////////////////YO
                                            for(int k=0;k<19;k++){
                                                if( horaSalidaAuto[k] > 0 ){
                                                    if( horaSalidaAuto[k] > reloj){
                                                        minimoEsperando = horaSalidaAuto[k];
                                                        break;
                                                    }
                                                }
                                            }
                                            for(int k=0; k<19;k++){
                                                if( horaSalidaAuto[k] > 0 && horaSalidaAuto[k] <= minimoEsperando){
                                                    minimoEsperando = horaSalidaAuto[k];
                                                }
                                            }

                                            if( evento == "Fin de Cobro" && flagContador< 1 && estadoAuto[j] == "Esperando Cobro"){
                                                estadoAuto[j] = "Siendo Cobrado";
                                            }

                                        }else{
                                            if((cola1 == 0 && estadoCola1 == "Libre") || (cola2 == 0 && estadoCola2 == "Libre")){
                                                estadoAuto[j] = "Siendo Cobrado";
                                            }else{
                                                if( estadoCola1 == "Ocupado" && estadoCola2 == "Ocupado"){
                                                    if( estadoAuto[j] == "Siendo Cobrado"){
                                                        estadoAuto[j] = "Siendo Cobrado";
                                                    }else{
                                                        estadoAuto[j] = "Esperando Cobro";
                                                    }
                                                }
                                            }

                                            if( flagContador >= 2 && ((horaLlegadaAuto[j] + reloj == 60) || (horaLlegadaAuto[j] + reloj == 120) || (horaLlegadaAuto[j] + reloj == 180) || (horaLlegadaAuto[j] + reloj == 240))){
                                                estadoAuto[j] = "Esperando Cobro";
                                            }
                                            minimoEsperando = 0;////////////////////////////////YO
                                            for(int k=0;k<19;k++){
                                                if( horaSalidaAuto[k] > 0 ){
                                                    if( horaSalidaAuto[k] > reloj ){
                                                        minimoEsperando = horaSalidaAuto[k];
                                                        break;
                                                    }
                                                }
                                            }
                                            for(int k = 0; j<19; k++){
                                                if( horaSalidaAuto[k] > 0 && horaSalidaAuto[k] <= minimoEsperando ){
                                                    minimoEsperando = horaSalidaAuto[k];
                                                }
                                            }

                                            if( evento == "Fin de Cobro" && flagContador< 2 && estadoAuto[j] == "Esperando Cobro"){
                                                estadoAuto[j] = "Siendo Cobrado";
                                            }
                                        }
                                    }

                                    if( horaSalidaAuto[j] == reloj){
                                        estadoAuto[j] = "Siendo Cobrado";
                                    }

                                    if( flagEstacionamiento == true &&((horaLlegadaAuto[j] + reloj == 60) || (horaLlegadaAuto[j] + reloj == 120) || (horaLlegadaAuto[j] + reloj == 180) || (horaLlegadaAuto[j] + reloj == 240))){
                                        estadoAuto[j] = "Esperando Cobro";
                                    }
                                    minimoEsperando=0;///////////////////////////////////////////////////
                                    for(int k= 0; k<19; k++){
                                        if( horaSalidaAuto[k] > 0){
                                            if( horaSalidaAuto[k] > reloj){
                                                minimoEsperando = horaSalidaAuto[k];
                                                break;
                                            }
                                        }
                                    }
                                    for(int k=0;k<19;k++){
                                        if( horaSalidaAuto[k] > 0 && horaSalidaAuto[k] <= minimoEsperando){
                                            minimoEsperando = horaSalidaAuto[k];
                                        }
                                    }

                                    if( evento == "Fin de Cobro" && flagEstacionamiento == false && estadoAuto[j] == "Esperando Cobro"){
                                        estadoAuto[j] = "Siendo Cobrado";
                                    }
                                }
                                for(int j=0; j<19;j++){
                                    if( reloj >= horaSalidaAuto[j] && estadoAuto[j] == "Siendo Cobrado"){
                                        //Deja de mostrar los datos del auto una vez que éste ya se fue de la playa de estacionamiento.DEJAR ACÁ Y NO METERLO EN EL CICLO DE ARRIBA.
                                        tipoAuto[j] = null;
                                        horaLlegadaAuto[j] = 0;
                                        estadoAuto[j] = null;
                                        lugarAuto[j] = 0;
                                        horaSalidaAuto[j] = 0;
                                        minimoEstacionamiento = 0;
                                    }
                                }

                                //(33)Definición del Monto a Cobrar.
                                for(int j=0;j>19;j++){
                                   //if( evento = "Fin de Estadía" And estadoAuto(j) = "Siendo Cobrado" And ((horaLlegadaAuto(j) + reloj = 60) Or (horaLlegadaAuto(j) + reloj = 120) Or (horaLlegadaAuto(j) + reloj = 180) Or (horaLlegadaAuto(j) + reloj = 240)) Then
                                    if( evento == "Fin de Estadía" && estadoAuto[j] == "Siendo Cobrado" ){
                                        if( tipoAuto[j] == "Auto Pequeño" ){
                                            if((((reloj - horaLlegadaAuto[j]) == 240)) ){
                                               acRecaudacion += 4;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 180)) ){
                                               acRecaudacion += 3;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 120)) ){
                                               acRecaudacion += 2;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 60)) ){
                                               acRecaudacion += 1;
                                            }
                                            break;
                                        }

                                        if( tipoAuto[j] == "Auto Grande" ){
                                            if((((reloj - horaLlegadaAuto[j]) == 240)) ){
                                               acRecaudacion += 4.8;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 180)) ){
                                               acRecaudacion += 3.6;
                                            }
                                            if((reloj - horaLlegadaAuto[j]) == 120) {
                                               acRecaudacion += 2.4;
                                            }
                                            if(((reloj - horaLlegadaAuto[j]) == 60) ){
                                               acRecaudacion += 1.2;
                                            }
                                            break;
                                        }

                                        if( tipoAuto[j] == "Utilitario" ){
                                            if((((reloj - horaLlegadaAuto[j]) == 240)) ){
                                               acRecaudacion += 6;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 180)) ){
                                               acRecaudacion += 4.5;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 120)) ){
                                               acRecaudacion += 3;
                                            }
                                            if((((reloj - horaLlegadaAuto[j]) == 60))){
                                               acRecaudacion += 1.5;
                                            }
                                            break;
                                        }
                                    }else{
                                        acRecaudacion += 0;
                                    }
                                }

                                //Sin este if(, directamente no existen los "Fin de Cobro", asique dejarlo.
/*                                if( evento = "Fin de Estadía" Then
                                    if( finCobro > 0 Then

                                    else
                                        finCobro = reloj + tiempoCobro
                                    End if(
                                End if(
                                //Deja de mostrar el tiempo Fin de Cobro cuando es el evento actual.DEJARLO EN -1 A MENOS QUE SE ENCUENTRE UNA FORMA MÁS ENTENDIBLE(ASÍ FUNCIONA PARA 1 COLA - PARA 2 NO PROBÉ).
                                if( finCobro = reloj Then
                                    finCobro = -1
                                End if(

                                //Búsqueda del mínimo. (Antes estaba debajo de "Deja de mostrar el tiempo Fin de Cobro cuando es el evento actual.")(DEJAR ACÁ QUE FUNCIONA PARA 1 COLA, PARA 2 NO PROBÉ).
                                minimo = proximaLlegada
                                For j = 0 To 19
                                    if( estacionamiento(j) > 0 And estacionamiento(j) < minimo Then
                                        minimo = estacionamiento(j)
                                        columna37 = "Fin de Estadía"
                                        columna38 = minimo
                                    End if(
                                Next
                                if( evento_1 != "Inicializacion" Then
                                    if( finCobro > 0 And finCobro<minimo Then
                                        minimo = finCobro
                                        columna37 = "Fin de Cobro"
                                        columna38 = minimo
                                    End if(
                                End if(
                                if( proximaLlegada <= minimo Then
                                    minimo = proximaLlegada
                                    columna37 = "Llegada Auto"
                                    columna38 = minimo
                                End if(

                                //Búsqueda de lo que sería el próximo fin de cobro, buscando el mínimo entre las columnas de "Hora de Salida del Auto".
                                //Aclaración: el mínimo estacionado con el que se compara en el if( 2 líneas más abajo, queda definido en la línea 640.
                                if( evento = "Fin de Cobro" And finCobro = -1 Then
                                    For j = 0 To 19
                                        if( horaSalidaAuto(j) > 0 Then
                                            if( horaSalidaAuto(j) > reloj Then
                                                minimoEstacionamiento = horaSalidaAuto(j)
                                                Exit For
                                            End if(
                                        End if(
                                    Next
                                    For j = 0 To 19
                                        if( horaSalidaAuto(j) > 0 And horaSalidaAuto(j) < minimoEstacionamiento Then
                                            minimoEstacionamiento = horaSalidaAuto(j)
                                        End if(
                                    Next
                                End if(
                                if( finCobro = -1 Then
                                    finCobro = minimoEstacionamiento
                                End if(

                                //Contador de Autos
                                if( evento = "Fin de Cobro" Then
                                    if( cocheraOcupada = 21 Then
                                        cocheraOcupada -= 2
                                    elseif( cocheraOcupada >= 0 Then
                                        cocheraOcupada -= 1
                                    else
                                        cocheraOcupada = 0
                                    End if(
                                End if(

                                //(32)Definición de la cantidad de Autos Aceptados en el sistema.
                                //(33)Definición de la cantidad de Autos Rechazados en el sistema.
                                if( cocheraOcupada <= 20 And evento = "Llegada Auto" Then
                                    autosAceptados += 1
                                elseif( cocheraOcupada > 20 And evento = "Llegada Auto" Then
                                    //autosRechazados += 1
                                    //rnd2 = Nothing
                                    //tiempoAtencion = Nothing
                                    //estacionamiento(numero4) = Nothing
                                    //tiempoCobro = Nothing
                                    //finCobro = Nothing
                                End if(

                                //Definición de Colas
                                //COLA 1
                                if( cmbColas.SelectedIndex = 0 Then
                                    //Datos Cola 1 cuando hay 1 sola cola.
                                    if( evento_1!= "Inicializacion" Then
                                       if( evento = "Fin de Estadía" Then
                                            //if( finCobro != Nothing And evento_1 = "Fin de Estadía" Then
                                            if( evento = "Fin de Estadía" And estadoCola1 = "Ocupado" Then
                                                cola1 += 1
                                            End if(
                                            estadoCola1 = "Ocupado"
                                            //elseif( evento = "Fin de Cobro" And evento_1 = "Fin de Estadía" And evento_2 = "Fin de Estadía" Then
                                        elseif( evento = "Fin de Cobro" And cola1 > 0 Then
                                            estadoCola1 = "Ocupado"
                                            cola1 -= 1
                                            //elseif( evento = "Llegada Auto" And evento_1 = "Fin de Estadía" Then
                                        elseif( evento = "Llegada Auto" And estadoCola1 = "Ocupado" Then
                                            estadoCola1 = "Ocupado"
                                        else
                                            estadoCola1 = "Libre"
                                            cola1 = 0
                                        End if(

                                        //if( finCobro = 0 And cola1 > 0 And evento = "Fin de Cobro" Then
                                        //    cola1 -= 1
                                        //End if(
                                    End if(

                                    if( cola1 > 0 Then
                                        estadoCola1 = "Ocupado"
                                    End if(

                                    //COLA 2
                                elseif( cmbColas.SelectedIndex = 1 Then
                                    //Datos Cola 1 y 2 cuando hay 2 colas.
                                    if( evento_1!= "Inicializacion" Then
                                       if( evento = "Fin de Estadía" Then
                                           if( cola1 <= cola2 Then
                                               if( estadoCola1 = "Ocupado" And estadoCola2 = "Libre" Then
                                                   estadoCola2 = "Ocupado"
                                                elseif( estadoCola1 = "Ocupado" And estadoCola2 = "Ocupado" Then
                                                    estadoCola1 = "Ocupado"
                                                    cola1 += 1
                                                elseif( estadoCola1 = "Libre" Then
                                                    estadoCola1 = "Ocupado"
                                                End if(
                                            elseif( cola1 > cola2 Then
                                                if( estadoCola2 = "Ocupado" Then
                                                    estadoCola2 = "Ocupado"
                                                    cola2 += 1
                                                End if(
                                            elseif( estadoCola2 = "Libre" Then
                                                estadoCola2 = "Ocupado"
                                            End if(
                                        End if(

                                        if( evento = "Fin de Cobro" Then
                                            if( estadoCola1 = "Ocupado" And cola1 = 0 And estadoCola2 = "Ocupado" And cola2 = 0 Then
                                                estadoCola2 = "Libre"
                                            elseif( cola2 >= cola1 And cola2 > 0 Then
                                                cola2 -= 1
                                                estadoCola2 = "Ocupado"
                                            elseif( cola1 > cola2 And cola1 > 0 Then
                                                cola1 -= 1
                                                estadoCola1 = "Ocupado"
                                            elseif( cola1 = 0 Then
                                                cola1 = 0
                                                estadoCola1 = "Libre"
                                            elseif( cola2 = 0 Then
                                                cola2 = 0
                                                estadoCola2 = "Libre"
                                            End if(
                                        End if(
                                    End if(
                                End if(


                                //Guardado del mínimo(Hora próxima del reloj).
                                columna38 = minimo

                                //Agrega Fila.
                                //if( (reloj >= desde And reloj <= hasta) Then
                                if((reloj >= desde And count < iteraciones) Then
                                    dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, rnd2, tiempoAtencion, estacionamiento(0), estacionamiento(1),
                                                        estacionamiento(2), estacionamiento(3), estacionamiento(4), estacionamiento(5), estacionamiento(6), estacionamiento(7),
                                                        estacionamiento(8), estacionamiento(9), estacionamiento(10), estacionamiento(11), estacionamiento(12), estacionamiento(13),
                                                        estacionamiento(14), estacionamiento(15), estacionamiento(16), estacionamiento(17), estacionamiento(18), estacionamiento(19),
                                                        tiempoCobro, finCobro, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, rnd3,
                                                        tipoAuto(0), horaLlegadaAuto(0), estadoAuto(0), lugarAuto(0), horaSalidaAuto(0),
                                                        tipoAuto(1), horaLlegadaAuto(1), estadoAuto(1), lugarAuto(1), horaSalidaAuto(1),
                                                        tipoAuto(2), horaLlegadaAuto(2), estadoAuto(2), lugarAuto(2), horaSalidaAuto(2),
                                                        tipoAuto(3), horaLlegadaAuto(3), estadoAuto(3), lugarAuto(3), horaSalidaAuto(3),
                                                        tipoAuto(4), horaLlegadaAuto(4), estadoAuto(4), lugarAuto(4), horaSalidaAuto(4),
                                                        tipoAuto(5), horaLlegadaAuto(5), estadoAuto(5), lugarAuto(5), horaSalidaAuto(5),
                                                        tipoAuto(6), horaLlegadaAuto(6), estadoAuto(6), lugarAuto(6), horaSalidaAuto(6),
                                                        tipoAuto(7), horaLlegadaAuto(7), estadoAuto(7), lugarAuto(7), horaSalidaAuto(7),
                                                        tipoAuto(8), horaLlegadaAuto(8), estadoAuto(8), lugarAuto(8), horaSalidaAuto(8),
                                                        tipoAuto(9), horaLlegadaAuto(9), estadoAuto(9), lugarAuto(9), horaSalidaAuto(9),
                                                        tipoAuto(10), horaLlegadaAuto(10), estadoAuto(10), lugarAuto(10), horaSalidaAuto(10),
                                                        tipoAuto(11), horaLlegadaAuto(11), estadoAuto(11), lugarAuto(11), horaSalidaAuto(11),
                                                        tipoAuto(12), horaLlegadaAuto(12), estadoAuto(12), lugarAuto(12), horaSalidaAuto(12),
                                                        tipoAuto(13), horaLlegadaAuto(13), estadoAuto(13), lugarAuto(13), horaSalidaAuto(13),
                                                        tipoAuto(14), horaLlegadaAuto(14), estadoAuto(14), lugarAuto(14), horaSalidaAuto(14),
                                                        tipoAuto(15), horaLlegadaAuto(15), estadoAuto(15), lugarAuto(15), horaSalidaAuto(15),
                                                        tipoAuto(16), horaLlegadaAuto(16), estadoAuto(16), lugarAuto(16), horaSalidaAuto(16),
                                                        tipoAuto(17), horaLlegadaAuto(17), estadoAuto(17), lugarAuto(17), horaSalidaAuto(17),
                                                        tipoAuto(18), horaLlegadaAuto(18), estadoAuto(18), lugarAuto(18), horaSalidaAuto(18),
                                                        tipoAuto(19), horaLlegadaAuto(19), estadoAuto(19), lugarAuto(19), horaSalidaAuto(19))
                                    count += 1
                                End if(

                                //Defino Siguiente Reloj.
                                reloj = columna38

                                //Agrega la última fila
                                if( reloj >= hasta Then
                                    dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, rnd2, tiempoAtencion, estacionamiento(0), estacionamiento(1),
                                                        estacionamiento(2), estacionamiento(3), estacionamiento(4), estacionamiento(5), estacionamiento(6), estacionamiento(7),
                                                        estacionamiento(8), estacionamiento(9), estacionamiento(10), estacionamiento(11), estacionamiento(12), estacionamiento(13),
                                                        estacionamiento(14), estacionamiento(15), estacionamiento(16), estacionamiento(17), estacionamiento(18), estacionamiento(19),
                                                        tiempoCobro, finCobro, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, rnd3,
                                                        tipoAuto(0), horaLlegadaAuto(0), estadoAuto(0), lugarAuto(0), horaSalidaAuto(0),
                                                        tipoAuto(1), horaLlegadaAuto(1), estadoAuto(1), lugarAuto(1), horaSalidaAuto(1),
                                                        tipoAuto(2), horaLlegadaAuto(2), estadoAuto(2), lugarAuto(2), horaSalidaAuto(2),
                                                        tipoAuto(3), horaLlegadaAuto(3), estadoAuto(3), lugarAuto(3), horaSalidaAuto(3),
                                                        tipoAuto(4), horaLlegadaAuto(4), estadoAuto(4), lugarAuto(4), horaSalidaAuto(4),
                                                        tipoAuto(5), horaLlegadaAuto(5), estadoAuto(5), lugarAuto(5), horaSalidaAuto(5),
                                                        tipoAuto(6), horaLlegadaAuto(6), estadoAuto(6), lugarAuto(6), horaSalidaAuto(6),
                                                        tipoAuto(7), horaLlegadaAuto(7), estadoAuto(7), lugarAuto(7), horaSalidaAuto(7),
                                                        tipoAuto(8), horaLlegadaAuto(8), estadoAuto(8), lugarAuto(8), horaSalidaAuto(8),
                                                        tipoAuto(9), horaLlegadaAuto(9), estadoAuto(9), lugarAuto(9), horaSalidaAuto(9),
                                                        tipoAuto(10), horaLlegadaAuto(10), estadoAuto(10), lugarAuto(10), horaSalidaAuto(10),
                                                        tipoAuto(11), horaLlegadaAuto(11), estadoAuto(11), lugarAuto(11), horaSalidaAuto(11),
                                                        tipoAuto(12), horaLlegadaAuto(12), estadoAuto(12), lugarAuto(12), horaSalidaAuto(12),
                                                        tipoAuto(13), horaLlegadaAuto(13), estadoAuto(13), lugarAuto(13), horaSalidaAuto(13),
                                                        tipoAuto(14), horaLlegadaAuto(14), estadoAuto(14), lugarAuto(14), horaSalidaAuto(14),
                                                        tipoAuto(15), horaLlegadaAuto(15), estadoAuto(15), lugarAuto(15), horaSalidaAuto(15),
                                                        tipoAuto(16), horaLlegadaAuto(16), estadoAuto(16), lugarAuto(16), horaSalidaAuto(16),
                                                        tipoAuto(17), horaLlegadaAuto(17), estadoAuto(17), lugarAuto(17), horaSalidaAuto(17),
                                                        tipoAuto(18), horaLlegadaAuto(18), estadoAuto(18), lugarAuto(18), horaSalidaAuto(18),
                                                        tipoAuto(19), horaLlegadaAuto(19), estadoAuto(19), lugarAuto(19), horaSalidaAuto(19))
                                End if(*/
            } while (reloj <= hasta);}

                //    For i = 0 To dgvResultados.RowCount - 1
                //        //Pinta la celda que sea la del mínimo.
                //        minimoColoreado = dgvResultados.Rows(i).Cells(4).Value
                //        For j = 7 To 26
                //            If dgvResultados.Rows(i).Cells(j).Value < minimoColoreado And dgvResultados.Rows(i).Cells(j).Value <> 0 Then
                //                minimoColoreado = dgvResultados.Rows(i).Cells(j).Value
                //                flagColor = j
                //            End If
                //        Next
                //        If dgvResultados.Rows(i).Cells(28).Value < minimoColoreado And dgvResultados.Rows(i).Cells(28).Value <> 0 Then
                //            minimoColoreado = dgvResultados.Rows(i).Cells(28).Value
                //            flagColor = 2
                //        End If
                //        If dgvResultados.Rows(i).Cells(4).Value <= minimoColoreado And dgvResultados.Rows(i).Cells(4).Value <> 0 Then
                //            dgvResultados.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                //            minimoColoreado = dgvResultados.Rows(i).Cells(4).Value
                //            flagColor = 3
                //        End If

                //        If flagColor = 2 Then
                //            dgvResultados.Rows(i).Cells(28).Style.BackColor = Color.Yellow
                //        ElseIf flagColor = 3 Then
                //            dgvResultados.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                //        Else
                //            dgvResultados.Rows(i).Cells(flagColor).Style.BackColor = Color.Yellow
                //        End If

                //        flagColor = Nothing

                //        ////Colorea de a grupos de 5 columnas (Beige).
                //        For j = 37 To (dgvResultados.ColumnCount - 1) Step 10
                //            ////Columna de la Hora de Llegada del Auto.
                //            For k = 38 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.Beige
                //                If dgvResultados.Rows(i).Cells(k).Value = 0.00 Then
                //                    dgvResultados.Rows(i).Cells(k).Value = Nothing
                //                End If
                //            Next

                //            ////Columna del Estado del Auto.
                //            For l = 39 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(l).Style.BackColor = Color.Beige
                //            Next

                //            ////Columna del Lugar de Estacionamiento del Auto.
                //            For m = 40 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.Beige
                //                If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                //                    dgvResultados.Rows(i).Cells(m).Value = Nothing
                //                End If
                //            Next

                //            ////Columna de la Hora de Salida del Auto.
                //            For m = 41 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.Beige
                //                If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                //                    dgvResultados.Rows(i).Cells(m).Value = Nothing
                //                End If
                //            Next

                //            ////Columna del Tipo de Auto.
                //            dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.Beige
                //        Next

                //        ////Grupos de 5 columnas que quedaron en blanco, deja los valores en Nothing cuando es el caso.
                //        For j = 42 To (dgvResultados.ColumnCount - 1) Step 10
                //            ////Columna de la Hora de Llegada del Auto.
                //            For k = 43 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.NavajoWhite
                //                If dgvResultados.Rows(i).Cells(k).Value = 0.00 Then
                //                    dgvResultados.Rows(i).Cells(k).Value = Nothing
                //                End If
                //            Next

                //            ////Columna del Estado del Auto.
                //            For l = 44 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(l).Style.BackColor = Color.NavajoWhite
                //            Next

                //            ////Columna del Lugar de Estacionamiento del Auto.
                //            For m = 45 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.NavajoWhite
                //                If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                //                    dgvResultados.Rows(i).Cells(m).Value = Nothing
                //                End If
                //            Next

                //            ////Columna de la Hora de Salida del Auto.
                //            For m = 46 To (dgvResultados.ColumnCount - 1) Step 10
                //                dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.NavajoWhite
                //                If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                //                    dgvResultados.Rows(i).Cells(m).Value = Nothing
                //                End If
                //            Next

                //            ////Columna del Tipo de Auto.
                //            dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.NavajoWhite
                //        Next
                //    Next
                //Else
                //    If txtIndice.Text = "" Then
                //        MessageBox.Show("Ingrese el índice de llegada de coches deseado.")
                //    End If

                //    If txtCobro.Text = "" Then
                //        MessageBox.Show("Ingrese el tiempo de cobro deseado.")
                //    End If

                //    If txtIteraciones.Text = "" Then
                //        MessageBox.Show("Ingrese la cantidad de iteraciones deseadas.")
                //    End If

                //    If txtInicio.Text = "" Then
                //        MessageBox.Show("Ingrese la hora inicial deseada.")
                //    End If

                //    If cmbColas.SelectedIndex = -1 Then
                //        MessageBox.Show("Seleccione la cantidad de colas deseada.")
                //    End If

                //    If txtH.Text = "" Then
                //        MessageBox.Show("Ingrese el valor de H deseado.")
                //    End If

            //}

    }
}
