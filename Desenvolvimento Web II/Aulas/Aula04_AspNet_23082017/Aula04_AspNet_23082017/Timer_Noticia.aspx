<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timer_Noticia.aspx.cs" Inherits="Aula04_AspNet_23082017.Timer_Noticia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
        Jornal Eletronico:<br />
        <asp:Timer ID="Controle" runat="server" Interval="10000" OnTick="Controle_Tick">
        </asp:Timer>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers><asp:AsyncPostBackTrigger ControlID= "Controle" /></Triggers>
            <ContentTemplate>
                <asp:Image ID="ImgNoticia" runat="server" Height="173px" ImageUrl="~/Imagem/Figura0.jpg" style="margin-bottom: 0px" Width="268px" />
                <br />
                <br />
                Noticia:<br />
                <br />
                <asp:Label ID="LblNoticia" runat="server" Text="XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
