using System;
using System.Collections;
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
        private double[] finEventos;
        private double finCobro;
        private List<FilaTiempo> finEstacionamiento;
        private List<FilaTamaño> tamanio;
        private int cantidadCabinas;
        private double tiempoSimular;
        private double tiempoDesde;
        private Int64 iteracion;
        private Int64 cantidadIteraciones;
        private Random rnd;
        private double reloj;
        private Cabina cabina01;
        private Cabina cabina02;

        DataTable tabla;
        DataRow filaActual;

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

            llegadaAutoMedia = Math.Round(1 / (indiceLlegada / 60), 2);
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
            finEventos = new double[23];
            for(int i = 0; i < finEventos.Length; i ++)
                finEventos[i] = 0;


        }

        public void simular()
        {
            cabina01 = new Cabina();
            double llegadaReloj;
            filaActual = tabla.NewRow();
            filaActual["Evento"] = "Inicio";
            filaActual["Reloj"] = reloj;
            double llegadaRnd = getRandom();
            double llegadaMinutos = getLlegadaMinutos(llegadaRnd);
            llegadaReloj = reloj + llegadaMinutos;
            filaActual["Llegada rnd."] = llegadaRnd;
            filaActual["Llegada minutos"] = llegadaMinutos;
            filaActual["Llegada reloj"] = llegadaReloj;
            actualizarEstados();
            if (tiempoDesde == 0) tabla.Rows.Add(filaActual);
           

            int evento = 0;
            for (double i = 0; i < 1000000; i++)
            {
                evento = compararTiempos();

                filaActual = tabla.NewRow();
                switch (evento)
                {
                    case 1:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 01";
                        break;
                    case 2:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 02";
                        break;
                    case 3:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 03";
                        break;
                    case 4:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 04";
                        break;
                    case 5:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 05";
                        break;
                    case 6:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 06";
                        break;
                    case 7:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 07";
                        break;
                    case 8:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 08";
                        break;
                    case 9:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 09";
                        break;
                    case 10:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 10";
                        break;
                    case 11:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 11";
                        break;
                    case 12:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 12";
                        break;
                    case 13:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 13";
                        break;
                    case 14:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 14";
                        break;
                    case 15:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 15";
                        break;
                    case 16:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 16";
                        break;
                    case 17:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 17";
                        break;
                    case 18:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 18";
                        break;
                    case 19:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 19";
                        break;
                    case 20:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin lugar 20";
                        break;
                    case 21:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Llegada vehículo";
                        llegadaVehiculo();
                        break;
                    case 22:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin cobro cabina 01";
                        break;
                    case 23:
                        reloj = finEventos[evento - 1];
                        filaActual["Evento"] = "Fin cobro cabina 02";
                        break;
                }
            }







            Form2 datos = new Form2();
            datos.cargarTabla(tabla);
            datos.Show();
        }

        private double getRandom()
        {
            double valor = 0;
            valor = Math.Round(rnd.NextDouble(), 2);
            if (valor == 1) valor = 0.99;
            return valor;
        }

        private double getLlegadaMinutos(double rnd)
        {
            return Math.Round(-llegadaAutoMedia * Math.Log(1 - rnd), 2);
        }

        private void actualizarEstados()
        {
            if (reloj >= tiempoDesde && iteracion <= cantidadIteraciones)
            {
                filaActual["Reloj"] = reloj;
                filaActual["Cabina 01 estado"] = cabina01.estado.ToString();
                //filaActual["Cabina 02 estado"] = cabina02.estado.ToString();


                //filaActual["Acum. Cant Consultas"] = cantidadConsultasAtendidas;
                //filaActual["Acum. Cant Urgencias"] = cantidadUrgenciasAtendidas;
                //filaActual["Max. Cola Consulta"] = colaMaximaConsulta;
                //filaActual["Max. Cola Urgencia"] = colaMaximaUrgencia;

                //filaActual["Cola Consultas"] = colaConsulta.Count;
                //filaActual["Cola Urgencias"] = colaUrgencia.Count;
            }
        }

        private int compararTiempos()
        {
            int evento = 0;
            double menorTiempo = 0;
            Boolean primero = true;
            for(int i = 0; i< finEventos.Length; i++)
            {
                if (finEventos[i] > 0 && primero)
                {
                    menorTiempo = finEventos[i];
                    evento = i + 1;
                    primero = false;
                }
                else
                {
                    if (finEventos[i] > 0 && finEventos[i] < menorTiempo);
                    menorTiempo = finEventos[i];
                    evento = i + 1;
                }
            }
            return evento;
        }

        private void llegadaVehiculo()
        {
            Auto a = new Auto();
            string tipo = "";
            double tamanioRnd = getRandom();

            for (int i = 0; i < tamanio.Count; i++)
            {
                if (tamanioRnd < tamanio[i].Acumulada)
                {
                    tipo = tamanio[i].Tamanio;
                    break;
                }
            }
            if (tipo == "Pequeño") a.tamanio = Auto.Tamanio.Pequño;
            if (tipo == "Grande") a.tamanio = Auto.Tamanio.Grande;
            if (tipo == "Utilitario") a.tamanio = Auto.Tamanio.Utilitario;


        }
    }
}
