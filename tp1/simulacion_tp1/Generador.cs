using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_tp1
{
    class Generador
    {
        private int k;
        private int g;
        private int c;
        private Random random = new Random();

        public Generador()
        {
            
        }

        public Generador(int k, int g, int c)
        {
            this.k = k;
            this.g = g;
            this.c = c;
        }

        public NroRandom lineal(int x)
        {
            int a = 1 + (4 * k);
            double m = Math.Pow(2, g);
            int xi = Convert.ToInt32((a * x + c) % m);
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi, m));
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
            int a = 3 + (8 * k);
            double m = Math.Pow(2, g);
            int xi = Convert.ToInt32((a * x) % m);
            NroRandom nroRnd = new NroRandom(x, xi, dividir(xi, m));
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

        private double dividir(int nro, double m)
        {
            double resultado = (double) nro / m; // se borra el m - 1 para no incluirlo en la lista de randoms 
            return Math.Round(resultado, 4, MidpointRounding.AwayFromZero);
        }
    }
}
