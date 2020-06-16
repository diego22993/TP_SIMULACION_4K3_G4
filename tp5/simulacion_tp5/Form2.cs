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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void cargarTabla(DataTable tabla)
        {
            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.Refresh();
        }
    }
}
