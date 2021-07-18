using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex26_Nave_Lop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (picNave.Top < 156)
            {
                picNave.Top = picNave.Top + 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picCima_Click(object sender, EventArgs e)
        {
            if (picNave.Top > 0)
            {
                picNave.Top = picNave.Top - 20;
            }
        }

        private void picEsquerda_Click(object sender, EventArgs e)
        {
            if (picNave.Left > 12)
            {
                picNave.Left = picNave.Left - 20;
            }
        }

        private void picDireita_Click(object sender, EventArgs e)
        {
            if (picNave.Left < 456)
            {
                picNave.Left = picNave.Left + 20;
            }
        }
    }
}
