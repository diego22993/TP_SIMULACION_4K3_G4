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
        List<FilaTipo> tipo = new List<FilaTipo>();
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

            tiempo.Add(new FilaTiempo(1,  .50,     .50,   000,  .50));
            tiempo.Add(new FilaTiempo(2,  .30,     .80,   .50,  .80));
            tiempo.Add(new FilaTiempo(3,  .15,     .95,   .80,  .95));
            tiempo.Add(new FilaTiempo(4,  .05,     001,   .95,  001));
            gridTiempo.DataSource = tiempo;

            tipo.Add(new FilaTipo("Pequeños",   .45,    .45,    000,   .50));
            tipo.Add(new FilaTipo("Grandes",    .25,    .70,    .45,   .70));
            tipo.Add(new FilaTipo("Utilitarios",.30,    .45,    .70,   001));
            gridTipo.DataSource = tipo;

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
            for (int i = 0; i < tipo.Count; i++)
            {
                probabilidadTotal += tipo[i].Probabilidad;
            }
            probabilidadAcumulada = probabilidadTotal;

            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La Probabilidad total debe dar 1","Probabilidad del Tipo Automovil",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < tipo.Count; i++)
                {
                    probabilidadAcumulada += tipo[i].Probabilidad;
                    tipo[i].Acumulada = probabilidadAcumulada;
                    tipo[i].Inferior = probabilidadInferior;
                    tipo[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                gridTipo.DataSource = tipo;
                gridTipo.Refresh();
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
                    probabilidadAcumulada += tipo[i].Probabilidad;
                    tipo[i].Acumulada = probabilidadAcumulada;
                    tipo[i].Inferior = probabilidadInferior;
                    tipo[i].Superior = probabilidadAcumulada;
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
