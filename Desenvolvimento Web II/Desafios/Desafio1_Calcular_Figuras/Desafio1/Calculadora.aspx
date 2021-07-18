<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Desafio1.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Desafio 1<br />
        <asp:Label ID="lblRotulo" runat="server"></asp:Label>
        <br />
        <br />
        Figura:<br />
        <asp:RadioButton ID="rdnQuadrado" runat="server" AutoPostBack="True" GroupName="grpFiguras" Text="Quadrado" OnCheckedChanged="rdnQuadrado_CheckedChanged" />
        <br />
        <asp:RadioButton ID="rdnRetangulo" runat="server" AutoPostBack="True" GroupName="grpFiguras" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Retangulo" />
        <br />
        <asp:RadioButton ID="rdnTriangulo" runat="server" AutoPostBack="True" GroupName="grpFiguras" Text="Triangulo" OnCheckedChanged="rdnTriangulo_CheckedChanged" />
        <br />
        <asp:RadioButton ID="rdnParalelograma" runat="server" AutoPostBack="True" GroupName="grpFiguras" Text="Paralelograma" OnCheckedChanged="rdnParalelograma_CheckedChanged" />
        <br />
        <br />
        Opção:<br />
        <asp:RadioButton ID="rdnArea" runat="server" AutoPostBack="True" GroupName="grpCalculo" Text="Area" />
        <br />
        <asp:RadioButton ID="rdnPerimetro" runat="server" AutoPostBack="True" GroupName="grpCalculo" Text="Perimetro" />
        <br />
        <br />
        Valores:<br />
        <asp:TextBox ID="txtBase" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAltura" runat="server" OnTextChanged="txtAltura_TextChanged"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Base&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAltura" runat="server" Text="Altura"></asp:Label>
        <br />
        <br />
        Resultado:<br />
        <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
    
    </div>
    </form>
</body>
</html>
