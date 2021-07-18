using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_201017
{
    public partial class Form1 : Form
    {
        Carro car1 = new Carro("Opala",false,1972,0); // instanciar o carro

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
             label3.Text = car1.ligar();
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
           label4.Text = car1.acelerar(float.Parse(txtVelocidade.Text)).ToString();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            label3.Text = car1.desligar();
        }

        private void btnFrear_Click(object sender, EventArgs e)
        {
            label4.Text = car1.frear(float.Parse(txtVelocidade.Text)).ToString();
        }
    }
}
