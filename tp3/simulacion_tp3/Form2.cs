﻿using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        private string tipo;
        private Generador generador;
        List<NroRandom> lista = new List<NroRandom>();
        int tamanio;
        List<Intervalo> intervalos;

        public Form2()
        {
            InitializeComponent();
            cmbIntervalo.Items.Add("10");
            cmbIntervalo.Items.Add("15");
            cmbIntervalo.Items.Add("20");
            chrGrafico.Titles.Add("Histograma de Frecuencias");
            chrGrafico.ChartAreas[0].AxisX.Title = "Intervalos";
            chrGrafico.ChartAreas[0].AxisY.Title = "Números Random";
            chrGrafico.Series[0].LegendText = "Fo";
            chrGrafico.Series[1].LegendText = "Fe";
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            txtX.Enabled = true;
            txtK.Enabled = true;
            txtC.Enabled = true;
            txtG.Enabled = true;
            tipo = "lineal";
        }

        private void rbMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            txtX.Enabled = true;
            txtK.Enabled = true;
            txtC.Enabled = false;
            txtC.Text = "0";
            txtG.Enabled = true;
            tipo = "multiplicativo";
        }

        private void rbLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            txtX.Text = "0";
            txtK.Text = "0";
            txtC.Text = "0";
            txtG.Text = "0";
            txtX.Enabled = false;
            txtK.Enabled = false;
            txtC.Enabled = false;
            txtG.Enabled = false;
            tipo = "lenguaje";
        }

        private void limpiarCampos()
        {
            txtX.Text = "";
            txtK.Text = "";
            txtC.Text = "";
            txtG.Text = "";
            txtTamanio.Text = "";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int x;
                tamanio = int.Parse(txtTamanio.Text);

                switch (tipo)
                {
                    case "lineal":
                        generador = new Generador(int.Parse(txtK.Text), int.Parse(txtG.Text), int.Parse(txtC.Text));
                        x = int.Parse(txtX.Text);
                        lista = generador.linealLista(x, tamanio);
                        break;
                    case "multiplicativo":
                        generador = new Generador(int.Parse(txtK.Text), int.Parse(txtG.Text), int.Parse(txtC.Text));
                        x = int.Parse(txtX.Text);
                        lista = generador.multiplicativoLista(x, tamanio);
                        break;
                    case "lenguaje":
                        generador = new Generador();
                        lista = generador.lenguajeLista(tamanio);
                        break;
                }

                grilla.DataSource = lista;
            }
            else {
                MessageBox.Show("Todos los campos son obligatorios");
            }
          
        }

        private bool isValid() {
            return txtX.Text != "" && txtK.Text != "" &&  txtC.Text != "" && txtG.Text != "" && txtTamanio.Text != "";
        }
 
        private void txtK_TextChanged(object sender, EventArgs e)
        {
            showErrorMessage(txtK);
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            showErrorMessage(txtG);
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            showErrorMessage(txtC);
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            showErrorMessage(txtX);
        }

        private void showErrorMessage(TextBox textbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingrese solo números enteros.");
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            }
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            int cantIntervalos = 0;
            bool hayError = false;
            double caAcumulado = 0;
            try
            {
                cantIntervalos = int.Parse(cmbIntervalo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el tamaño del intervalo.");
                hayError = true;
            }
            if (!hayError)
            {
                double ancho = (double)1 / cantIntervalos;
                ancho = Math.Round(ancho, 4, MidpointRounding.AwayFromZero);
                intervalos = new List<Intervalo>();
                double inf = 0;
                double sup = 0;
                for (int i = 0; i < cantIntervalos; i++)
                {
                    if (i != cantIntervalos - 1) sup = Math.Round(sup + ancho, 4, MidpointRounding.AwayFromZero);
                    else sup = 1;
                    intervalos.Add(new Intervalo(inf, sup));
                    inf = Math.Round(inf + ancho, 4, MidpointRounding.AwayFromZero);
                }

                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < intervalos.Count; j++)
                    {
                        if (intervalos[j].Inf <= lista[i].Random && lista[i].Random < intervalos[j].Sup)
                        {
                            intervalos[j].Fo++;
                            break;
                        }
                    }
                }
                for (int i = 0; i < intervalos.Count; i++)
                {
                    intervalos[i].Fe = tamanio / cantIntervalos;
                    intervalos[i].calcularC();
                    caAcumulado += intervalos[i].C;
                    intervalos[i].Ca = Math.Round(caAcumulado, 2, MidpointRounding.AwayFromZero);
                }
                dgvTablaFecuencia.DataSource = intervalos;
                generarGrafico();
            }
        }

        private void generarGrafico()
        {
            ArrayList serieFo = new ArrayList();
            ArrayList serieFe = new ArrayList();
            ArrayList fo = new ArrayList();
            ArrayList fe = new ArrayList();

            for (int i = 0; i < intervalos.Count; i++)
            {
                serieFo.Add(intervalos[i].Inf.ToString());// + "-" + intervalos[i].Sup.ToString());
                fo.Add(intervalos[i].Fo);
                serieFe.Add(intervalos[i].Inf.ToString() + "-" + intervalos[i].Sup.ToString());
                fe.Add(intervalos[i].Fe);
            }
            chrGrafico.Series[0].Points.DataBindY(fo);
            chrGrafico.Series[1].Points.DataBindXY(serieFe, fe);
        }

    }
}
