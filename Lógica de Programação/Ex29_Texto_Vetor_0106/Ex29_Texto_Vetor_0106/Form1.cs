using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex29_Texto_Vetor_0106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string Titulo = "Sistema de Classificação de Texto";
            string Pergunta = "Deseja Sair do Sistema?";

            if (MessageBox.Show(Pergunta, Titulo, MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
            lblResposta.Text = "";
            grbSaida.Visible = false;

            txtnome1.Focus(); // Manda para a caixa indicada
        }

        private void btnclassificar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5]; // Criação de matriz unidimensional de 5 indices de texto
            string aux; // variavel de texto

            nomes[0] = txtnome1.Text; //entrada 1
            nomes[1] = txtnome2.Text; // entrada 2
            nomes[2] = txtnome3.Text; // entrada 3
            nomes[3] = txtnome4.Text; // entrada 4
            nomes[4] = txtnome5.Text; // entrada 5

            for (int i = 0; i <= 4; i++) // laço 1 - para
            {
                for (int j = i + 1; j <= 4; j++) // laço 2 - para
                {
                    if (String.CompareOrdinal(nomes[i], nomes[j]) > 0) // condiçao 1
                    {
                        aux = nomes[i]; // processo 1
                        nomes[i] = nomes[j]; // processo 2
                        nomes[j] = aux; // processo 3
                    }
                }
            }
            grbSaida.Visible = true; // processo 4

            for (int x = 0; x <= 4; x++) // laço 3 - para
            {
                lblResposta.Text += "\n " + nomes[x]; // atribui e adiciona 

            }
            limpar(); // chama o metodo limpar
        }
        public void limpar()
        {
            txtnome1.Clear();
            txtnome2.Clear();
            txtnome3.Clear();
            txtnome4.Clear();
            txtnome5.Clear();
        }
    }
}
