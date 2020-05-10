using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp4
{
    class FilaSimulacion
    {
        private int semana;
        private int stockInicio;
        private double rndDemanda;
        private int demanda;
        private int venta;
        private int stockFin;
        private int faltante;
        private int km;
        private int ks;
        private int ko;
        private int total;
        private int totalAcumulado;
        private double rndDaniada;
        private int daniada;
        private double rndPedido;
        private int semanas;
        private int llega;
        private int disponible;

        public int Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public int Llega
        {
            get { return llega; }
            set { llega = value; }
        }

        public int Semanas
        {
            get { return semanas; }
            set { semanas = value; }
        }

        public double RndPedido
        {
            get { return rndPedido; }
            set { rndPedido = value; }
        }

        public int Daniada
        {
            get { return daniada; }
            set { daniada = value; }
        }

        public double RndDaniada
        {
            get { return rndDaniada; }
            set { rndDaniada = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public int TotalAcumulado
        {
            get { return totalAcumulado; }
            set { totalAcumulado = value; }
        }

        public int Ko
        {
            get { return ko; }
            set { ko = value; }
        }

        public int Ks
        {
            get { return ks; }
            set { ks = value; }
        }

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public int Faltante
        {
            get { return faltante; }
            set { faltante = value; }
        }


        public int StockFin
        {
            get { return stockFin; }
            set { stockFin = value; }
        }

        public int Venta
        {
            get { return venta; }
            set { venta = value; }
        }

        public int Demanda
        {
            get { return demanda; }
            set { demanda = value; }
        }

        public double RndDemanda
        {
            get { return rndDemanda; }
            set { rndDemanda = value; }
        }

        public int StockInicio
        {
            get { return stockInicio; }
            set { stockInicio = value; }
        }

        public int Semana
        {
            get { return semana; }
            set { semana = value; }
        }

    }

    

}
