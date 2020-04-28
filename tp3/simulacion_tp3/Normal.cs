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
    public partial class Normal : Form
    {
        double[] numAleatorios;
        double[] numNormal;
        public Normal()
        {
            InitializeComponent();
        }
        

        public double pasarCantidad()
        {
            return double.Parse(txt_cantAGenerar.Text);
        }
        public void generarNormales(int cantidadNormales,double media,double desviacion)
        {
            double random;
            Random rnd = new Random();
            numNormal = new double[cantidadNormales];
            double sumatoria = 0;
            numAleatorios = new double[12];
            double z;
            int renglon = 0;
            for (int i = 0; i < cantidadNormales; i++)
            {

                for (int j=renglon; j <renglon+12; j++)
                {
                    
                    random = Math.Truncate(100*rnd.NextDouble())/100;
                    //numAleatorios[j] = random;
                    sumatoria += random;
                    dgv_normal.Rows.Add();
                    dgv_normal.Rows[j].Cells[1].Value = random;
                    
                }
                
                z = ((sumatoria - 6) * desviacion) + media;
                numNormal[i] = z;
                
                dgv_normal.Rows[renglon].Cells[0].Value = numNormal[i];
                //for (int u=0; u < numAleatorios.Length; u++)
                //{
                //    if (numAleatorios[u] != 0)
                //    {
                //        dgv_normal.Rows.Add();
                //        dgv_normal.Rows[u].Cells[1].Value = numAleatorios[u];
                //    }
                    
                //}


                renglon += 12;
                sumatoria = 0;
            }
        }

        public DataGridView generarGridGrafico(GraficoNormal g)
        {
            double max = 0;
            for (int i = 0; i < numNormal.Length; i++)
            {
                if (max < numNormal[i])
                {
                    max = numNormal[i];
                }
            }
            double min = max;

            for (int i = 0; i < numNormal.Length; i++)
            {
                if (numNormal[i] < min)
                {
                    min = numNormal[i];
                }
            }

            double rango = ((max - min) / double.Parse(txt_cantIntervalos.Text));
            double limteInferior = min;
            double limteSuperior = limteInferior + rango;
            int contadorFrecuencia = 0;
            int contInterv = 0;
            double sum = 0;
            double frecEsperada;
            double probEsperada;
            double poAcum = 0;
            double peAcum = 0;
            while (limteSuperior <= max)
            {
                for (int i = 0; i < numNormal.Length; i++)
                {
                    double numero = numNormal[i];
                    if ((numero >= limteInferior && numero < limteSuperior) || (numero == max && limteSuperior == max))
                    {

                        contadorFrecuencia++;
                    }

                }

                g.dgv_graficoNormal.Rows.Add();
                g.dgv_graficoNormal.Rows[contInterv].Cells[0].Value = limteInferior;
                g.dgv_graficoNormal.Rows[contInterv].Cells[1].Value = limteSuperior;
                g.dgv_graficoNormal.Rows[contInterv].Cells[2].Value = contadorFrecuencia;
                double marcaClase = (limteSuperior + limteInferior) / 2;
                double primero = (marcaClase - double.Parse(txt_media.Text)) / double.Parse(txt_desviacion.Text);
                double segundo = double.Parse(txt_desviacion.Text) * (Math.Sqrt(Math.PI * 2));
                double cuad1 = Math.Pow(primero, 2);
                double calculo1 = Math.Pow(Math.E, -0.5*cuad1);
                double res = calculo1 / segundo;
                probEsperada = res;
               
                frecEsperada = probEsperada * int.Parse(txt_cantAGenerar.Text);
                g.dgv_graficoNormal.Rows[contInterv].Cells[3].Value = frecEsperada;
                g.dgv_graficoNormal.Rows[contInterv].Cells[4].Value =probEsperada ;
                g.dgv_graficoNormal.Rows[contInterv].Cells[5].Value = Math.Pow(contadorFrecuencia - frecEsperada, 2) / frecEsperada;
               
                contInterv++;
                contadorFrecuencia = 0;
                limteInferior = limteSuperior;
                limteSuperior = limteInferior + rango;
            }
            return g.dgv_graficoNormal;
        }

        private void btn_generarNormal_Click(object sender, EventArgs e)
        {
            generarNormales(int.Parse(txt_cantAGenerar.Text), double.Parse(txt_media.Text), double.Parse(txt_desviacion.Text));
        }


        private void btn_graficar_Click(object sender, EventArgs e)
        {
            GraficoNormal  g = new GraficoNormal();

            g.dgv_graficoNormal = generarGridGrafico(g);

            for (int i = 0; i < g.dgv_graficoNormal.RowCount - 1; i++)
            {
                string nombre = g.dgv_graficoNormal.Rows[i].Cells[0].Value.ToString() + "-" + g.dgv_graficoNormal.Rows[i].Cells[1].Value.ToString();
                g.ch_normal.Series["Series1"].Points.AddXY(nombre, double.Parse(g.dgv_graficoNormal.Rows[i].Cells[2].Value.ToString()));
                g.ch_normal.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            }


            g.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantAGenerar.Text = "";
            txt_cantIntervalos.Text = "";
            txt_desviacion.Text = "";
            txt_media.Text = "";
            dgv_normal.Rows.Clear();
        }
    }
}
