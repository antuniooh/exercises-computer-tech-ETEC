using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SB; // variavel de entrada - real
            double SL = 0; // variavel de saida - real
            double IR = 0; // variavel de saida - real
            double GRAT = 0; // variavel de saida- real

            SB = double.Parse(txtSB.Text); // entrada 1

            if (SB > 1000 && SB <= 2000) GRAT = SB * 0.1; // Condicional 1 - processo 1
            if (SB > 2000 && SB <= 3000) GRAT = SB * 0.2; // Condicional 2 - processo 2
            if (SB > 3000 && SB <= 5000) GRAT = SB * 0.25; // Condicional 3 - processo 3
            if (SB > 5000) GRAT = SB * 0.3; // Condicional 4 - processo 4
            if (SB > 1970 && SB <= 3800) IR = SB * 0.175; // Condicional 5 - processo 5
            if (SB > 3800 && SB <= 5079) IR = SB * 0.225; // Condicional 6 - processo 6
            if (SB > 5079) IR = SB * 0.275; // Condicional 7 - processo 7

            SL = SB + GRAT - IR; // processo 8
            txtSL.Text = SL.ToString(); // Saida 1
            txtGRAT.Text = GRAT.ToString(); // saida 2
            txtIR.Text = IR.ToString(); // saida 3
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
