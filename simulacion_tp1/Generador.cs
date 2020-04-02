using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp1
{
    class Generador
    {
        private int a;
        private int m;
        private int c;
        private Random random = new Random();

        public Generador()
        {
            
        }

        public Generador(int a, int m, int c)
        {
            this.a = a;
            this.m = m;
            this.c = c;
        }

        public NroRandom lineal(int x)
        {
            int xi = (a * x + c) % m;
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi));
            return nroRnd;
        }

        public List<NroRandom> linealLista(int semilla, int cantidadGenerar)
        {
            List<NroRandom> lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = lineal(semilla);
                nroRandom.Posicion = i + 1;
                lista.Add(nroRandom);
                semilla = nroRandom.Siguiente;
            }
            return lista;
        }

        public NroRandom multiplicativo(int x)
        {
            int xi = (a * x) % m;
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi));
            return nroRnd;
        }

        public List<NroRandom> multiplicativoLista(int semilla, int cantidadGenerar)
        {
            List<NroRandom> lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = multiplicativo(semilla);
                nroRandom.Posicion = i + 1;
                lista.Add(nroRandom);
                semilla = nroRandom.Siguiente;
            }
            return lista;
        }

        public NroRandom lenguaje()
        {
            //Random random = new Random();
            double nro = Math.Round(random.NextDouble(), 4, MidpointRounding.AwayFromZero);
            NroRandom nroRnd = new NroRandom(0, 0, nro);
            return nroRnd;
        }

        public List<NroRandom> lenguajeLista(int cantidadGenerar)
        {
            List<NroRandom> lista = new List<NroRandom>();
            NroRandom nroRandom;
            for (int i = 0; i < cantidadGenerar; i++)
            {
                nroRandom = lenguaje();
                nroRandom.Posicion = i + 1;
                double nro = nroRandom.Random;
                lista.Add(nroRandom);
            }
            return lista;
        }

        private double dividir(int nro)
        {
            double resultado = (double) nro / (m - 1);
            return Math.Round(resultado, 4, MidpointRounding.AwayFromZero);
        }
    }
}
