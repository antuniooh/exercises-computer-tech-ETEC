using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_LOP_0405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Numero = 1, Controle = 0; // Variaveis de Entrada - Inteiro

            Controle = int.Parse(textBox1.Text); // Entrada 1
            Impar.Items.Clear(); // Processo 1 - Limpa lista do Impar
            Par.Items.Clear(); // Processo 2 - Limpa lista do Par

            for (int i = 0; i < Controle * 2; i++) // Laco 1 - Para
            {
                if (Numero % 2 == 0) // Condição 1
                {
                    Par.Items.Add(Numero); // Processo 3 - Saida 1
                }
                else // Negação Condicional 1
                {
                    Impar.Items.Add(Numero); // Processo 4 - Saida 2
                }
                Numero++; // Processo 5
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = 1, Controle = 0; // Variaveis de Entrada - Inteira

            Controle = int.Parse(textBox1.Text); // Entrada 1

            Impar.Items.Clear(); // Processo 1
            Par.Items.Clear(); // Processo 2

            while (Numero <= Controle * 2) // Laço 1 - Enquanto
            {
                if (Numero % 2 == 0) // Condicional 1
                {
                    Par.Items.Add(Numero); // Processo 3 - Saida 1
                }
                else // Negação - Condicional 1
                {
                    Impar.Items.Add(Numero); // Processo 4 - Saida 2
                }
                Numero++; // Processo 5
            }
        }
    }
}
    