<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="Aula01_ASPNET_190717.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Digite um numero desejado:
        <asp:TextBox ID="txtEntrada" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        
        <asp:Button ID="BtnCalcular" runat="server" OnClick="BtnCalcular_Click" Text="Calcular" />
        <br />
        <br />
        <asp:Label ID="LblSaida1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida5" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida6" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida7" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida8" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida9" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida10" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblSaida11" runat="server"></asp:Label>
    
        
    </div>
    </form>
</body>
</html>
