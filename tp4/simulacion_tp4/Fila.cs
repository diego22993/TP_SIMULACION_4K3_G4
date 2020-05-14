using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp4
{
    class Fila
    {
        private int cantidad;
        private double probabilidad;
        private double acumulada;
        private double inferior;
        private double superior;

        public Fila(int cantidad, double probabilidad, double acumulada, double inferior, double superior)
        {
            this.cantidad = cantidad;
            this.probabilidad = probabilidad;
            this.acumulada = acumulada;
            this.inferior = inferior;
            this.superior = superior;
        }

        public int Cantidad
        { 
            get { return cantidad; } 
            set { cantidad = value; } 
        }
        public double Probabilidad
        {
            get { return probabilidad; }
            set { probabilidad = value; }
        }
        public double Acumulada
        {
            get { return acumulada; }
            set { acumulada = value; }
        }
        public double Inferior
        {
            get { return inferior; }
            set { inferior = value; }
        }
        public double Superior
        {
            get { return superior; }
            set { superior = value; }
        }

    }
}
