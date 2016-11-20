<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadAluno.aspx.cs" Inherits="SistemaTesteAulaLTP.frmCadAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/estiloCelular.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="icones/sites.png" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnChamarVetor" runat="server" OnClick="btnChamarVetor_Click" Text="Chamar Vetor" />
        <br />
        ListBox com List&lt;T&gt;<br />
        <asp:ListBox ID="lstUsuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <br />
        <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        DropDownList com List&lt;T&gt;<br />
        <asp:DropDownList ID="ddlUsuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUsuarios_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
