<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matriz_Venda.aspx.cs" Inherits="Aula03_AspNet_09082017.Matriz_Venda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Número do Vendedor:&nbsp;&nbsp;
        <asp:TextBox ID="txtVendedor" runat="server"></asp:TextBox>
        <br />
        <br />
        Número do Produto:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProduto" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnTotalVendedor" runat="server" OnClick="btnTotalVendedor_Click" Text="Total por Vendedor" />
        <br />
        <br />
        <asp:Button ID="btnTotalProduto" runat="server" OnClick="btnTotalProduto_Click" Text="Total por Produto" />
        <br />
        <br />
        <asp:Button ID="btnTotalV" runat="server" OnClick="btnTotalV_Click" Text="Total Vendido" Width="150px" />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
