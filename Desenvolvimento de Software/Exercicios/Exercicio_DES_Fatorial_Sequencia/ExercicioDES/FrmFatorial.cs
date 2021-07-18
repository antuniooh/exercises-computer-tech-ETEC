using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioDES
{
    public partial class ExercicioRepetiçao : Form
    {
        public ExercicioRepetiçao()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int a = 1;
            string saida = "";

            for (int i = 1; i <= 10; i++)
            {
                if (i == 0)
                {
                    a = 1;
                    saida = saida + i.ToString() + "!=" + a.ToString() + "\n";
                }

                else
                {
                    a = a * i;
                    saida = saida + i.ToString() + "!=" + a.ToString() + "\n";
                }
            }

            lblfator.Text = saida;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblfator.Text = " ";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
