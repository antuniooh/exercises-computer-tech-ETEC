using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTab_Date
{

    public partial class FrmTabData : Form
    {
        
        public FrmTabData()
        {
            InitializeComponent();

            txtMedia.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtMedia.Clear();
            txtCodigo.Focus();
            dataGridView1.Rows.Clear();

            txtMedia.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodigo.Text, txtNome.Text, txtP1.Text, txtP2.Text, txtMedia.Text);
            txtCodigo.Clear();
            txtNome.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtMedia.Clear();
            txtCodigo.Focus();

            txtMedia.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double P1 = 0;
            double P2 = 0;
            double Media = 0;

            P1 = double.Parse(txtP1.Text);
            P2 = double.Parse(txtP2.Text);

            if (P1 < 0 || P1 >= 11 || P2 < 0 || P2 >= 11)
            {
                MessageBox.Show("Digite uma Nota Válida", "*** Erro ***",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                {
                    txtCodigo.Clear();
                    txtNome.Clear();
                    txtP1.Clear();
                    txtP2.Clear();
                    txtMedia.Clear();
                    txtCodigo.Focus();
                    txtMedia.Visible = false;
                }
            }
            else
            {
                Media = (P1 + P2) / 2;
                txtMedia.Text = Media.ToString();
                txtMedia.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "*** FINALIZANDO ***",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtP1.Focus();
            }
        }

        private void txtP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtP2.Focus();
            }
        }

        private void txtP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMedia.Focus();
            }
        }

        private void FrmTabData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
