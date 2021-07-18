using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Exerc3
{
    public partial class Form1 : Form
    {
        private int count = 0; ///definevariavel count, controle o indice de figura
        private ArrayList images = new ArrayList(); //define um vetor de imagem
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)

            images.Add(Image.FromFile(Application.StartupPath + "//fig" + i + ".gif"));
            pictureBox1.Image = (Image)images[1];
            pictureBox1.Size = pictureBox1.Image.Size;
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count <6)
            {
                pictureBox1.Image = (Image)images[count];
                count = count + 1;
            }
            else
                count = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
