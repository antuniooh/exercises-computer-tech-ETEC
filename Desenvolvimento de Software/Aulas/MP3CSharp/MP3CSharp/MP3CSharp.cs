using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3CSharp
{
    public partial class MP3CSharp : Form
    {
        public MP3CSharp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaixaDialogo.Multiselect = false;
            CaixaDialogo.Filter = " Arquivo Formato Mp3 | *.mp3";
            CaixaDialogo.FileName = "*.mp3";
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

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void MP3CSharp_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "dorom.mp3";
        }
    }
}
