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
                    dataGridView1.Rows.Add(objDados["Codigo"].ToString(), objDados["Nomee"].ToString(),
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

        private void btncadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string srtSql = "Select * from Produtos where Codigo=" + txtcodigoi.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows)
                {
                    MessageBox.Show("Código já cadastrado!!!\n\nTente novamente...",
                    "*** CADASTRO DE PRODUTO ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    srtSql = "Insert into Produtos (Codigo,Nomee,Descrição,Valor,Fornecedor)values('" + txtcodigoi.Text +
                        "','" +txtnomei.Text + "','" +txtdesci.Text + "','" +txtvalori.Text + "','" +txtforncedori.Text + "')";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = srtSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!!!", "***Cadastro de Produto***",
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
                MessageBox.Show("ERRO =>" + erro.Message, "***ADO.NET***", MessageBoxButtons.OK);
            }


        }
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            txtcodigoi.Clear();
            txtdesci.Clear();
            txtforncedori.Clear();
            txtnomei.Clear();
            txtvalori.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                string srtSql = "Select * From Produtos where Codigo=" + txtcodigo2.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!!", "*** Consultagem ***",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    txtcodigo2.Clear();
                    txtcodigo2.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    srtSql = "Update Produtos set ";
                    srtSql += "Nomee ='" + txtnome2.Text + "',";
                    srtSql += "Descrição = ' " + txtdesc2.Text + "',";
                    srtSql += "Valor ='" + txtvalor2.Text + "',";
                    srtSql += "Fornecedor = '" + txtforncedor2.Text + "'";
                    srtSql += "where Codigo=" + txtcodigo2.Text;

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = srtSql;
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro alterado com sucesso!!!", "ADO.NET",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnLimpar_Click(sender, e);

                    if (!objDados.IsClosed)
                    {
                        objDados.Close();
                    }
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ==>" + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncacelar2_Click(object sender, EventArgs e)
        {
            txtcodigo2.Clear();
            txtdesc2.Clear();
            txtforncedor2.Clear();
            txtnome2.Clear();
            txtvalor2.Clear();
        }

        private void fechar22_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string srtSql = "Select * from Produtos where Codigo = " + txtcodigo2.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "*** Consultagem ***",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                    txtcodigo2.Clear();
                    txtcodigo2.Focus();
                }
                else
                {
                    objDados.Read();
                    txtnome2.Text = objDados["Nomee"].ToString();
                    txtdesc2.Text = objDados["Descrição"].ToString();
                    txtvalor2.Text = objDados["Valor"].ToString();
                    txtcodigo2.Text = objDados["Fornecedor"].ToString();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string srtSql = "Select * from Produtos where Codigo= " + txtcodigo3.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", " Consultagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    txtcodigo3.Clear();
                    txtcodigo3.Focus();
                }
                else
                {
                    objDados.Read();
                    txtnome3.Text = objDados["Nomee"].ToString();
                    txtdesc3.Text = objDados["Descrição"].ToString();
                    txtvalor3.Text = objDados["Valor"].ToString();
                    txtfornecedor3.Text = objDados["Fornecedor"].ToString();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

                        
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
             try
            {
                string srtSql = "Select * From Produtos where Codigo=" + txtcodigo3.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código não Cadastrado!!!\n\nTente novamente...", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!objDados.IsClosed) {objDados.Close();}
                    srtSql = "Delete from Produtos where Codigo=" + txtcodigo3.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = srtSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Exclusão realizada com Sucesso!!!", "Exclusão de Produto ", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                   button3_Click(sender, e);
                }
                 if (!objDados.IsClosed)
                 {
                     objDados.Close();
                 }
             }
            catch (Exception erro)
             {
                MessageBox.Show("Erro ==> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    

        }

        private void btncancelar3_Click(object sender, EventArgs e)
        {
            txtcodigo3.Clear();
            txtdesc3.Clear();
            txtfornecedor3.Clear();
            txtnome3.Clear();
            txtvalor3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}



 