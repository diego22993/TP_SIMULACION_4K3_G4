using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_tp1
{
    public partial class GraficoNormal : Form
    {
        public GraficoNormal()
        {
            InitializeComponent();
        }
        
        private void btn_chi_Click(object sender, EventArgs e)
        {
            double suma = 0;
            double[] ks = new double[35] {0.975,0.842,0.708,0.624,0.565,0.521,0.486,0.457,0.432,0.410,0.391,0.375,0.361,0.349,0.338,0.328,0.318,0.309,0.301,0.294,0,0,0,0,0.27,0,0,0,0,0,0.24,0,0,0,0.23  };
            int cantidadIntervalos = dgv_graficoNormal.RowCount - 1;
            double[] chi = new double[37] { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };
            int gradosLibertad = cantidadIntervalos - 3;//
            
            for (int i = 0; i < dgv_graficoNormal.RowCount - 1; i++)
            {
                String a = dgv_graficoNormal.Rows[i].Cells[5].Value.ToString();
                suma += Convert.ToDouble(a);
            }
            if (suma <= chi[gradosLibertad - 1])
            {
                MessageBox.Show("Los resultados de la prueba Chi-Cuadrado son los siguientes:" + "\nNivel de confianza de 0,95" + "\nValorCritico: " + suma + "\nGrados de libertad: " + gradosLibertad + "\nValor prueba: " + chi[gradosLibertad - 1] + "\nLa prueba de chi-Cuadrado es aceptada!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los resultados de la prueba Chi-Cuadrado son los siguientes:" + "\nNivel de confianza de 0,95" + "\nValorCritico: " + suma + "\nGrados de libertad: " + gradosLibertad + "\nValor tabla: " + chi[gradosLibertad - 1] + "\nLa prueba de chi-Cuadrado es rechazada!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GraficoNormal_Load(object sender, EventArgs e)
        {

        }
    }
}
