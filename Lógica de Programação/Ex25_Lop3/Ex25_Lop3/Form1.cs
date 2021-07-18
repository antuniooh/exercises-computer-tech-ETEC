using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex25_Lop3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            int diahj;
            int meshj;
            int anohj;

            int diaaniv;
            int mesaniv;
            int anoaniv;

            string nome;

            int idade;

            diahj = int.Parse(txtdiahj.Text);
            meshj = int.Parse(txtmeshj.Text);
            anohj = int.Parse(txtanohj.Text);

            diaaniv = int.Parse(txtdiaaniv.Text);
            mesaniv = int.Parse(txtmesaniv.Text);
            anoaniv = int.Parse(txtanoaniv.Text);

            nome = txtnome.Text;

            idade = 0;

            if (anohj > anoaniv) // condicional 1
            {
                if (meshj > mesaniv) // condicional 2
                {
                    idade = (anohj - anoaniv);
                }
                if (meshj < mesaniv) // condicional 3
                {
                    idade = (anohj - anoaniv - 1);
                }
                if (meshj == mesaniv) // condicional 4
                {
                    if (diahj > diaaniv)
                    {
                        idade = (anohj - anoaniv);
                    }
                    if (diahj < diaaniv) // condicional 5
                    {
                        idade = (anohj - anoaniv - 1);
                    }
                    if (diahj == diaaniv)
                    {
                        idade = (anohj - anoaniv);
                    }

                }

                lblresultado.Text = "Seu nome é " + nome + "," + idade + " anos"; // Saida
            }
        }
    }
}

