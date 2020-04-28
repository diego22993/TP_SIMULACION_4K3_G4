using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace simulacion_tp1
{
    public partial class GraficoPoisson : Form
    {
        public GraficoPoisson()
        {
            InitializeComponent();
        }

        private void GraficoPoisson_Load(object sender, EventArgs e)
        {

        }

        private void chartFrecuencias_Click(object sender, EventArgs e)
        {

        }

        private void btn_chi_Click(object sender, EventArgs e)
        {
            double[] chi = new double[37] { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };

            double suma = 0;
            int cantidadIntervalos = dgv_graficoPoisson.RowCount - 1;
            int gradosLibertad = cantidadIntervalos - 1;//para poisson
            for (int i = 0; i < dgv_graficoPoisson.RowCount - 1; i++)
            {
                String a = dgv_graficoPoisson.Rows[i].Cells[4].Value.ToString();
                suma += Convert.ToDouble(a);
            }
            if (suma <= chi[gradosLibertad - 1])
            {
                MessageBox.Show("Los resultados de la prueba chi cuadrado son los siguientes:" + "\nNivel de confianza de 0,95" + "\nValorCritico: " + suma + "\nGrados de libertad: " + gradosLibertad + "\nValor prueba: " + chi[gradosLibertad - 1] + "\nLa prueba de chi-Cuadrado es aceptada!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los resultados de la prueba chi cuadrado son los siguientes:" + "\nNivel de confianza de 0,95" + "\nValorCritico: " + suma + "\nGrados de libertad: " + gradosLibertad + "\nValor tabla: " + chi[gradosLibertad - 1] + "\nLa prueba de chi-Cuadrado es rechazada!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            dgv_graficoPoisson.Rows.Clear();
        }
    }
}
