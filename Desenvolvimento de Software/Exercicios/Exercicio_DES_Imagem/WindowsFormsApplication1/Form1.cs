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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Desert;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Tulips;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle =BorderStyle.None;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pcbFoto.Visible = true;
            }
            else
            {
                pcbFoto.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
