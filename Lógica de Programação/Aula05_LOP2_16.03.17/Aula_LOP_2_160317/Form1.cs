using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_LOP_2_160317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnex08_Click(object sender, EventArgs e)
        {
            int numero; // Variável de Entrada - Inteira

            numero = int.Parse(txtn1.Text);//Entrada 1

            if (numero > 100) //entrada 1
            { // abre escopo
                lblresultado.Text = numero.ToString(); // saida 1
            } // fecha escopo
        }

        private void btnex01_Click(object sender, EventArgs e)
        {
            int n1; //variavel de entrada - inteiro

            n1 = int.Parse(txtn1.Text); // entrada 1

            if (n1 > 50 && n1 < 90)
            {
                lblresultado.Text = n1.ToString(); //saída 1
            }
        }

        private void btnex02_Click(object sender, EventArgs e)
        {
            int n1; // Variavel de entrada - Inteiro

            n1 = int.Parse(txtn1.Text); // entrada 1

            if (n1 < 20 || n1 >= 80)
            {
                lblresultado.Text = n1.ToString(); // Saida 1
            }
        }
    }
}
