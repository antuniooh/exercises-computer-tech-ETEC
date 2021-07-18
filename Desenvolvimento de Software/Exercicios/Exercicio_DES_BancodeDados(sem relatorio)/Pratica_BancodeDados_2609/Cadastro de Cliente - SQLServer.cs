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
     public partial class CadastroDeCliente : Form
    {
        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;

        private DataSet ds = new DataSet();
        private SqlDataAdapter dt = new SqlDataAdapter();
        string strql, con;

        public CadastroDeCliente()
        {
            InitializeComponent();
        }
        string sexo;
        void Limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            rdnMasculino.Checked = false;
            rdnFeminino.Checked = false;
            txtCEP.Clear();
            txtNumero.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtFacebook.Clear();
            txtTwitter.Clear();
            txtCodigo.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Cadastro where Codigo=" + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    MessageBox.Show("Código Já Cadastrado!!\n\nTente Novamente...", "*** CADASTRO DE CLIENTE ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }

                    strSql = "Insert into Cadastro(Codigo,Nome,RG,CPF,Telefone,Sexo,CEP,Número,Logradouro,Bairro,Cidade,Email,Facebook,Twitter) values('" + txtCodigo.Text +
                        "','" + txtNome.Text + "','" + txtRG.Text + "','" + txtCPF.Text + "','" + txtTelefone.Text + "','" + sexo.ToString() + "','" + txtCEP.Text + "','" + txtNumero.Text + "','" + txtLogradouro.Text + "','" +
                        txtBairro.Text + "','" + txtCidade.Text + "','" + txtEmail.Text + "','" + txtFacebook.Text + "','" + txtTwitter.Text + "')";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!!!", "*** CADASTRO DE CLIENTE ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                btnLimpar_Click(sender, e);
                if (!objDados.IsClosed)    { objDados.Close();  }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message,
                    "*** ADO.NET ***",
                    MessageBoxButtons.OK);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from Cadastro where Codigo=" + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código Inexistente!!", "*** CONSULTAGEM ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    if (!objDados.IsClosed)    { objDados.Close();   }

                    strSql = "Update Cadastro set ";

                    strSql += "Nome = '" + txtNome.Text + "',";
                    strSql += "RG = '" + txtRG.Text + "',";
                    strSql += "CPF = '" + txtCPF.Text + "',";
                    strSql += "Telefone = '" + txtTelefone.Text + "',";
                    strSql += "Sexo = '" + sexo.ToString() + "',";
                    strSql += "CEP = '" + txtCEP.Text + "',";
                    strSql += "Número = '" + txtNumero.Text + "',";
                    strSql += "Logradouro = '" + txtLogradouro.Text + "',";
                    strSql += "Bairro = '" + txtBairro.Text + "',";
                    strSql += "Cidade = '" + txtCidade.Text + "',";
                    strSql += "Email = '" + txtEmail.Text + "',";
                    strSql += "Facebook = '" + txtFacebook.Text + "',";
                    strSql += "Twitter = '" + txtTwitter.Text + "'";
                    strSql += "where Codigo=" + txtCodigo.Text;

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro Alterado com Sucesso!!!", "*** ADO.NET ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    btnLimpar_Click(sender, e);
                    if (!objDados.IsClosed)    { objDados.Close();   }
               }
            }
            catch (SqlException Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsulta Consulta = new FrmConsulta();
            Consulta.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string srtSql = "Select * From Cadastro where Codigo=" + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = srtSql;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código não Cadastrado!!!\n\nTente novamente...", "*** CADASTRO DE CLIENTE ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    srtSql = "Delete from Cadastro where Codigo=" + txtCodigo.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = srtSql;
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Exclusão realizada com Sucesso!!!", "***Exclusão de Cliente****",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnLimpar_Click(sender, e);
                    if (!objDados.IsClosed) { objDados.Close(); }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ==> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               /* objCnx.ConnectionString = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Cadastro;Integrated
                Security=True";*/
                objCnx.ConnectionString = Properties.Settings.Default.ConexãoSQLServer;
                objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erroooooo ==> " + erro.Message, " ADO.NET ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
             try
            {
                string strSql = "Select * from Cadastro where Codigo=" + txtCodigo.Text;
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
                    txtCodigo.Focus();
                }
                else
                {
                    objDados.Read();
                    txtNome.Text = objDados["Nome"].ToString();
                    txtRG.Text = objDados["RG"].ToString();
                    txtCPF.Text = objDados["CPF"].ToString();
                    txtTelefone.Text = objDados["Telefone"].ToString();
                    sexo = objDados["Sexo"].ToString();
                    txtCEP.Text = objDados["CEP"].ToString();
                    txtNumero.Text = objDados["Número"].ToString();
                    txtLogradouro.Text = objDados["Logradouro"].ToString();
                    txtBairro.Text = objDados["Bairro"].ToString();
                    txtCidade.Text = objDados["Cidade"].ToString();
                    txtEmail.Text = objDados["Email"].ToString();
                    txtFacebook.Text = objDados["Facebook"].ToString();
                    txtTwitter.Text = objDados["Twitter"].ToString();

                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
           }

        private void rdnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";

        }

        private void rdnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";

        }        
        }
    }
