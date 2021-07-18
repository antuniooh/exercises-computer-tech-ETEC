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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
            public void limpar()
            {
                txtMat_Func.Clear();
                txtNome_Func.Clear();
                txtCPF_Func.Clear();
                txtEnd_Func.Clear();
                txtUser_Func.Clear();
                txtFone_Func.Clear();
                txtDtaAdm_Func.Clear();
                txtDtaNasc_Func.Clear();
                txtSenha_Func.Clear();
                txtRG_Func.Clear();
                cbStatus_Func.Text = "";
                cbFunc_Func.Text = "";

                txtMat_Func.Focus();
            }

            private void btnsair_Click(object sender, EventArgs e)
            {

                if (System.Windows.Forms.MessageBox.Show("Sair do Cadastro de Funcionário?", "****Sair Funcionário****",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();// Fecha formulario corrente
                }

            }

            private void btnIncluir_Click(object sender, EventArgs e)
            {

            }
    }
}