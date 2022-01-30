using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public enum Operacion
    {
        NoDefinida=0,
        Suma=1,
        Resta=2,
        Division= 3,
        Multiplicacion = 4,
        Porciento = 5
    }
    public partial class Form1 : Form
    {
        Double valor1 = 0;
        Double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool NumeroLeido = false;
        public Form1()
        {
            InitializeComponent(); 
        }
        private  double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador) 
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        LbHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Porciento:
                    resultado = valor1 % valor2;
                    break;              
            }
            return resultado;
        }
        private void LeerNumero(string numero)
        {
            NumeroLeido = true;
            if (TxtResultado.Text == "0" && TxtResultado != null)
            {
                TxtResultado.Text = numero;
            }
            else
            {
                TxtResultado.Text += numero;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            NumeroLeido = true;
            if (TxtResultado.Text == "0")
            {
                return;
            }
            else
            {
                TxtResultado.Text += "0";
            }
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");

        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");

        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void Obtenervalor (String operador)
        {
            valor1 = Convert.ToDouble(TxtResultado.Text);
            LbHistorial.Text = TxtResultado.Text + operador;
            TxtResultado.Text = "0";
        }
        private void BtnSumar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            Obtenervalor("+");
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            Obtenervalor("-");
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            Obtenervalor("*");
        }

        private void BtnPorciento_Click(object sender, EventArgs e)
        {
            operador = Operacion.Porciento;
            Obtenervalor("%");
        }

        private void Btndivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            Obtenervalor("/");
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && NumeroLeido)
            {
                valor2 = Convert.ToDouble(TxtResultado.Text);
                LbHistorial.Text += valor2 +"=";
                double resultado = EjecutarOperacion ();
                valor1 = 0;
                valor2 = 0;
                NumeroLeido = false;
                TxtResultado.Text = Convert.ToString(resultado);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "0";
            LbHistorial.Text = "";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text.Length > 1)
            {
                string txtresultado = TxtResultado.Text;
                txtresultado = txtresultado.Substring(0, txtresultado.Length - 1);
                if (txtresultado.Length == 1 && txtresultado.Contains("-"))
                {
                    TxtResultado.Text = "0";
                }
                else
                {
                    TxtResultado.Text = txtresultado;
                }
            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text.Contains("."))
            {
                return;
            }
            TxtResultado.Text = ".";
        }
    }
}
