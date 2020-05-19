using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class FilaSimulacion
    {
        private double hora;
        private double rndTipoAuto;
        private string tipo;
        private double rndTiempoLlegada;
        private double tiempoLlegada;
        private double rndFinCobro;
        private double finCobro;
        private double recaudacion;

        public Double Hora
        {
            get {return hora; }
            set {hora=value; }
        }
        public Double RndTipoAuto
        {
            get { return RndTipoAuto; }
            set { RndTipoAuto = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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
