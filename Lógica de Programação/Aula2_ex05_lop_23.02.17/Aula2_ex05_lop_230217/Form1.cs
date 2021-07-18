using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_ex05_lop_230217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void but_Click(object sender, EventArgs e)
        {
            double TempC; // Variaveis de entrada - Temperatura Celsius
            double TempF; // Variaveis de saida - temperatura Fahrenheit

            TempC = double.Parse(textBox1.Text); // entrada 1

            TempF = (TempC * 1.8) + 32; // Processo 1

            textBox2.Text = TempF.ToString(); // Saida 1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
