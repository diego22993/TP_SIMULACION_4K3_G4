using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class FilaTiempo
    {
        private int horas;
        private double probabilidad;
        private double acumulada;
        private double inferior;
        private double superior;

        public FilaTiempo(int horas, double probabilidad, double acumulada, double inferior, double superior)
        {
            this.horas = horas;
            this.probabilidad = probabilidad;
            this.acumulada = acumulada;
            this.inferior = inferior;
            this.superior = superior;
        }

        public int Cantidad
        {
            get {return horas; }
            set {horas=value; }
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
