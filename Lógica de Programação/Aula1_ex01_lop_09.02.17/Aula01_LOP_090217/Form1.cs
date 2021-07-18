using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01_LOP_090217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEx01_Click(object sender, EventArgs e)
        {
            string nome; // Variaveis de entrada - Texto 
            string idade; // Variaveis de entrada - Texto
            string curso; // Variaveis de entrada - Texto

            nome = TXTNome.Text; // Entrada 1
            idade = TXTIdade.Text; // Entrada 2
            curso = TXTCurso.Text; // Entrada 3

            LBLSaida.Text = " Nome: "+ nome + "\n Idade: "+ idade + "\n Curso: "+ curso; // Saida 1 - Concatenar
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnEx02_Click(object sender, EventArgs e)
        {
            LBLSaidaEx2.Text = " Bem vindo a aula de LOP 1"; // Saída 1
        }

        private void BtnEx03_Click(object sender, EventArgs e)
        {
            double P1; // Variavel de entrada - Real
            double P2; //Variavel de entrada - Real
            double P3; // Variavel de entrada - Real
            double Pf;// Variavel de entrada - Real

            double Mp; // Variavel - Real
            double Mf; // Variavel Saida - Real

            P1 = double.Parse(TXTP1.Text); // Entrada 1
            P2 = double.Parse(TXTP2.Text); // Entrada 2
            P3 = double.Parse(TXTP3.Text); // Entrada 3
            Pf = double.Parse(TXTPF.Text); // Entrada Pf

            Mp = (P1 + P2 + P3) / 3; // Processo 1
            Mf = (2 * Pf); // Processo 2
            Mf = (Mp + Mf) / 3; // Processo 3

            LBLMédia.Text = Mf.ToString(); // Saida 1
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnEx04_Click(object sender, EventArgs e)
        {
            double Qm;
            double Qmx;
            double Em;

            Qm = double.Parse(TXTQm.Text);
            Qmx = double.Parse(TXTQmx.Text);

            Em = (Qm + Qmx) / 2;

            LBLEm.Text = Em.ToString(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LBLMédia_Click(object sender, EventArgs e)
        {

        }

        private void TXTQm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
