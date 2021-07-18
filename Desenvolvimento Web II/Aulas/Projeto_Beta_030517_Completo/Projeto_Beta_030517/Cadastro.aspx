<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto_Beta_030517.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Dados do Cliente:<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Nome:
        <asp:TextBox ID="txtNome_Cliente" runat="server" Width="414px"></asp:TextBox>
        <br />
        <br />
        Endereço: <asp:TextBox ID="txtEndereco_Cliente" runat="server" Width="414px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Usuário:
        <asp:TextBox ID="txtUser_Cliente" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Senha:
        <asp:TextBox ID="txtSenha_Cliente" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Status:
        <asp:DropDownList ID="DrpStatus_Cliente" runat="server">
            <asp:ListItem>Pessoa Fisica</asp:ListItem>
            <asp:ListItem>Pessoa Juridica</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp; Confirmar Senha:
        <asp:TextBox ID="txtConfSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
&nbsp;
        <asp:Button ID="BtnAlterar" runat="server" Text="Alterar" OnClick="BtnAlterar_Click" />
        <br />
        <br />
        <asp:Label ID="LblMsg_Cadastro" runat="server"></asp:Label>
        <br />
        <br />
        <asp:AccessDataSource ID="UserAccess" runat="server" DataFile="~/dbCadastro.mdb" SelectCommand="SELECT [ID_CLIENTE], [NOME_CLIENTE], [END_CLIENTE], [USER_CLIENTE], [SENHA_CLIENTE], [STATUS_CLIENTE] FROM [TB_CLIENTE]"></asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
