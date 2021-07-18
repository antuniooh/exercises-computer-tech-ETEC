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

namespace Win_Banco01_SQLSERVER
{
    public partial class BancoDeDados_SQLServer : Form
    {
        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;

        public BancoDeDados_SQLServer()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Produtos";
            objCmd.CommandText = strSql;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.HasRows)
            {
                while (objDados.Read())
                {
                    dataGridView1.Rows.Add(objDados["Codigo"].ToString(), objDados["Nome"].ToString(),
                        objDados["Descrição"], objDados["Valor"].ToString(), objDados["Fornecedor"].ToString());
                }
                objDados.Close();
            }
            else
            {
                MessageBox.Show("Código Não Encontrado!", "Consulta Geral", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void BancoDeDados_SQLServer_Load(object sender, EventArgs e)
        {
            try
            {
                /*objCnx.ConnectionString = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Produtos;Integrated
                Security=True";*/
                objCnx.ConnectionString = Properties.Settings.Default.ConexãoSQLServer;
                objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erroooooo ==> " + erro.Message, " ADO.NET ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtFornecedor.Clear();
            txtProduto.Clear();
            txtValor.Clear();
            txtCodigo.Focus();

            dataGridView1.Rows.Clear();
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtFornecedor.Clear();
            txtProduto.Clear();
            txtValor.Clear();
            txtCodigo.Focus();
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            this.Close();
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Produtos where Codigo=" +txtCodigo.Text;
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Não Encontrado!", "*** CONSULTAGEM ***",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    txtCodigo.Clear();
                    txtDescricao.Clear();
                    txtFornecedor.Clear();
                    txtProduto.Clear();
                    txtValor.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    objDados.Read();
                    txtProduto.Text = objDados["Nomee"].ToString();
                    txtDescricao.Text = objDados["Descrição"].ToString();
                    txtValor.Text = objDados["Valor"].ToString();
                    txtFornecedor.Text = objDados["Fornecedor"].ToString();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }

            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
        }
    }