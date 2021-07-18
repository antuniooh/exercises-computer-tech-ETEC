using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06_lop2_160317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            int n1; // Variavel Entrada 01 - Inteiro
            int n2; // Variavel Entrada 02 - Inteiro
            int maior; // Variavel Saida 01 - Inteiro

            n1 = int.Parse(txt01.Text); // Entrada 1
            n2 = int.Parse(txt02.Text); // Entrada 2

            if (n1 > n2)
            {
                maior = n1; // processo 1
            }
            else // negação - condicional 1
            {
                maior = n2; //processo 2
            }
            lbl01.Text = maior.ToString(); // Saída 1
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn02_Click(object sender, EventArgs e)
        {
            double n1; //variavel de entrada 1 - real
            double n2; //variavel de entrada 2 - real
            double resultado; //variavel de saida 1 - real

            n1 = double.Parse(txt01.Text); // Entrada 1
            n2 = double.Parse(txt02.Text); // Entrada 2

            if (n1 > n2) // condicional 1
            {
                resultado = n1 / n2; // processo 1
            }
            else // negação - condicional 1
            {
                resultado = n2 / n1; // processo 2
            }
            lbl01.Text = resultado.ToString(); // Saida 1
        }
    }
}
