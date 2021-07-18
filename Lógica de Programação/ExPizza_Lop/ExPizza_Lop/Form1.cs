using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPizza_Lop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
          
            
            float V1 = 0;
            float V2 = 0;
            float V3 = 0;
            float Soma;
            float AV1;
            float AV2;
            float AV3;
                                               
            V1 = float.Parse(txtV1.Text);
            V2 = float.Parse(txtV2.Text);
            V3 = float.Parse(txtV3.Text);
            
            Soma = V1 + V2 + V3;
            V1 =  Soma - (V3 + V2); // processo 
            V2 = Soma - (V3 + V1); // processo 
            V3 = Soma - (V1 + V2); // processo 

            AV1 = (360 * V1) / Soma;
            AV2 = (360 * V2) / Soma ;
            AV3 = (360 * V3) / Soma;
            
            Graphics MyGraphics = CreateGraphics();

            SolidBrush mySolidBrushV1 = new SolidBrush(Color.Yellow);
            MyGraphics.FillPie(mySolidBrushV1, 50, 50, 150, 150, 0, AV1);

            SolidBrush mySolidBrushV2 = new SolidBrush(Color.Blue);
            MyGraphics.FillPie(mySolidBrushV2, 50, 50, 150, 150, AV1, AV2);

            SolidBrush mySolidBrushV3 = new SolidBrush(Color.Red);
            MyGraphics.FillPie(mySolidBrushV3, 50, 50, 150, 150, AV1 + AV2, AV3);
        }
    }
}
