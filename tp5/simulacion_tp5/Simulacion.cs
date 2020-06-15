using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp5
{
    class Simulacion
    {
        private double llegadaAutoMedia;
        private double finCobro;
        private List<FilaTiempo>  finEstacionamiento;
        private List<FilaTamaño>  tamanio;
        private int cantidadCabinas;
        private double tiempoSimular;
        private double tiempoDesde;
        private Int64 iteracion;
        private Int64 cantidadIteraciones;
        private Random rnd;
        private double reloj;

        DataTable tabla;

        public Simulacion(double indiceLlegada, double tiempoCobro, List<FilaTamaño> tamanioVehiculo, List<FilaTiempo> tiempoEstacionado, int cantidadCabinas, double tiempoSimular, double tiempoDesde, Int64 cantidadIteraciones)
        {
            tabla = new DataTable();

            tabla.Columns.Add("Evento", typeof(string));
            tabla.Columns.Add("Reloj", typeof(double));
            tabla.Columns.Add("Llegada rnd.", typeof(double));
            tabla.Columns.Add("Llegada minutos", typeof(double));
            tabla.Columns.Add("Llegada reloj", typeof(double));
            tabla.Columns.Add("Tamaño rnd.", typeof(double));
            tabla.Columns.Add("Tamaño vehículo", typeof(string));
            tabla.Columns.Add("Fin rnd.", typeof(double));
            tabla.Columns.Add("Fin minutos", typeof(double));
            tabla.Columns.Add("Lugar 01", typeof(double));
            tabla.Columns.Add("Lugar 02", typeof(double));
            tabla.Columns.Add("Lugar 03", typeof(double));
            tabla.Columns.Add("Lugar 04", typeof(double));
            tabla.Columns.Add("Lugar 05", typeof(double));
            tabla.Columns.Add("Lugar 06", typeof(double));
            tabla.Columns.Add("Lugar 07", typeof(double));
            tabla.Columns.Add("Lugar 08", typeof(double));
            tabla.Columns.Add("Lugar 09", typeof(double));
            tabla.Columns.Add("Lugar 10", typeof(double));
            tabla.Columns.Add("Lugar 11", typeof(double));
            tabla.Columns.Add("Lugar 12", typeof(double));
            tabla.Columns.Add("Lugar 13", typeof(double));
            tabla.Columns.Add("Lugar 14", typeof(double));
            tabla.Columns.Add("Lugar 15", typeof(double));
            tabla.Columns.Add("Lugar 16", typeof(double));
            tabla.Columns.Add("Lugar 17", typeof(double));
            tabla.Columns.Add("Lugar 18", typeof(double));
            tabla.Columns.Add("Lugar 19", typeof(double));
            tabla.Columns.Add("Lugar 20", typeof(double));
            tabla.Columns.Add("Lugares disponibles", typeof(int));
            tabla.Columns.Add("Cabina 01 estado", typeof(string));
            tabla.Columns.Add("Cabina 01 fin cobro", typeof(double));
            tabla.Columns.Add("Cabina 01 cola", typeof(int));
            tabla.Columns.Add("Cabina 02 estado", typeof(string));
            tabla.Columns.Add("Cabina 02 fin cobro", typeof(double));
            tabla.Columns.Add("Cabina 02 cola", typeof(int));
            tabla.Columns.Add("Racaudación cabina 01", typeof(double));
            tabla.Columns.Add("Racaudación cabina 02", typeof(double));
            tabla.Columns.Add("Aceptados", typeof(int));
            tabla.Columns.Add("Rechazados", typeof(int));
            tabla.Columns.Add("Ocupación auto", typeof(double));
            tabla.Columns.Add("Ocupación auot acumulado", typeof(double));
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());
            //tabla.Columns.Add("", typeof());

            llegadaAutoMedia = Math.Round(indiceLlegada / 60, 2);
            finCobro = tiempoCobro;
            tamanio = tamanioVehiculo;
            finEstacionamiento = tiempoEstacionado;
            this.cantidadCabinas = cantidadCabinas;
            this.tiempoSimular = tiempoSimular;
            this.tiempoDesde = tiempoDesde;
            this.cantidadIteraciones = cantidadIteraciones;
            iteracion = 0;
            reloj = 0;
            rnd = new Random();
        }

        public void simular()
        {


            Form2 datos = new Form2();
            datos.cargarTabla(tabla);
            datos.Show();
        }
    }
}
