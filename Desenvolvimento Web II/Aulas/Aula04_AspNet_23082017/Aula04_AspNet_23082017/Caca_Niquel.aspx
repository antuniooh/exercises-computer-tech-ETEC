<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caca_Niquel.aspx.cs" Inherits="Aula04_AspNet_23082017.Caca_Niquel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblA" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblB" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblC" runat="server" Text="0"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGirar" runat="server" OnClick="btnGirar_Click" Text="Girar" Width="129px" />
        <br />
        <br />
&nbsp;<asp:Label ID="lblSaida" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
