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
    public partial class FormCadastro : Form
    {
        #region Declaração de Componentes
        DataSet ds = new DataSet();
        SqlDataAdapter dt = new SqlDataAdapter();
        SqlConnection ocon = new SqlConnection();
        string sql, con;
        string sexo;
        #endregion

        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                /* objCnx.ConnectionString = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Acesso;Integrated
                 Security=True";*/
                 objCnx.ConnectionString = Properties.Settings.Default.ConexãoSQL;
                 objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message, " ADO.NET ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin Login = new FormLogin();
            Login.Show();
        }

        private void btnNCancelar_Click(object sender, EventArgs e)
        {
            txtNSenha.Clear();
            txtNSenhaConfirmar.Clear();
            txtNUser.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Acesso where Usuario= " + "'" + txtNUser.Text + "'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    MessageBox.Show("Usuario Já Cadastrado!!\n\nTente Novamente...", "*** CADASTRO DE USUARIO ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtNSenhaConfirmar.Text == txtNSenha.Text)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }

                        strSql = "Insert into Acesso(Usuario,Senha) values('" + txtNUser.Text + "','" + txtNSenha.Text + "')";

                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro Realizado com Sucesso!!!", "*** CADASTRO DE USUARIO***",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Senhas não coincidem!\n\nTente novamente...", "*** CADASTRO DE USUÁRIO ***",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                    }
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message,
                   "*** ADO.NET ***",
                 MessageBoxButtons.OK);
            }
        }

        private void btnNFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
