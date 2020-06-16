using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class Auto
    {
        private String estado; /* Estacionado (E) | Esperando Atencion Cabina (EAC) | Siendo Atendido Cabina (SAC) */
        private int lugar;
        private String tamanio;
        private double hsIngreso;

        public Auto(String estado, int lugar, string tamanio, double hsIngreso)
        {
            this.estado = estado;
            this.lugar = lugar;
            this.tamanio = tamanio;
            this.hsIngreso = hsIngreso;
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public String Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }
        public Double HsIngreso
        {
            get { return hsIngreso; }
            set { hsIngreso = value; }
        }
    }
}
