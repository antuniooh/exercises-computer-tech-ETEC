using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex19_LOP_Loop_27042017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ex19_LOP_Loop_270417_Load(object sender, EventArgs e)
        {

        }

        private void btnEnquanto_Click(object sender, EventArgs e)
        {
            int controle;
            controle = int.Parse(txtControle.Text); // Entrada 1

            Lista.Items.Clear(); // Processo
            int contador = 0; // Variavel de Entrada
            while (contador < 1000) // Laço1 - Enquanto
            {

                contador ++; // Processo 2 
                Lista.Items.Add(contador); // Processo 1
                if (contador == controle) // Condicional 1
                {
                    break; // Fix Equanto
                }
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            int controle;
            controle = int.Parse(txtControle.Text); // Entrada 1
            
            Lista.Items.Clear(); // Processo

            for (int i = 0; i<= controle; i++) // Laço - For
            {
                Lista.Items.Add(i); // Processo
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


