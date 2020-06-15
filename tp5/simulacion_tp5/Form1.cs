using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_tp5
{
    public partial class Form1 : Form
    {
        List<FilaTamaño> tamaño = new List<FilaTamaño>();
        List<FilaTiempo> tiempo = new List<FilaTiempo>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InicializarGrid();
        }

        public void InicializarGrid()
        {
            txtIndiceLlegada.Text = "13";
            txtTiempoDeCobro.Text = "2";
            cboCantidaCabinas.SelectedIndex = 0;
            txtMinutosSimulacion.Text = "25";
            txtMinutosDesde.Text = "2";
            txtCantidadIteraciones.Text = "5";
            tamaño.Add(new FilaTamaño("Pequeño",    .45, .45, 000, .50));
            tamaño.Add(new FilaTamaño("Grande",     .25, .70, .45, .70));
            tamaño.Add(new FilaTamaño("Utilitario", .30, .45, .70, 001));
            gridTamaño.DataSource = tamaño;
            tiempo.Add(new FilaTiempo( 60,  .50,     .50,   000,  .50));
            tiempo.Add(new FilaTiempo(120,  .30,     .80,   .50,  .80));
            tiempo.Add(new FilaTiempo(180,  .15,     .95,   .80,  .95));
            tiempo.Add(new FilaTiempo(240,  .05,     001,   .95,  001));
            gridTiempo.DataSource = tiempo;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                ActualizarTipo();
                ActualizarTiempo();
                Simular();
            }
            else
            {
                MessageBox.Show("Debe Ingresar todos los datos", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }

        private void ActualizarTipo()
        {
            double probabilidadTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < tamaño.Count; i++)
            {
                probabilidadTotal += tamaño[i].Probabilidad;
            }
            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La Probabilidad total debe dar 1","Probabilidad del Tipo Automovil",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                probabilidadAcumulada = 0;
                for (int i = 0; i < tamaño.Count; i++)
                {
                    probabilidadAcumulada += tamaño[i].Probabilidad;
                    tamaño[i].Acumulada = probabilidadAcumulada;
                    tamaño[i].Inferior = probabilidadInferior;
                    tamaño[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                gridTamaño.DataSource = tamaño;
                gridTamaño.Refresh();
            }
        }

        private void ActualizarTiempo()
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
                MessageBox.Show("La Probabilidad Total debe ser igual a 1","Probabilidad del Tiempo de Estacionamiento",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private double generarRandom()
        {
            double nro = Math.Round(random.NextDouble(), 2, MidpointRounding.AwayFromZero);
            if (nro == 1) nro = 0.99;
            return nro;
        }

        private bool Valido()
        {
            /*return String.IsNullOrEmpty(txtIndiceLlegada.Text) && String.IsNullOrEmpty(txtCantidadIteraciones.Text) && String.IsNullOrEmpty(txtMinutosFin.Text) &&
                String.IsNullOrEmpty(txtMinutosInicio.Text) && String.IsNullOrEmpty(txtTiempoDeCobro.Text);*/
            return txtIndiceLlegada.Text != "" && txtCantidadIteraciones.Text != "" && txtMinutosSimulacion.Text!= "" && txtMinutosDesde.Text!=""  && txtTiempoDeCobro.Text!="";
        }

        private void showErrorMessage(MaskedTextBox t)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingrese solo números enteros positivos","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }

        public int Rechazados(int i)
        {
            return i;
        }

        public void Simular()
        {
            Simulacion simulacion = new Simulacion(double.Parse(txtIndiceLlegada.Text), double.Parse(txtTiempoDeCobro.Text), tamaño, tiempo, int.Parse(cboCantidaCabinas.Text), double.Parse(txtMinutosSimulacion.Text), double.Parse(txtMinutosDesde.Text), Int64.Parse(txtCantidadIteraciones.Text));
            simulacion.simular();
        }
    }
}
