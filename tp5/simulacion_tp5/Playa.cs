using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class Playa
    {
        private String estado; /* Libre (L) | Ocupada (O) */
        private int lugaresDisponibles; /* 20 lugares */

        public Playa(String estado, int lugaresDisponibles)
        {
            this.estado = estado;
            this.lugaresDisponibles = lugaresDisponibles;
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void IsFree()
        {
            int acum=0;
            for (int i = 0; i < lugaresDisponibles; i++)
            {
                acum += i;
            }

        }
    }
}
