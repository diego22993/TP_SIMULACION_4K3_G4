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
    public partial class Exponencial : Form
    {

        public Exponencial()
        {
            InitializeComponent();
        }

        public void GenerarListadoNumerosAleatorios(int cant,int lam)
        {
            Random rnd = new Random();

            for (int i = 0; i < cant; i++)
            {
                double r = Math.Round(rnd.NextDouble(), MidpointRounding.AwayFromZero);
            }
            dgvListadoExp.Rows.Add();
            dgvListadoExp.Rows[i].Cells[0].Value = rnd;
        }

    }
}
