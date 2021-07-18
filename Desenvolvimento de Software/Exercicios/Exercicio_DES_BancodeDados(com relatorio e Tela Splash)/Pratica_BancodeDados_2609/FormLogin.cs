using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pratica_BancodeDados_2609
{
    public partial class FormLogin : Form
    {
        #region Declaração de Componentes
        DataSet ds = new DataSet();
        SqlDataAdapter dt = new SqlDataAdapter();
        SqlConnection ocon = new SqlConnection();
        string sql, con;
        #endregion

        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            try
            {
                /* objCnx.ConnectionString = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Cadastro;Integrated
                 Security=True";*/
                objCnx.ConnectionString = Properties.Settings.Default.ConexãoSQL;
                objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message, " ADO.NET ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Acesso where Usuario="+"'"+txtLUser.Text+"'" ;
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Usuário Não Encontrado!", "*** LOGIN ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                    txtLUser.Clear();
                    txtLSenha.Clear();
                    txtLUser.Focus();
                }
                else
                {
                    objDados.Read();

                    CadastroDeCliente Cadastro = new CadastroDeCliente();
                    Cadastro.Show();

                }
            }
            catch(Exception erro)
            {
              MessageBox.Show(erro.Message); 
            }
        }

        private void btnNFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLCancelar_Click(object sender, EventArgs e)
        {
            txtLSenha.Clear();
            txtLUser.Clear();
            txtLUser.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
        }
    }
}
