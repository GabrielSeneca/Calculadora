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
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplica obj3 = new Clases.ClsMultiplica();
        Clases.ClsDivide obj4 = new Clases.ClsDivide();

        private void btnCero_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
            
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txbScreen.Text);
            txbScreen.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txbScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    txbScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    txbScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    txbScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    txbScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length >= 1)
            {
                txbScreen.Text = txbScreen.Text.Substring(0, txbScreen.Text.Count() - 1);
            } 
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txbScreen.Text.Contains(","))
            {
                if (txbScreen.Text.Length < 1)
                {
                    txbScreen.Text += "0,";
                }
                else
                {
                    txbScreen.Text += ",";
                }

            }
        }
    }
}
