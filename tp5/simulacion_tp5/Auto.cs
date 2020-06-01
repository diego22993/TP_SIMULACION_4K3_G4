using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class Auto
    {
        private String estado;
        private int lugar;
        private String tamaño;
        private double hsIngreso;

        public Auto(String estado, int lugar, string tamaño, double hsIngreso)
        {
            this.estado = estado;
            this.lugar = lugar;
            this.tamaño = tamaño;
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
        public String Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public Double HsIngreso
        {
            get { return hsIngreso; }
            set { hsIngreso = value; }
        }
    }
}
