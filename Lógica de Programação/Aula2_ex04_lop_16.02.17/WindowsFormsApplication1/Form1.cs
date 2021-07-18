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

        private void btn1_Click(object sender, EventArgs e)
        {
            double CF;
            double PD;
            double IMP;
            double PC;

            CF = double.Parse(txt1.Text);

            PD = CF*0.15;
            IMP = CF*0.42 ;
            PC = CF+PD+IMP;

            lbl1.Text = "Preço ao consumidor: " + PC.ToString();
        }
    }
}
