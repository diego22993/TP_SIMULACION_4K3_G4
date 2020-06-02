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
        private double rndTamanio;
        private string tamanio;
        private double rndLlegada;
        private double tiempoLlegada;
        private double rndFinCobro;
        private double finCobro;
        private double recaudacion;

        public Double Minutos
        {
            get {return minutos; }
            set {minutos=value; }
        }
        public Double RndTamanio
        {
            get { return RndTamanio; }
            set { RndTamanio = value; }
        }
        public String Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }
        public Double RndTiempoLlegada
        {
            get { return rndLlegada; }
            set { rndLlegada = value; }
        }
        public Double TiempoLlegada
        {
            get { return tiempoLlegada; }
            set { tiempoLlegada = value; }
        }
        public Double RndFinCobro
        {
            get { return RndFinCobro; }
            set { RndFinCobro = value; }
        }
        public Double FinCobro
        {
            get { return finCobro; }
            set { finCobro = value; }
        }
        public Double Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }
    }
}
