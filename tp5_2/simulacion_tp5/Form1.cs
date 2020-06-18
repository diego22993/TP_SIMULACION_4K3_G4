using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            cmbCantidadCabinas.SelectedIndex = 0;
            txtHoraInicio.Text = "0";
            txtHoraFin.Text = "25";            
            txtCantidadIteraciones.Text = "5";
            tamanio.Add(new FilaTamanio("Pequeño", .45, .45, 000, .50));
            tamanio.Add(new FilaTamanio("Grande", .25, .70, .45, .70));
            tamanio.Add(new FilaTamanio("Utilitario", .30, .45, .70, 001));
            gridTamaño.DataSource = tamanio;
            tiempo.Add(new FilaTiempo(60, .50, .50, 000, .50));
            tiempo.Add(new FilaTiempo(120, .30, .80, .50, .80));
            tiempo.Add(new FilaTiempo(180, .15, .95, .80, .95));
            tiempo.Add(new FilaTiempo(240, .05, 001, .95, 001));
            gridTiempo.DataSource = tiempo;
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
                gridTamaño.DataSource = tamanio;
                gridTamaño.Refresh();
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
                gridTiempo.DataSource = tiempo;
                gridTiempo.Refresh();
            }
        }

        public void simular()
        {
            for(int i = 0; i < 19; i++)
            {
                dgvResultados.Columns.Add("Column", "Tipo Auto");
                dgvResultados.Columns.Add("Column", "Hora Llegada");
                dgvResultados.Columns.Add("Column", "Estado");
                dgvResultados.Columns.Add("Column", "Lugar");
                dgvResultados.Columns.Add("Column", "Hora Salida");
            }

            int iteraciones;
            iteraciones = Convert.ToInt32(txtCantidadIteraciones.Text);
            double desde;
            desde = Convert.ToDouble(txtHoraInicio.Text);
            double hasta;
            hasta = Convert.ToDouble(txtHoraFin.Text);
            double indice;
            indice = Convert.ToDouble(txtIndiceLlegada.Text);
            double cobro;
            cobro = Convert.ToDouble(txtTiempoCobro.Text);
            int contador = 0;

            Random random;
            Random random2;

            double numero3;
            double numero4;

            double minimoColoreado;
            int flagColor;
            double minimoEstacionamiento;
            bool flagEstacionamiento = false;
            double minimoEsperando;
            int flagContador;

            /*AÑADIR PARA TP6
             * 
             * double tiempo;
            double tiempoSiguiente;
            double demora;
            double demoraSiguiente;
            double hEuler;

            hEuler = Convert.toDouble(txtHEuler.text);
            */




            //int iteraciones = 
            //Dim iteraciones As New Integer
            //iteraciones = txtIteraciones.Text
            //Dim desde As New Double
            //desde = txtInicio.Text
            //Dim hasta As New Double
            //hasta = txtFinal.Text
            //Dim indice As New Double
            //indice = txtIndice.Text
            //Dim cobro As New Double
            //cobro = txtCobro.Text
            //Dim contador As New Integer
            //contador = 0



            dgvResultados.DefaultCellStyle.Format = "N2";
        }



    }
}
