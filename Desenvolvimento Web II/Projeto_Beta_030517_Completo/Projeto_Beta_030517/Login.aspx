<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto_Beta_030517.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuário:&nbsp;
        <asp:TextBox ID="txtUser_Login" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp; Senha:&nbsp;
        <asp:TextBox ID="txtSenha_Login" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
        <asp:Button ID="BtnLogin" runat="server" Text="Logar" OnClick="BtnLogin_Click" />
&nbsp;
        <asp:Button ID="BtnCadastro" runat="server" OnClick="BtnCadastro_Click" Text="Cadastro" />
        <br />
        <br />
        <asp:Label ID="LblMsg_Login" runat="server"></asp:Label>
        <br />
        <br />
        <asp:AccessDataSource ID="UserAccess" runat="server" DataFile="~/dbCadastro.mdb" SelectCommand="SELECT [ID_CLIENTE], [NOME_CLIENTE], [END_CLIENTE], [USER_CLIENTE], [SENHA_CLIENTE], [STATUS_CLIENTE] FROM [TB_CLIENTE]"></asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
