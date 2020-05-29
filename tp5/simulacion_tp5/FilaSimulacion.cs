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
        private double rndTamañoAuto;
        private string tamaño;
        private double rndTiempoLlegada;
        private double tiempoLlegada;
        private double rndFinCobro;
        private double finCobro;
        private double recaudacion;

        public Double Minutos
        {
            get {return minutos; }
            set {minutos=value; }
        }
        public Double RndTamañoAuto
        {
            get { return RndTamañoAuto; }
            set { RndTamañoAuto = value; }
        }
        public String Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public Double RndTiempoLlegada
        {
            get { return rndTiempoLlegada; }
            set { rndTiempoLlegada = value; }
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
