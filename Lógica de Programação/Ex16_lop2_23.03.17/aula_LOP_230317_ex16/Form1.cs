using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_LOP_230317_ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Numero; // Variavel de Entrada

            Numero = int.Parse(txtNumero.Text); //

            if (Numero != 0)  // Condição 1
            {
                if (Numero % 2 == 0) // Condição 2
                {
                    lblResultado.Text = "o numero " + Numero + " é par"; // Saida 1    
                }
                else // negação da condição 2
                {   
                    lblResultado.Text = "o numero " + Numero + " é impar"; // Saida 2
                }
            }
            else  // negação da condição 1
            {
               
                lblResultado.Text= "o numero 0 não tem divisor"; // Saida 3
            }
            }
    }
    }
