using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_LaçoRepetição
{
    public partial class Exercicio_Laço : Form
    {
        int fatorial;
        string saida;

        public Exercicio_Laço()
        {
            InitializeComponent();
        }

       // private void Exercicio_Laço_Load(object sender, EventArgs e)

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblFator.Text = " ";
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int r = 1;
            string saida = "";
            try
            {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 0)
                {
                    r = 1;
                    saida = saida + i.ToString() + "!=" + r.ToString() + "\n";
                }

                else
                {
                    r = r * i;
                    saida = saida + i.ToString() + "!=" + r.ToString() + "\n";
                }
            }

            lblFator.Text = saida;
            
            }
            catch (FormatException erro)
            {
                MessageBox.Show(erro.Message, "*** ERRO ***", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
            
/*for me if = 1 to 10 step 1
for me y = 1.to if step 1
lblsaida.txt = *
lblsaida.ttx += vcbr(pular linha)*/