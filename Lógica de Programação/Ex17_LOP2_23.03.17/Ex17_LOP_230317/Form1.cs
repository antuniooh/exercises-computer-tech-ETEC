using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17_LOP_230317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double bonus; // Variavel de Saida - Real
            double salario; // Variavel de Entrada - Real
            int tempo; // Variavel de Entrada - Inteiro

            salario = double.Parse(txtSalario.Text); // Entrada 1
            tempo = int.Parse(txtTempo.Text); // Entrada 2

            if (tempo >= 5) // Condição 1
            {
                bonus = salario * 0.2; // Processo 1
            }
            else
            {
                bonus = salario * 0.1; // Processo 2
            }
            salario = salario + bonus; // Processo 3
            lblResultado.Text = "O salário será " + salario; // Saida 1
        }
    }
}
