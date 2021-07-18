<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saque.aspx.cs" Inherits="Desafio2_Caixa_Eletronico.Saque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblsaque" runat="server" Text="Caixa Eletrônico"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Saque" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtsaque" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="100"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl100" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="50"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl50" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="20"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl20" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="10"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl10" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="5"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl5" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="2"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="1"></asp:Label>
&nbsp; =&nbsp;
        <asp:Label ID="lbl1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
