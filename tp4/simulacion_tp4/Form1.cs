﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion_tp4
{
    public partial class Form1 : Form
    {
        List<Fila> demanda = new List<Fila>();
        List<Fila> entrega = new List<Fila>();
        List<Fila> daniada = new List<Fila>();

        FilaSimulacion filaX;
        FilaSimulacion filaY;
        List<FilaSimulacion> simulacion;

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            iniciarValores();
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            actualizarDemanda();
            actualizarEntrega();
            actualizarDaniada();

            simular();
        }

        private void iniciarValores()
        {
            demanda.Add(new Fila(0, .50, .50, 000, .50));
            demanda.Add(new Fila(1, .15, .65, .50, .65));
            demanda.Add(new Fila(2, .25, .90, .65, .90));
            demanda.Add(new Fila(3, .10, 001, .90, 001));
            gridDemanda.DataSource = demanda;

            entrega.Add(new Fila(1, .30, .30, 000, .30));
            entrega.Add(new Fila(2, .40, .70, .30, .70));
            entrega.Add(new Fila(3, .30, 001, .70, 001));
            gridEntrega.DataSource = entrega;

            daniada.Add(new Fila(0, .70, .70, 000, .70));
            daniada.Add(new Fila(1, .30, 001, .70, 001));
            gridDaniada.DataSource = daniada;

            txtKm.Text = "3";
            txtKo.Text = "20";
            txtKs.Text = "5";
            txtStockInicial.Text = "7";
            txtQ.Text = "6";
            txtR.Text = "2";

            txtSemanas.Text = "200";
            txtSemanaDesde.Text = "100";
            txtSemanaHasta.Text = "150";
        }

        private void actualizarDemanda()
        {
            double probabilidadTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < demanda.Count; i++)
            {
                probabilidadTotal += demanda[i].Probabilidad;
            }
            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La probabilidad total para la demanda debe ser 1.", "Error") ;
            }
            else
            {
                for (int i = 0; i < demanda.Count; i++)
                {
                    probabilidadAcumulada += demanda[i].Probabilidad;
                    demanda[i].Acumulada = probabilidadAcumulada;
                    demanda[i].Inferior = probabilidadInferior;
                    demanda[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                gridDemanda.DataSource = demanda;
                gridDemanda.Refresh();
            }
        }

        private void actualizarEntrega()
        {
            double probabilidadTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < entrega.Count; i++)
            {
                probabilidadTotal += entrega[i].Probabilidad;
            }
            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La probabilidad total para la entrega debe ser 1.", "Error");
            }
            else
            {
                for (int i = 0; i < entrega.Count; i++)
                {
                    probabilidadAcumulada += entrega[i].Probabilidad;
                    entrega[i].Acumulada = probabilidadAcumulada;
                    entrega[i].Inferior = probabilidadInferior;
                    entrega[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                gridEntrega.DataSource = entrega;
                gridEntrega.Refresh();
            }
        }

        private void actualizarDaniada()
        {
            double probabilidadTotal = 0;
            double probabilidadAcumulada = 0;
            double probabilidadInferior = 0;
            for (int i = 0; i < daniada.Count; i++)
            {
                probabilidadTotal += daniada[i].Probabilidad;
            }
            if (probabilidadTotal != 1)
            {
                MessageBox.Show("La probabilidad total para la dañada debe ser 1.", "Error");
            }
            else
            {
                for (int i = 0; i < daniada.Count; i++)
                {
                    probabilidadAcumulada += daniada[i].Probabilidad;
                    daniada[i].Acumulada = probabilidadAcumulada;
                    daniada[i].Inferior = probabilidadInferior;
                    daniada[i].Superior = probabilidadAcumulada;
                    probabilidadInferior = probabilidadAcumulada;
                }
                gridDaniada.DataSource = daniada;
                gridDaniada.Refresh();
            }
        }

        private void simular()
        {
            simulacion = new List<FilaSimulacion>();
            int llega = 0;
            int cantidadPedida = 0;
            int stockActual = int.Parse(txtStockInicial.Text);
            int totalAcumulado = 0;

            for (int i = 0; i < int.Parse(txtSemanas.Text); i+=2)
            {
                filaX = new FilaSimulacion();
                filaX.Semana = i + 1;
                if (filaX.Semana == llega) { stockActual += cantidadPedida; cantidadPedida = 0; }
                filaX.StockInicio = stockActual;
                filaX.RndDemanda = generarRandom();
                filaX.Demanda = buscarDemanda(filaX.RndDemanda);
                if (filaX.Demanda <= filaX.StockInicio) filaX.Venta = filaX.Demanda; else filaX.Venta = filaX.StockInicio;
                stockActual -= filaX.Venta;
                filaX.StockFin = stockActual;
                if (filaX.Demanda > filaX.Venta) filaX.Faltante = filaX.Demanda - filaX.Venta; else filaX.Faltante = 0;
                if (filaX.StockFin <= int.Parse(txtR.Text) && cantidadPedida == 0)
                {
                    filaX.RndPedido = generarRandom();
                    filaX.Semanas = buscarEntrega(filaX.RndPedido);
                    filaX.Llega = filaX.Semana + filaX.Semanas;
                    filaX.RndDaniada = generarRandom();
                    filaX.Daniada = buscarDaniada(filaX.RndDaniada);
                    if (filaX.Daniada == 0) filaX.Disponible = int.Parse(txtQ.Text); else filaX.Disponible = int.Parse(txtQ.Text) - 1;
                    llega = filaX.Llega;
                    cantidadPedida = filaX.Disponible;
                }
                filaX.Km = filaX.StockFin * int.Parse(txtKm.Text);
                filaX.Ks = filaX.Faltante * int.Parse(txtKs.Text);
                filaX.Ko = filaX.Disponible * int.Parse(txtKo.Text);
                filaX.Total = filaX.Km + filaX.Ks + filaX.Ko;
                totalAcumulado += filaX.Total;
                filaX.TotalAcumulado = totalAcumulado;
                if ((filaX.Semana >= int.Parse(txtSemanaDesde.Text) && filaX.Semana <= int.Parse(txtSemanaHasta.Text)) || i + 1 == int.Parse(txtSemanas.Text))
                {
                    simulacion.Add(filaX);
                }

                filaY = new FilaSimulacion();
                filaY.Semana = i + 2;
                if (filaY.Semana == llega) { stockActual += cantidadPedida; cantidadPedida = 0; }
                filaY.StockInicio = stockActual;
                filaY.RndDemanda = generarRandom();
                filaY.Demanda = buscarDemanda(filaY.RndDemanda);
                if (filaY.Demanda <= filaY.StockInicio) filaY.Venta = filaY.Demanda; else filaY.Venta = filaY.StockInicio;
                stockActual -= filaY.Venta;
                filaY.StockFin = stockActual;
                if (filaY.Demanda > filaY.Venta) filaY.Faltante = filaY.Demanda - filaY.Venta; else filaY.Faltante = 0;
                if (filaY.StockFin <= int.Parse(txtR.Text) && cantidadPedida == 0)
                {
                    filaY.RndPedido = generarRandom();
                    filaY.Semanas = buscarEntrega(filaY.RndPedido);
                    filaY.Llega = filaY.Semana + filaY.Semanas;
                    filaY.RndDaniada = generarRandom();
                    filaY.Daniada = buscarDaniada(filaY.RndDaniada);
                    if (filaY.Daniada == 0) filaY.Disponible = int.Parse(txtQ.Text); else filaY.Disponible = int.Parse(txtQ.Text) - 1;
                    llega = filaY.Llega;
                    cantidadPedida = filaY.Disponible;
                }
                filaY.Km = filaY.StockFin * int.Parse(txtKm.Text);
                filaY.Ks = filaY.Faltante * int.Parse(txtKs.Text);
                filaY.Ko = filaY.Disponible * int.Parse(txtKo.Text);
                filaY.Total = filaY.Km + filaY.Ks + filaY.Ko;
                totalAcumulado += filaY.Total;
                filaY.TotalAcumulado = totalAcumulado;
                if ((filaY.Semana >= int.Parse(txtSemanaDesde.Text) && filaY.Semana <= int.Parse(txtSemanaHasta.Text)) || i + 2 == int.Parse(txtSemanas.Text))
                {
                    simulacion.Add(filaY);
                }
            }
            gridSimulacion.DataSource = simulacion;
            ordenColumnas();
        }

        private double generarRandom()
        {
            double nro = Math.Round(random.NextDouble(), 2, MidpointRounding.AwayFromZero);
            if (nro == 1) nro = 0.99;
            return nro;
        }

        private int buscarDemanda(double rnd)
        {
            int retorno = 0;
            for (int i = 0; i < demanda.Count; i++)
            {
                if (rnd < demanda[i].Acumulada)
                {
                    retorno = demanda[i].Cantidad;
                    break;
                }
            }
            return retorno;
        }

        private int buscarDaniada(double rnd)
        {
            int retorno = 0;
            for (int i = 0; i < daniada.Count; i++)
            {
                if (rnd < daniada[i].Acumulada)
                {
                    retorno = daniada[i].Cantidad;
                    break;
                }
            }
            return retorno;
        }

        private int buscarEntrega(double rnd)
        {
            int retorno = 0;
            for (int i = 0; i < entrega.Count; i++)
            {
                if (rnd < entrega[i].Acumulada)
                {
                    retorno = entrega[i].Cantidad;
                    break;
                }
            }
            return retorno;
        }

        private void ordenColumnas()
        {
            gridSimulacion.Columns["semana"].DisplayIndex = 0;
            gridSimulacion.Columns["stockInicio"].DisplayIndex = 1;
            gridSimulacion.Columns["rndDemanda"].DisplayIndex = 2;
            gridSimulacion.Columns["demanda2"].DisplayIndex = 3;
            gridSimulacion.Columns["venta"].DisplayIndex = 4;
            gridSimulacion.Columns["stockFin"].DisplayIndex = 5;
            gridSimulacion.Columns["faltante"].DisplayIndex = 6;
            gridSimulacion.Columns["km"].DisplayIndex = 7;
            gridSimulacion.Columns["ks"].DisplayIndex = 8;
            gridSimulacion.Columns["ko"].DisplayIndex = 9;
            gridSimulacion.Columns["total"].DisplayIndex = 10;
            gridSimulacion.Columns["totalAcumulado"].DisplayIndex = 11;
            gridSimulacion.Columns["rndPedido"].DisplayIndex = 12;
            gridSimulacion.Columns["semanas"].DisplayIndex = 13;
            gridSimulacion.Columns["llega"].DisplayIndex = 14;
            gridSimulacion.Columns["rndDaniada"].DisplayIndex = 15;
            gridSimulacion.Columns["daniada2"].DisplayIndex = 16;
            gridSimulacion.Columns["disponible"].DisplayIndex = 17;
        }
    }
}
