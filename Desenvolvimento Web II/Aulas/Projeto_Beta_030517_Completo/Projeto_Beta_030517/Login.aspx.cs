using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb; //Biblioteca que manipula o Office - Access
namespace Projeto_Beta_030517
{
    public partial class Login : System.Web.UI.Page
    {
        string[] arrayClientes = new string[6]; // Array - vetor dados
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            Session["controle"] = ("Novo");
            Response.Redirect("Cadastro.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection(UserAccess.ConnectionString.ToString()); // endereço de conexao
            try 
            {
                String valor = "SELECT ID_CLIENTE, NOME_CLIENTE, END_CLIENTE,USER_CLIENTE, SENHA_CLIENTE, STATUS_CLIENTE FROM TB_CLIENTE WHERE USER_CLIENTE='" +txtUser_Login .Text +"' AND SENHA_CLIENTE='" +txtSenha_Login .Text +"'"; //Querry de Consulta

                conexao .Open (); // Abri o banco 
                OleDbCommand objCommand = new OleDbCommand (valor , conexao ); // Commando querry
                OleDbDataReader objDataReader = null; // Carrega vazio 

                objDataReader = objCommand .ExecuteReader (); //  Somente a leitura

                if (objDataReader.Read() == true)
                {
                    arrayClientes[0] += objDataReader["ID_CLIENTE"];
                    Session["idcliente"] = arrayClientes[0];

                    arrayClientes[1] += objDataReader["NOME_CLIENTE"];
                    Session["nome"] = arrayClientes[1];

                    arrayClientes[2] += objDataReader["END_CLIENTE"];
                    Session["endereco"] = arrayClientes[2];

                    arrayClientes[3] += objDataReader["USER_CLIENTE"];
                    Session["user"] = arrayClientes[3];

                    arrayClientes[4] += objDataReader["SENHA_CLIENTE"];
                    Session["senha"] = arrayClientes[4];

                    arrayClientes[5] += objDataReader["STATUS_CLIENTE"];
                    Session["status"] = arrayClientes[5];

                    Session["controle"] = ("Cadastrado");

                    Response.Redirect("Cadastro.aspx");
                }
                else
                {
                    LblMsg_Login.Text = "Senha e/ou usuario não confere";
                }
                objDataReader.Close();
                conexao.Close(); 
            }
            catch (OleDbException)
            {
                LblMsg_Login .Text = "Erro ao localizar dados no banco";
            }
            
        }
    }
}