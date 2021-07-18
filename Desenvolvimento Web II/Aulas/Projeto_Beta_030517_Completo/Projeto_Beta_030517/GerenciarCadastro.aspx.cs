using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb; // Bilioteca que nanipula o Office - Access

namespace Projeto_Beta_030517
{
    public partial class GerenciarCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        public void limpar()
        {
            txtIdCliente_Cadastro.Text = null;
            txtNome_Cadastro.Text = null;
            txtEndereco_Cadastro.Text = null;
            txtUser_Cadastro.Text = null;
            DrpStatus_Cadastro.Text = "";
            txtIdCliente_Cadastro.Focus(); 
        }

        protected void BtnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        

        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // Objeto de Conexao

                String Valor = "UPDATE TB_CLIENTE SET NOME_CLIENTE='" + txtNome_Cadastro.Text + "', END_CLIENTE='" + txtEndereco_Cadastro.Text + "',  STATUS_CLIENTE='" + DrpStatus_Cadastro.Text + "' Where ID_CLIENTE=" + txtIdCliente_Cadastro.Text; 
                
                OleDbCommand alterar = new OleDbCommand(Valor, conexao);//obj com os comandos sql

                conexao.Open(); // abri o banco
               
                alterar.ExecuteNonQuery(); // Executa a query
                LblMsg.Text = "Cliente alterado com sucesso!";
                limpar();
                
                conexao.Close(); // Fecha banco        
                GridView1.DataBind();
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
            }
            catch (OleDbException)
            {
                LblMsg.Text = "erro ao acessar o banco de dados";
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // Objeto de Conexao
                
                String Valor = "INSERT INTO TB_CLIENTE (NOME_CLIENTE, END_CLIENTE, USER_CLIENTE, SENHA_CLIENTE, STATUS_CLIENTE) VALUES ('" + txtNome_Cadastro .Text  + "','" + txtEndereco_Cadastro .Text + "','" + txtUser_Cadastro .Text  + "','123','" + DrpStatus_Cadastro .Text + "')";
                String valor2 = "SELECT USER_CLIENTE FROM TB_CLIENTE Where USER_CLIENTE='" + txtUser_Cadastro .Text  + "'";

                OleDbCommand verificar = new OleDbCommand(valor2, conexao);
                OleDbCommand gravar = new OleDbCommand(Valor, conexao);//obj com os comandos sql

                OleDbDataReader objDataReader = null;

                conexao.Open(); // abri o banco
                objDataReader = verificar.ExecuteReader ();

                if (objDataReader.Read() == true)
                {
                    LblMsg.Text = "Usuario já existe, favor alterar";
                }
                else
                {
                    gravar.ExecuteNonQuery(); // Executa a query
                    LblMsg.Text = "Cliente cadastrado com sucesso!";
                    
                    limpar();
                }
                objDataReader.Close();
                conexao.Close(); // Fecha banco        
                GridView1.DataBind();
            }
            catch (OleDbException)
            {
                LblMsg.Text = "erro ao acessar o banco de dados";
            }
        }

        protected void BtnLocalizar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // endereço de conexao
            try
            {
                
                String valor = "SELECT ID_CLIENTE, NOME_CLIENTE, END_CLIENTE, USER_CLIENTE, STATUS_CLIENTE FROM TB_CLIENTE WHERE ID_CLIENTE=" + txtIdCliente_Cadastro.Text; //Querry de Consulta

                conexao.Open(); // Abri o banco 
                OleDbCommand objCommand = new OleDbCommand(valor, conexao); // Commando querry
                OleDbDataReader objDataReader = null; // Carrega vazio 

                objDataReader = objCommand.ExecuteReader(); //  Somente a leitura
                limpar();
                if (objDataReader.Read() == true)
                {
                    txtIdCliente_Cadastro.Text += objDataReader["ID_CLIENTE"];
                    txtNome_Cadastro.Text += objDataReader["NOME_CLIENTE"];
                    txtEndereco_Cadastro.Text += objDataReader["END_CLIENTE"];
                    txtUser_Cadastro.Text += objDataReader["USER_CLIENTE"];
                    DrpStatus_Cadastro.Text += objDataReader["STATUS_CLIENTE"];
                    GridView1.DataBind();// Navegação no  data grid
                }
                else
                {
                    LblMsg.Text = "Id não Localizado";
                }
               
                objDataReader.Close();
                conexao.Close();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;

            }
            catch (OleDbException)
            {
                LblMsg.Text = "Erro ao localizar dados no banco";
            }
        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // Objeto de Conexao
                String Valor = "DELETE FROM TB_CLIENTE where ID_CLIENTE=" + txtIdCliente_Cadastro .Text;

                OleDbCommand excluir = new OleDbCommand(Valor, conexao);//obj com os comandos sql
                conexao.Open(); // abri o banco
                excluir.ExecuteNonQuery(); // Executa a query
                conexao.Close(); // Fecha banco
                LblMsg.Text = "Cadastro excluido com sucesso!";
                GridView1.DataBind();
                BtnExcluir.Enabled = false;
                BtnAlterar.Enabled = false;
                limpar();
            }
            catch (OleDbException)
            {
                LblMsg.Text = "erro ao acessar o banco de dados";
            }
        }
        
    }
}