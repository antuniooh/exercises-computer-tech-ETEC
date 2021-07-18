using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex27_Imagem_Lop_2505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics MyGraphics = CreateGraphics();
            Pen MyPen = new Pen(Color.DarkRed); // obj Caneta da cor Vermelho Escuro
            SolidBrush mySolidBrush = new SolidBrush(Color.Black);

            MyGraphics.Clear(Color.White);
            switch (cbImagem.SelectedIndex)
            {
                case 0: MyGraphics.DrawEllipse(MyPen, 50, 50, 150, 150);
                    break;
                case 1: MyGraphics.DrawRectangle(MyPen, 50, 50, 150, 150);
                    break;
                case 2: MyGraphics.DrawRectangle(MyPen, 50, 50, 150, 100);
                    break;
                case 3: MyGraphics.DrawEllipse(MyPen, 50, 50, 150, 100);
                    break;
                case 4: MyGraphics.DrawPie(MyPen, 50, 50, 150, 150, 0, 45);
                    break;

                case 5: MyGraphics.FillEllipse (mySolidBrush, 50, 50, 150, 150);
                    break;
                case 6: MyGraphics.FillRectangle (mySolidBrush, 50, 50, 150, 150);
                    break;
                case 7: MyGraphics.FillRectangle (mySolidBrush, 50, 50, 150, 100);
                    break;
                case 8: MyGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 100);
                    break;
                case 9: MyGraphics.FillPie (mySolidBrush, 50, 50, 150, 150, 0, 360);
                    break;
            }
        }
    }
}