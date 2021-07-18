using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica_BancodeDados_2609
{
    public partial class FormTelaSplash : Form
    {
        public FormTelaSplash()
        {
            InitializeComponent();
        }

        private void FormTelaSplash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.100;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();

                FormLogin login = new FormLogin();
                login.ShowDialog();
            }
        }
    }
}
