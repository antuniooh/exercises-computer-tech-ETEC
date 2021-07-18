<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GerenciarCadastro.aspx.cs" Inherits="Projeto_Beta_030517.GerenciarCadastro" %>

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
        Id Cliente :
        <asp:TextBox ID="txtIdCliente_Cadastro" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="BtnLocalizar" runat="server" OnClick="BtnLocalizar_Click" Text="Localizar" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Nome:
        <asp:TextBox ID="txtNome_Cadastro" runat="server" Width="414px"></asp:TextBox>
        <br />
        <br />
        Endereço: <asp:TextBox ID="txtEndereco_Cadastro" runat="server" Width="414px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Usuário:
        <asp:TextBox ID="txtUser_Cadastro" runat="server"></asp:TextBox>
        &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Status:
        <asp:DropDownList ID="DrpStatus_Cadastro" runat="server">
            <asp:ListItem>Pessoa Fisica</asp:ListItem>
            <asp:ListItem>Pessoa Juridica</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnIncluir" runat="server" OnClick="BtnSalvar_Click" Text="Incluir" />
&nbsp;
        <asp:Button ID="BtnAlterar" runat="server" Text="Alterar" OnClick="BtnAlterar_Click" Enabled="False" />
        &nbsp;
        <asp:Button ID="BtnExcluir" runat="server" Enabled="False" Text="Excluir" OnClick="BtnExcluir_Click" />
&nbsp;
        <asp:Button ID="BtnLimpar" runat="server" OnClick="BtnLimpar_Click" Text="Limpar" />
&nbsp;
        <asp:Button ID="BtnSair" runat="server" OnClick="BtnSair_Click" Text="Sair" />
        <br />
        <br />
        <asp:Label ID="LblMsg" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="ID_CLIENTE" DataSourceID="UserAccess" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="ID_CLIENTE" HeaderText="ID_CLIENTE" InsertVisible="False" ReadOnly="True" SortExpression="ID_CLIENTE" />
                <asp:BoundField DataField="NOME_CLIENTE" HeaderText="NOME_CLIENTE" SortExpression="NOME_CLIENTE" />
                <asp:BoundField DataField="END_CLIENTE" HeaderText="END_CLIENTE" SortExpression="END_CLIENTE" />
                <asp:BoundField DataField="USER_CLIENTE" HeaderText="USER_CLIENTE" SortExpression="USER_CLIENTE" />
                <asp:BoundField DataField="STATUS_CLIENTE" HeaderText="STATUS_CLIENTE" SortExpression="STATUS_CLIENTE" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        <asp:AccessDataSource ID="UserAccess" runat="server" DataFile="~/dbCadastro.mdb" SelectCommand="SELECT [ID_CLIENTE], [NOME_CLIENTE], [END_CLIENTE], [USER_CLIENTE], [STATUS_CLIENTE] FROM [TB_CLIENTE]"></asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
