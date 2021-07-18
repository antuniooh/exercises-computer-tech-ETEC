<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="EX02_Aula02_AspNet_18072017.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Digite o número desejado:
        <asp:TextBox ID="TXTEntrada" runat="server" Width="147px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTNCalcular" runat="server" OnClick="BTNCalcular_Click" Text="Calcular" />
        <br />
        <br />
        <asp:Label ID="LBLsaída1" runat="server"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="LBLsaída2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída5" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída6" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída7" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída8" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída9" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LBLsaída10" runat="server"></asp:Label>
        <p>
            <asp:Label ID="LBLsaída11" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
