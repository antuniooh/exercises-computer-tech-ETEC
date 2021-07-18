using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBetaPizzaria_v1._0_260517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente J1 = new FrmCliente(); // New - Instanciar um objeto, com suas propriedades
            J1.MdiParent = this; // this - dá privilégio                                          
            J1.Show(); // exibe na tela                                                                  
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor J2 = new FrmFornecedor(); // New - Instanciar um objeto, com suas propriedades
            J2.MdiParent = this; // this - dá privilégio
            J2.Show(); // exibe na tela
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario J3 = new FrmFuncionario(); // New - Instanciar um objeto, com suas propriedades
            J3.MdiParent = this; // this - dá privilégio
            J3.Show(); // exibe na tela
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto J4 = new FrmProduto(); // New - Instanciar um objeto, com suas propriedades
            J4.MdiParent = this; // this - dá privilégio
            J4.Show(); // exibe na tela
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Finalizar Sistema?", "****Sair do Sistema****", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();// Fecha toda Aplicação
            }

        }

           
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripLabel2.Text = System.DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel2.Text = System.DateTime.Now.ToString();
        }
    }
}