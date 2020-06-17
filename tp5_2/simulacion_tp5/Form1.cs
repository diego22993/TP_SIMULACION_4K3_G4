using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //
        }



    }
}
