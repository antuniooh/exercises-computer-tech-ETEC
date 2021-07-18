using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosRepetição
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void Exercicio_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int G = 1;
            string saida = "";

            for (int i = 1; i <= 10; i++)
            {
                if (i == 0)
                {
                    G = 1;
                    saida = saida + i.ToString() + "!=" + G.ToString() + "\n";
                }

                else
                {
                    G = G * i;
                    saida = saida + i.ToString() + "!=" + G.ToString() + "\n";
                }
            }

            lblfator.Text = saida;    
        }
    }
}
