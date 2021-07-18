using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4CSharp
{
    public partial class MP4CSharp : Form
    {
        public MP4CSharp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaixaDialogo.Multiselect = false;
            CaixaDialogo.Filter = " Arquivo Formato Mp4 | *.mp4";
            CaixaDialogo.FileName = "*.mp4";
            if (CaixaDialogo.ShowDialog() == DialogResult.OK)
                MediaPlayer.URL = CaixaDialogo.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MP4CSharp_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "dorom.mp4";
        }
    }
}
