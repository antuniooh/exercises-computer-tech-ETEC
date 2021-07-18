using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text =
          "Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
         "Shift: " + (e.Shift ? "Yes" : "No") + '\n' +
         "Ctrl: " + (e.Control ? "Yes" : "No") + '\n' +
         "KeyCode: " + e.KeyCode + '\n' +
         "KeyData: " + e.KeyData + '\n' +
         "KeyValue: " + e.KeyValue;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = "Tecla Pressionada: " + e.KeyChar;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
