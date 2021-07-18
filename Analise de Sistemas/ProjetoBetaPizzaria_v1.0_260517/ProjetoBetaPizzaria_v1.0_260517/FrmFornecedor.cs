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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txtCod_Forn.Clear();
            txtCNPJ.Forn.Clear();
            txtRazao.Forn.Clear();
            txtEnd_Forn.Clear();
            txtCont_Forn.Clear();
            txtFone_Forn.Clear();
            cbStatus_Forn.Text = "";
            
            txtCod_Forn.Focus();
        }
    }
}
