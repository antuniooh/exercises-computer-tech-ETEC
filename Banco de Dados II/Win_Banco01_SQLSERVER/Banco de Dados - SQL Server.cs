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
                string strSql = "Select * from Produtos where Codigo=" + txtCodigo.Text;
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
                    txtProduto.Text = objDados["Nome"].ToString();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Produtos where Codigo=" + txtCodigo1.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows)
                {
                    MessageBox.Show("Código Já Cadastrado!!\n\nTente Novamente...", "*** CADASTRO DE PRODUTO ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (!objDados.IsClosed)
                    {
                        objDados.Close();
                    }
                    strSql = "Insert into Produtos (Codigo,Nome,Descrição,Valor,Fornecedor)values('" + txtCodigo1.Text +
                        "','" + txtProduto1.Text + "','" + txtDescricao1.Text + "','" + txtValor1.Text + "','" + txtFornecedor1.Text + "')";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!!!", "*** CADASTRO DE PRODUTO ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed)
                {
                    objDados.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message,
                    "*** ADO.NET ***",
                    MessageBoxButtons.OK);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo1.Clear();
            txtDescricao1.Clear();
            txtFornecedor1.Clear();
            txtProduto1.Clear();
            txtValor1.Clear();
            txtCodigo1.Focus();
        }

        private void btnFechar3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            txtCodigo2.Clear();
            txtDescricao2.Clear();
            txtFornecedor2.Clear();
            txtProduto2.Clear();
            txtValor2.Clear();
            txtCodigo2.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Produtos where Codigo=" + txtCodigo2.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!", "*** CONSULTAGEM ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    txtCodigo2.Clear();
                    txtCodigo2.Focus();
                }
                else
                {
                    if (!objDados.IsClosed)
                    {
                        objDados.Close();
                    }
                    strSql = "Update Produtos set";
                    strSql += "Nome = '" + txtProduto2.Text + "',";
                    strSql += "Descrição = '" + txtDescricao2.Text + "',";
                    strSql += "Valor = '" + txtValor2.Text + "',";
                    strSql += "Fornecedor = '" + txtFornecedor2.Text + "',";
                    strSql += "where Codigo= " + txtCodigo2.Text + "',";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado com Sucesso!!!", "*** ADO.NET ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    btnCancelar1_Click(sender, e);

                    if (!objDados.IsClosed)
                    {
                        objDados.Close();
                    }
                }
            }
            catch (SqlException Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Produtos where Codigo=" + txtCodigo2.Text;
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                 if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!", "*** CONSULTAGEM ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    txtCodigo2.Clear();
                    txtCodigo2.Focus();
                 }
                 else
                 {
                     objDados.Read();
                     txtProduto2.Text = objDados["Nome"].ToString();
                     txtDescricao2.Text = objDados["Descrição"].ToString();
                     txtValor2.Text = objDados["Valor"].ToString();
                     txtFornecedor2.Text = objDados["Fornecedor"].ToString();
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