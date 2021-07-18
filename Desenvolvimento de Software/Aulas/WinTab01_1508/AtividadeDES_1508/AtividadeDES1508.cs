using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDES_1508
{
    public partial class AtividadeDES1508 : Form
    {
        public AtividadeDES1508()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double P1 = 0;
            double P2 = 0;
            double Media = 0;

            P1 = double.Parse(txtP1.Text);
            P2 = double.Parse(txtP2.Text);

            if (P1 < 0 || P1 >= 11 || P2 < 0 || P2 >= 11)
            {
                MessageBox.Show("Digite uma nota válida", " Erro de Cadastro ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                {
                    txtCodigo.Clear();
                    txtNome.Clear();
                    txtP1.Clear();
                    txtP2.Clear();
                    txtMedia.Clear();
                    txtCodigo.Focus();
                    txtMedia.Visible = false;
                    txtConceito.Visible = false;
                }
            }
            else
            {
                Media = (P1 + P2) / 2;
                txtMedia.Text = Media.ToString();
                txtMedia.Visible = true;
                txtConceito.Visible = true;
            }

            if (Media >= 9.0 && Media <= 10.0)
            {
                txtConceito.ForeColor = Color.Blue;
                txtConceito.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtMedia.ForeColor = Color.Blue;
                txtMedia.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtConceito.Text = "MB - Muito Bom";
            }

            if (Media >= 7.0 && Media <= 8.9)
            {
                txtConceito.ForeColor = Color.Green;
                txtConceito.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtMedia.ForeColor = Color.Green;
                txtMedia.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtConceito.Text = "B - Bom";
            }

            if (Media >= 5.0 && Media <= 6.9)
            {
                txtConceito.ForeColor = Color.Brown;
                txtConceito.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtMedia.ForeColor = Color.Brown;
                txtMedia.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtConceito.Text = "R - Regular";
            }

            if (Media >= 0.0 && Media <= 4.9)
            {
                txtConceito.ForeColor = Color.Red;
                txtConceito.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtMedia.ForeColor = Color.Red;
                txtMedia.Font = new Font(lblConceito.Font.Name, 12, FontStyle.Bold);

                txtConceito.Text = "I - Insatisfatório";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodigo.Text, txtNome.Text, txtP1.Text, txtP2.Text, txtMedia.Text, txtConceito.Text, pcbFoto.Image);
            txtCodigo.Clear();
            txtNome.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtMedia.Clear();
            txtConceito.Clear();
            pcbFoto.Image = null;
            txtCodigo.Focus();

            txtMedia.Visible = false;
            txtConceito.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtMedia.Clear();
            txtConceito.Clear();
            pcbFoto.Image = null;
            txtCodigo.Focus();

            txtMedia.Visible = false;
            txtConceito.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            CaixaDialogo.Multiselect = false;
            CaixaDialogo.Filter = " Arquivo Formato jpg | *.jpg";
            CaixaDialogo.FileName = "*.jpg";
            if (CaixaDialogo.ShowDialog() == DialogResult.OK)
                pcbFoto.ImageLocation = CaixaDialogo.FileName;
        }

      //  private void btnCancelar_Click(object sender, EventArgs e)
   
        private void btnRemover_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // private void btnLimpar_Click(object sender, EventArgs e)
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Today.ToLongDateString();
        }
    }
}

