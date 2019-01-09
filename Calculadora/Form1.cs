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
    public partial class Form1 : Form
    {
        /* Declaración de variables */
        double operando1 = 0;
        double operando2 = 0;

        String operacion = "";

        bool coma = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numeroPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }

            else
            {
                label1.Text += boton.Text;
            }
        }

        private void comaPulsada(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "," && !coma)
            {
                coma = true;
                label1.Text += boton.Text;
            }
        }

        private void igualPulsado(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;

                case "-":
                    resultado = operando1 - operando2;
                    break;

                case "X":
                    resultado = operando1 - operando2;
                    break;

                case "/":
                    resultado = operando1 - operando2;
                    break;

                default:
                    break;
            }

            label1.Text = Convert.ToString(resultado);
        }

        private void masPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }
    }
}
