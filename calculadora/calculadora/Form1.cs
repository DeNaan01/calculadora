using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int resultadoSoma(int num1, int num2)
        {
            int resultado = 0;
            resultado = num1 + num2;
            return resultado;

        }

        public int calculos(int num1, int num2, string operador) 
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;

            }
            else if (operador == "X")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/" )
            {
                resultado = num1 / num2;
            }

            return resultado;

        }
        private void btnmais_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = int.Parse(txbnumero2.Text);

            Button botao = (Button)sender;
            string operadorselecionado = botao.Text;



            int total;
            total = calculos(numero1, numero2, operadorselecionado);
            lbresultado.Text = "O resultado é " + total.ToString();
        }

    }
}
