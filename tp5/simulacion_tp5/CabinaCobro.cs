using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class CabinaCobro
    {
        private String estado; /* Libre (L) | Ocupada (O) */
        private int cola;
        private float recAcumulado;

        public CabinaCobro(String estado, int cola,float recAcumulado)
        {
            this.estado = estado;
            this.cola = cola;
            this.recAcumulado = recAcumulado;
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Cola
        {
            get { return cola; }
            set { cola = value; }
        }
        public float RecAcumulado
        {
            get { return recAcumulado; }
            set { recAcumulado = value; }
        }
    }
}
