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

            //Primera Iteración
            double minimo;
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
            double[] rnda2 = new double [199];
            int tiempoAtencion;
            double nuevoFinCobro;

            double[] estacionamiento = new double [19];

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
                horaSalidaAuto[j]  = 0;
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

            string columna37;
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





        }



    }
}
