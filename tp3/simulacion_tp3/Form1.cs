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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_uniforme_Click_1(object sender, EventArgs e)
        {
            //Uniforme uni = new Uniforme();
            //uni.Show();
        }

        private void btn_exponencial_Click_1(object sender, EventArgs e)
        {
            Exponencial exp = new Exponencial();
            exp.Show();
        }

        private void btn_normal_Click_1(object sender, EventArgs e)
        {
            Normal n = new Normal();
            n.Show();
        }
    }
}
