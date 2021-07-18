using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioDES
{
    public partial class FrmSequencia : Form
    {
        public FrmSequencia()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSequencia_Load(object sender, EventArgs e)
        {
            string saida = "*";

            for (int x = 1; x <= 10; x++)
            {
                lblSequencia.Text += saida + "\n";
                for (int y = x; y <= x; y++)
                {
                    saida += "*";
                }
            }            
        }
    }
}
