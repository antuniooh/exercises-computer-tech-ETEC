<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sortear_Imagem.aspx.cs" Inherits="Aula04_AspNet_23082017.Sortear_Imagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Para sortear imagem clique no botão:<br />
        <br />
        <asp:Button ID="btnSortear" runat="server" OnClick="btnSortear_Click" Text="Sortear Imagem" Width="223px" />
        <br />
        <br />
        <asp:Image ID="imgSortear" runat="server" Height="124px" ImageUrl="~/Imagem/Figura0.jpg" Width="219px" />
    
    </div>
    </form>
</body>
</html>
