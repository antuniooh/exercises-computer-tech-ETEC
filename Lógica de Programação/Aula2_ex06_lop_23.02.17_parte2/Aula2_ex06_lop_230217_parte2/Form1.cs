using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_ex06_lop_230217_parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntCalcular_Click(object sender, EventArgs e)
        {
            double Valor1; // Variavel de Entrada - Real
            double Valor2; // Variavel de Entrada - Real

            Valor1 = float.Parse(txt1.Text); // Entrada 1
            Valor2 = float.Parse(txt2.Text); // Entrada 2

            double VS; // Variavel de saida - real
            double VP; // Variavel de saida - real
            double VQ; // Variavel de saida - real

            Valor1 = float.Parse(txt1.Text); // Entrada 1
            Valor2 = float.Parse(txt2.Text); // Entrada 2

            VS = (Valor1 + Valor2) * 0.2; // Processo 1
            VP = (Valor1 * Valor2) * 0.3; // Processo 2
            VQ = (Math.Pow(Valor1, 2) + Math.Pow(Valor2, 2)) * 0.4; // Processo 3

            LblProduto.Text = VP.ToString(); // saida 1
            LblQuadrado.Text = VQ.ToString(); // Saida 2
            LblSoma.Text = VS.ToString(); // Saida 3
        }
    }
}
