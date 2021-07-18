using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc1
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("estou na janela Filha");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
