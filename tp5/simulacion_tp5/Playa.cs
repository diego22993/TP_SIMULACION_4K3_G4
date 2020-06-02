using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class Playa
    {
        private String estado;
        private int[] lugaresDisponibles = new int[20];

        public Playa(String estado)
        {
            this.estado = estado;
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
