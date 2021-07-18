<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cronometro.aspx.cs" Inherits="Aula03_AspNet_02082017.Cronometro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Segundos:"></asp:Label>
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <asp:Button ID="btnConverter" runat="server" OnClick="btnConverter_Click" Text="Converter" />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
