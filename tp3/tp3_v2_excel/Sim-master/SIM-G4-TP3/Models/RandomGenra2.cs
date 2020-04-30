﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SIM_G4_TP3.Models
{
    public class RandomGenra2
    {

        public RandomGenra2()
        {
        }

        public double[] GenerateCSharpRandoms(int semilla, uint cantidad)
        {
            var rnd = new Random(semilla);
            return new double[cantidad].Select(x => rnd.NextDouble().TruncateDouble(4)).ToArray();
        }

        public List<double[]> GenerateCSharpRandomsList(int semilla, uint cantidad)
        {
            var rnd = new Random(semilla);
            return new double[cantidad].Select(x => 
                new double[12]
                {
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4),
                    rnd.NextDouble().TruncateDouble(4)
                }            
            ).ToList();
        }

        public double[] GenerateUniformDistribution(uint a, uint b, double[] randoms)
        {
            return randoms.Select(x => (a + x * (b - a)).TruncateDouble(4)).ToArray();
        }

        public double[] GenerateExponentialDistribution(double lambda, double[] randoms)
        {
            return randoms.Select(x => ((Math.Log(1 - x)) / -lambda).TruncateDouble(4)).ToArray();
        }

        public double[] GenerateNormalDistribution(double media, double desviacion, List<double[]> randoms)
        {
            return randoms.Select(x => ((x.Sum() - 6) * desviacion) + media).ToArray();
        }

        public List<double[]>  GenerateUniformFrecuencies(uint cantIntervalos, double[] randoms)
        {
            var min = randoms.Min();
            var max = randoms.Max() + 0.01;
            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);
            var frecEsperada = Math.Round((double)(randoms.Length / cantIntervalos), 4);

            var a = new List<double[]>();

            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var interval_start = min + intervalRange * i;
                var interval_end = interval_start + intervalRange;
                var frec_obs = randoms.CantidadEnIntervalo(interval_start, interval_end);
                var c = Math.Round(Math.Pow(frec_obs - frecEsperada, 2) / frecEsperada, 4);
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            interval_start ,  //min intervalo
                            interval_end,   //max intervalo
                            frec_obs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

        public List<double[]>  GenerateExponentialFrecuencies(uint cantIntervalos,double lambda, double[] randoms)
        {
            var min = randoms.Min();
            var max = randoms.Max() + 0.01;
            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);

            var a = new List<double[]>();
            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var intervalStart = min + intervalRange * i;
                var intervalEnd = intervalStart + intervalRange;
                var frecObs = randoms.CantidadEnIntervalo(intervalStart, intervalEnd);
                var frecEsperada = (((1 - Math.Exp(-lambda * (intervalEnd))) - (1 - Math.Exp(-lambda * (intervalStart)))) * randoms.Length).TruncateDouble(4);
                var c = Math.Round(Math.Pow(frecObs - frecEsperada, 2) / frecEsperada, 4);
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            intervalStart ,  //min intervalo
                            intervalEnd,   //max intervalo
                            frecObs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

        public List<double[]>  GenerateNormalFrecuencies(uint cantIntervalos, double media, double desvEstandar, double[] randoms)
        {
            var min = randoms.Min();
            var max = randoms.Max() + 0.01;
            var intervalRange = Math.Round((max - min) / cantIntervalos, 4);


            var a = new List<double[]>();
            double calcEstAcum = 0;

            for (var i = 0; i < cantIntervalos; i++)
            {
                var intervalStart = min + intervalRange * i;
                var intervalEnd = intervalStart + intervalRange;
                var frecObs = randoms.CantidadEnIntervalo(intervalStart, intervalEnd);
                var frecEsperada =
                ((1 / (desvEstandar * Math.Sqrt(2 * Math.PI))) *
                 Math.Exp(-0.5 * (Math.Pow((((intervalEnd) + (intervalStart)) / 2 - media) / desvEstandar, 2))) *
                 randoms.Length).TruncateDouble(4);  
                var c = Math.Round(Math.Pow(frecObs - frecEsperada, 2) / frecEsperada, 4);
                calcEstAcum += c;
                a.Add(
                    new double[6]
                        {
                            intervalStart ,  //min intervalo
                            intervalEnd,   //max intervalo
                            frecObs,   //frec observada
                            frecEsperada,   //frec esperada
                            c,   // c
                            calcEstAcum  // c acum
                        }
                    );
            }

            return a;
        }

    }

    public static class Helpers
    {
        public static double TruncateDouble(this double value, double precision)
        {
            var val = Math.Pow(10, precision);
            return (Math.Truncate(val * value))/ val;
        }

        public static double CantidadEnIntervalo(this double[] values, double min, double max)
        {
            return values.Count(x => x >= min && x < max);
        }
    }
}
