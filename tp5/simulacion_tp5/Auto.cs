using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    public class Auto
    {

        /*private String estado;
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
         }*/

        public enum Estado { Estacionado, SiendoAtendido, EsperandoAtencion };
        public enum Tamanio { Pequño, Grande, Utilitario };

        public Estado estado { get; set; }
        public int lugar { get; set; }
        public Tamanio tamanio { get; set; }
        public double horaIngreso { get; set; }

        public static int num;
        public int numero;

        public Auto()
        {
            this.numero = Interlocked.Increment(ref num);
        }
    }
}
