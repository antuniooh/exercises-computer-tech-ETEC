using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Banco01_SQLSERVER
{
    public partial class Tela_splashh : Form
    {
        public Tela_splashh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 120)
            {
                progressBar1.Value += 10;
            }
            else
            {
                TrmTimer.Enabled = false;
                this.Hide();
                BancoDeDados_SQLServer login = new BancoDeDados_SQLServer();
                login.Show();
            }
        }

        private void Tela_splashh_Load(object sender, EventArgs e)
        {
            TrmTimer.Enabled = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 120;
        }
    }
}
