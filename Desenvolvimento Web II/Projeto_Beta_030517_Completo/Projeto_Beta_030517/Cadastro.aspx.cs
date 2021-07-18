using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb; // Biblioteca que manipula o  Office

namespace Projeto_Beta_030517
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Session["controle"] == "Cadastrado")
                {
                    txtNome_Cliente.Text = Session["nome"].ToString();
                    txtEndereco_Cliente.Text = Session["endereco"].ToString();
                    txtUser_Cliente.Text = Session["user"].ToString();
                    txtSenha_Cliente.Text = Session["senha"].ToString();
                    DrpStatus_Cliente.Text = Session["status"].ToString();

                    BtnSalvar.Enabled = false;
                    BtnAlterar.Enabled = true; 
                }
                
                if (Session["controle"] == "Novo")
                {
                    txtNome_Cliente.Text = "";
                    txtSenha_Cliente.Text = "";
                    txtUser_Cliente.Text = "";
                    DrpStatus_Cliente.Text = "";

                    BtnSalvar.Enabled = true;
                    BtnAlterar.Enabled = false;

                    Session["controle"] = ("Cadastrado");
                }
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha_Cliente.Text == txtConfSenha.Text)
                {
                    OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // objeto com endereço de conexao
                    String Valor = "INSERT INTO TB_CLIENTE (NOME_CLIENTE, END_CLIENTE, USER_CLIENTE, SENHA_CLIENTE, STATUS_CLIENTE) values ('" + txtNome_Cliente.Text + "','" + txtEndereco_Cliente.Text + "','" + txtUser_Cliente.Text + "','" + txtConfSenha.Text + "','" + DrpStatus_Cliente.Text + "')";
                    String valor2 = "SELECT USER_CLIENTE FROM TB_CLIENTE Where USER_CLIENTE='" + txtUser_Cliente.Text + "'";

                    OleDbCommand verificar = new OleDbCommand(valor2, conexao);
                    OleDbCommand gravar = new OleDbCommand(Valor, conexao); //Objeto comando sql

                    OleDbDataReader objDataReader = null;
                    conexao.Open();
                    objDataReader = verificar.ExecuteReader();

                    if (objDataReader.Read() == true)
                    {
                        LblMsg_Cadastro.Text = "Usuario já existe, favor alterar";
                    }
                    else
                    {
                        gravar.ExecuteNonQuery(); // Executa a query
                        LblMsg_Cadastro.Text = "Cliente cadastrado com sucesso!";

                    }
                    objDataReader.Close();
                    conexao.Close(); // Fecha banco    
                }
                else
                {
                    LblMsg_Cadastro.Text = "Senha, não confere!";

                }
            }
            catch (OleDbException)
            {
                LblMsg_Cadastro.Text = "erro ao acessar o banco de dados";
            }
        }
        
        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha_Cliente.Text == txtConfSenha .Text )
                {
                    OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // objeto com endereço de conexao

                    string codigo = Session["idcliente"].ToString();
                    String Valor = "UPDATE TB_CLIENTE SET NOME_CLIENTE='" + txtNome_Cliente.Text + "', END_CLIENTE='" + txtEndereco_Cliente.Text + "', USER_CLIENTE='" + txtUser_Cliente.Text + "', SENHA_CLIENTE='" + txtConfSenha .Text  + "', STATUS_CLIENTE='" + DrpStatus_Cliente.Text + "' Where ID_CLIENTE=" + codigo;

                    OleDbCommand alterar = new OleDbCommand(Valor, conexao); //Objeto comando sql
                    conexao.Open(); // Abri o SGBD
                    alterar.ExecuteNonQuery(); // Executa a Querry dentro do Banco
                    conexao.Close(); // Fecha a conexao com SGBD
                    LblMsg_Cadastro.Text = "Cadastro alterado com sucesso!";
                }
                else
                {
                    LblMsg_Cadastro.Text = "Senha do usuario não confere";
                }
            }
            catch (OleDbException)
            {
                LblMsg_Cadastro.Text = "erro ao acessar o banco de dados";
            }
        }
    }
}