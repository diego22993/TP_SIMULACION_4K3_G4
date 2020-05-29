using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class FilaTamaño
    {
        private string tamaño;
        private double probabilidad;
        private double acumulada;
        private double inferior;
        private double superior;

        public FilaTamaño(string tamaño, double probabilidad, double acumulada, double inferior, double superior)
        {
            this.tamaño = tamaño;
            this.probabilidad = probabilidad;
            this.acumulada = acumulada;
            this.inferior = inferior;
            this.superior = superior;
        }

        public String Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
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
