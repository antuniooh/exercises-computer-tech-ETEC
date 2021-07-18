using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex21_LOP_Tratatmentoerro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            double Valor1 = 0, Valor2 = 0, Media = 0; // Variaveis de entrada - real
            try
            {
                Valor1 = double.Parse (txtvalor1.Text); // Entrada 1
                Valor2 = double.Parse (txtvalor2.Text); // Entrada 2

                Media = (Valor1 + Valor2) / 2; // Processo 1

                txtmedia.Text = Media.ToString(); // Saida 1
            }
            catch
            {
                MessageBox.Show ("Erro de leitura, Digite um Valor Numerico Valido!");
            }
        }
    }
}