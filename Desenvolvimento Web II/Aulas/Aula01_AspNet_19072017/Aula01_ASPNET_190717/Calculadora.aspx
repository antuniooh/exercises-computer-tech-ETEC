<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Aula01_ASPNET_190717.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Calculadora:<br />
        Operação<br />
        <asp:Label ID="LblRótulo" runat="server"></asp:Label>
        <br />
        <br />
        Opção:<br />
        <br />
        <asp:RadioButton ID="RdnADD" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Adição" />
        <br />
        <asp:RadioButton ID="RdnSub" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Subtração" />
        <br />
        <asp:RadioButton ID="RdnMulti" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Multiplicação" />
        <br />
        <asp:RadioButton ID="RdnDiv" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Divisão" />
        <br />
        <asp:RadioButton ID="RdnResto" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Resto da Divisão" />
        <br />
        <asp:RadioButton ID="RdnPotencia" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Potenciação " />
        <br />
        <asp:RadioButton ID="RdnRaiz" runat="server" AutoPostBack="True" GroupName="GrpOperacao" OnCheckedChanged="ItemOpcao" Text="Radiciação" />
        <br />
        <br />
        Valor:<br />
        <asp:TextBox ID="TxtValor1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TxtValor2" runat="server" Height="22px"></asp:TextBox>
        <br />
        <br />
        Resultado:<br />
        <asp:Label ID="LblResultado" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="BtnCalcular" runat="server" OnClick="BtnCalcular_Click" Text="Calcular" />
    
    </div>
    </form>
    <p>
        <br />
    </p>
</body>
</html>
