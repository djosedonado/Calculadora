﻿using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormTir : Form
    {
        public readonly Tir tir;
        public FormTir()
        {
            InitializeComponent();
            ValorInicial();
            tir = new Tir();
        }
        private void ValorInicial()
        {
            textBoxCapitalInicial.Text = 0.ToString();
            textBoxFnc1.Text = 0.ToString();
            textBoxFnc2.Text = 0.ToString();
            textBoxTasa.Text = 0.ToString();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            tir.inicial = double.Parse(textBoxCapitalInicial.Text);
            tir.periodo1 = double.Parse(textBoxFnc1.Text);
            tir.periodo2 = double.Parse(textBoxFnc2.Text);
            tir.tasa = double.Parse(textBoxTasa.Text);
            labelResultado.Text = tir.vanPorcentaje();
            labelResultadoPresente.Text = tir.calcularValorFuturo();
            labelResultadoTir.Text = tir.calacularTir();
            labelVanInteresCompuesto.Text = tir.calcularVanInicial();
        }
    }
}
