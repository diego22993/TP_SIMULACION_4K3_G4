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
        List<FilaSimulacion> Simulacion;
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
            cboCantCajas.Items.Add("1");
            cboCantCajas.Items.Add("2");

            tamaño.Add(new FilaTamaño("Pequeño", .45, .45, 000, .50));
            tamaño.Add(new FilaTamaño("Grande", .25, .70, .45, .70));
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
            ActualizarTipo();
            ActualizarTiempo();
            
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
            probabilidadAcumulada = probabilidadTotal;

            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La Probabilidad total debe dar 1","Probabilidad del Tipo Automovil",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
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
            if (probabilidadAcumuladaTotal!=1)
            {
                MessageBox.Show("La Probabilidad Total debe ser igual a 1","Probabilidad del Tiempo de Estacionamiento",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < tiempo.Count; i++)
                {
                    probabilidadAcumulada += tiempo[i].Probabilidad;
                    tiempo[i].Acumulada = probabilidadAcumulada;
                    tiempo[i].Inferior = probabilidadInferior;
                    tiempo[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
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

        

    }
}
