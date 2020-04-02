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
            txtA.Enabled = true;
            txtC.Enabled = true;
            txtM.Enabled = true;
            tipo = "lineal";
        }

        private void rbMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            txtX.Enabled = true;
            txtA.Enabled = true;
            txtC.Enabled = false;
            txtC.Text = "0";
            txtM.Enabled = true;
            tipo = "multiplicativo";
        }

        private void rbLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            txtX.Enabled = false;
            txtA.Enabled = false;
            txtC.Enabled = false;
            txtM.Enabled = false;
            tipo = "lenguaje";
        }

        private void limpiarCampos()
        {
            txtX.Text = "";
            txtA.Text = "";
            txtC.Text = "";
            txtM.Text = "";
            txtTamanio.Text = "";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<NroRandom> lista = new List<NroRandom>();
            int x;
            int tamanio = int.Parse(txtTamanio.Text);

            switch (tipo)
            {
                case "lineal":
                    generador = new Generador(int.Parse(txtA.Text), int.Parse(txtM.Text), int.Parse(txtC.Text));
                    x = int.Parse(txtX.Text);
                    lista = generador.linealLista(x, tamanio);
                    break;
                case "multiplicativo":
                    generador = new Generador(int.Parse(txtA.Text), int.Parse(txtM.Text), int.Parse(txtC.Text));
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
    }
}
