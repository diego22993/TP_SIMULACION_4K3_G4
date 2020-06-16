using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    class Cabina
    {
        public enum Estado { Libre, Ocupada };
        
        public Estado estado { get; set; }
        public Auto autoPagando { get; set; }

        public Cabina()
        {
            this.estado = Estado.Libre;
        }
    }
}
