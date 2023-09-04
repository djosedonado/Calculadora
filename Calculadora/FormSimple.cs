﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace Calculadora
{
    public partial class FormSimple : Form
    {
        public ValidacionCampos validacionCampos;
        public Calcular calcular;
        public FormSimple()
        {
            InitializeComponent();
            validacionCampos = new ValidacionCampos();
            calcular = new Calcular();
            CamposInicio();
        }
        private void CamposInicio()
        {
            textBoxTasaInteres.Text = "0";
            textBoxValorFinal.Text = "0";
            textBoxValorIncial.Text = "0";
            textBoxDias.Text = "0";
            textBoxAños.Text = "0";
            textBoxMeses.Text = "0";
        }
        private void labelValorIncial_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e,2);
        }

        private void textBoxValorIncial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            
            if (textBoxValorIncial.Text != "" && textBoxValorFinal.Text != "" && textBoxTasaInteres.Text != "" && textBoxDias.Text != "" && textBoxMeses.Text != "" && textBoxAños.Text != "")
            {
                calcular.dias = int.Parse(textBoxDias.Text);
                calcular.meses = int.Parse(textBoxMeses.Text);
                calcular.años = int.Parse(textBoxAños.Text);
                calcular.interes = double.Parse(textBoxTasaInteres.Text);
                calcular.ValorInicial = double.Parse(textBoxValorIncial.Text);
                calcular.ValorFinal = double.Parse(textBoxValorFinal.Text);
                labelValor.Visible = true;
                labelValor.Text = calcular.CalcularInteresSimple().ToString();
            }
            else
            {
                CamposInicio();
                MessageBox.Show("Debe llenar al menos un campo", "Alterta", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void textBoxDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }

        private void textBoxMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }

        private void textBoxAños_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }
    }
}
