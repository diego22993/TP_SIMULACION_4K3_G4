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
    public partial class Form1 : Form
    {
        private string tipo;
        private Generador generador;
        //private DataTable tabla;

        public Form1()
        {
            InitializeComponent();
            cmbIntervalo.Items.Add("10");
            cmbIntervalo.Items.Add("15");
            cmbIntervalo.Items.Add("20");
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
                List<NroRandom> lista = new List<NroRandom>();
                int x;
                int tamanio = int.Parse(txtTamanio.Text);

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

                grilla.DataSource = lista;// tabla;
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
    }
}
