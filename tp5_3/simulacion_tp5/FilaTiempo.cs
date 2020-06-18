using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    class FilaTiempo
    {
        private int minutos;
        private double probabilidad;
        private double acumulada;
        private double inferior;
        private double superior;

        public FilaTiempo(int minutos, double probabilidad, double acumulada, double inferior, double superior)
        {
            this.minutos = minutos;
            this.probabilidad = probabilidad;
            this.acumulada = acumulada;
            this.inferior = inferior;
            this.superior = superior;
        }

        public int Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }
        public Double Probabilidad
        {
            get { return probabilidad; }
            set { probabilidad = value; }
        }
        public Double Acumulada
        {
            get { return acumulada; }
            set { acumulada = value; }
        }
        public Double Inferior
        {
            get { return inferior; }
            set { inferior = value; }
        }
        public Double Superior
        {
            get { return superior; }
            set { superior = value; }
        }
    }
}
