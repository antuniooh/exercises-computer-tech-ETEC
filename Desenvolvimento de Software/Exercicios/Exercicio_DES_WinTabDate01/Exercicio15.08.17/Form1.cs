using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio15._08._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            String nome, numero, conceito;
          
            nota1 = double.Parse(txtnota.Text);
            nota2 = double.Parse(txtnota2.Text);
            media = (nota1 + nota2) / 2;
            conceito = txtconc.Text;
            nome = txtnome.Text;
            numero = txtnumero.Text;

            if (nota1 < 0 || nota1 > 10)
            {
                MessageBox.Show("O número é invalido. Digite um número entre 0 e 10");
                txtnota.Clear();
                txtnota.Focus();
            }

            if (nota2 < 0 || nota2 > 10)
            {
                MessageBox.Show("O número é invalido. Digite um número entre 0 e 10");
                txtnota2.Clear();
                txtnota2.Focus();
            }

            else if (media < 5)
            {
                txtconc.Text = "I - Insatisfatório";

                txtconc.ForeColor = Color.Red;
                txtconc.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);

                txtmed.Text = media.ToString();
                txtmed.ForeColor = Color.Red;
                txtmed.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);
            }
            if ( media >= 5 && media < 7)
            {
                txtconc.Text = "R - Regular";

                txtconc.ForeColor = Color.Brown;
                txtconc.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);

                txtmed.Text = media.ToString();
                txtmed.ForeColor = Color.Brown;
                txtmed.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);
            }
            if (media>=7 && media <= 9)
            {
                txtconc.Text = "B - Bom";

                txtconc.ForeColor = Color.Green;
                txtconc.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);

                txtmed.Text = media.ToString();
                txtmed.ForeColor = Color.Green;
                txtmed.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);
            }
            if (media>=9 && media <= 10)
            {
                txtconc.Text = "MB - Muito Bom";

                txtconc.ForeColor = Color.Blue;
                txtconc.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);

                txtmed.Text = media.ToString();
                txtmed.ForeColor = Color.Blue;
                txtmed.Font = new Font(txtconc.Font.Name, 9, FontStyle.Bold);
            }

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtnome.Clear();
            txtnota.Clear();
            txtnota2.Clear();
            txtmed.Clear();
            txtconc.Clear();
            
            
        }

        private void btnfechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
        }

        private void btnremov_Click(object sender, EventArgs e)
        {
           dgv1.Rows.RemoveAt(0);
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Add(txtnumero.Text, txtnome.Text, txtnota.Text, txtnota2.Text, txtmed.Text, txtconc.Text, pictureBox1.Image);
            txtnumero.Clear();
            txtnome.Clear();
            txtnota.Clear();
            txtnota2.Clear();
            txtmed.Clear();
            txtconc.Clear();
            txtnumero.Focus();
        }

        private void txtmed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            caixadialogo.ShowDialog();
            pictureBox1.Load(caixadialogo.FileName);

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = System.DateTime.Now.ToString();
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnome.Focus();
            }
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnota.Focus();
            }
        }

        private void txtnota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnota2.Focus();
            }
        }

        private void txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btncalcular.Focus();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
