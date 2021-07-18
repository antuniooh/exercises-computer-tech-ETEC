using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex30_Array_Jogador_Lop_0106
{
    public partial class Form1 : Form
    {
        string[,] jogadores = new string[11, 2]; // matriz de texto array - bidimensional
        int contadorJogador = 0; // variavel publica inteira
        int contadorFalta = 0; // variavel publica inteira

        public Form1()
        {
            InitializeComponent();
        }

        private void btnarray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Lista.Items.Add(jogadores[i, 0] + " - Total de Faltas(s): " + jogadores[i, 1]);
            }
        }

        private void btnjogador_Click(object sender, EventArgs e)
        {
            jogadores[contadorJogador, 0] = txtjogador.Text; // entrada 1

            if (contadorJogador <= 10 && txtjogador.Text != "")
            {
                contadorJogador++;
                txtjogador.Text = null;
            }
            else
            {
                btnjogador.Enabled = false;
            }


        }

        private void btnfalta_Click(object sender, EventArgs e)
        {
            if (contadorJogador <= 10 && txtfalta.Text != "")
            {
                jogadores[contadorFalta, 1] = txtfalta.Text;
                contadorFalta++;
                txtfalta.Text = null;
            }
            else
            {
                btnfalta.Enabled = false;

            }

        }
    }
}
