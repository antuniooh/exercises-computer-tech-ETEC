using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX01_Intro_TCI_19072017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RDNPreto_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text; // Entrada
            LBLResposta.ForeColor = Color.Black; // Forecolor é a cor da fonte ---- Processo - Saída

        }

        private void RDNVermelho_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text; // Entrada
            LBLResposta.ForeColor = Color.Red; // Forecolor é a cor da fonte ---- Processo - Saída
        }

        private void RDNVerde_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text; // Entrada
            LBLResposta.ForeColor = Color.Green; // Forecolor é a cor da fonte ---- Processo - Saída
        }

        private void RDNf12_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text;// Entrada
            LBLResposta.Font = new Font(LBLResposta.Font.Name, 12); // Processo - Saída
        }

        private void RDNf16_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text;// Entrada
            LBLResposta.Font = new Font(LBLResposta.Font.Name, 16); // Processo - Saída
        }

        private void RDNf20_CheckedChanged(object sender, EventArgs e)
        {
            LBLResposta.Text = TxtEntrada.Text;// Entrada
            LBLResposta.Font = new Font(LBLResposta.Font.Name, 20); // Processo - Saída
        }

        private void RDNmaiusculo_CheckedChanged(object sender, EventArgs e)
        {
            string z; // Variável de Entrada - Texto
            z = TxtEntrada.Text.ToUpper(); // Processo
            LBLResposta.Text = z; // Saída
        }

        private void RDNminúsculo_CheckedChanged(object sender, EventArgs e)
        {
            string z; // Variável de Entrada - Texto
            z = TxtEntrada.Text.ToLower(); // Processo
            LBLResposta.Text = z; // Saída
        }

        private void RDNcaracteres_CheckedChanged(object sender, EventArgs e)
        {
            int x; //Variável de Entrada - Inteira
            x = TxtEntrada.Text.Length; // Entrada - Processo
            LBLResposta.Text = x.ToString(); // Saída
        }
    }
}
