using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_Ex07_220217_parte3
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

        private void button1_Click(object sender, EventArgs e)
        {
            double CF; // Variavel de entrada - real 

            double PC; // Variavel de Saida- Real
            double IMP; // Variavel de Saida - Real
            double PD; // Variavel de saida - real

            CF = double.Parse(txt1.Text); // Entrada 1

            IMP = CF * 0.42; // Processo 1
            PD = CF * 0.15; // Processo 2
            PC = CF + PD + IMP; // Processo 3

            Lbl1.Text = PD.ToString(); // Saida 1
            Lbl2.Text = IMP.ToString(); // Saida 2
            Lbl3.Text = PC.ToString(); // Saida 3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
