using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class FilaSimulacion
    {
        private double minutos;
        private double rndLlegada;
        private double tiempoEntreLlegadas;
        private double proximaLlegada;
        private double rndTamanio;
        private string tamanio;
        private double rndTiempoServicio;
        private double tiempoServicio;
        private double recaudacion;

        public Double Minutos
        {
            get {return minutos; }
            set {minutos=value; }
        }
        public Double TiempoEntreLlegadas
        {
            get { return tiempoEntreLlegadas; }
            set { tiempoEntreLlegadas = value; }
        }
        public Double ProximaLlegada
        {
            get { return proximaLlegada; }
            set { proximaLlegada = value; }
        }
        public Double RndTamanio
        {
            get { return rndTamanio; }
            set { rndTamanio = value; }
        }
        public String Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }
        public Double RndTiempoServicio
        {
            get { return rndTiempoServicio; }
            set { rndTiempoServicio = value; }
        }
        public Double TiempoServicio
        {
            get { return tiempoServicio; }
            set { tiempoServicio = value; }
        }
        public Double Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }
    }
}
