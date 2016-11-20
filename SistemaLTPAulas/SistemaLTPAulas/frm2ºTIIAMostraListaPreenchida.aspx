<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm2ºTIIAMostraListaPreenchida.aspx.cs" Inherits="SistemaTesteAulaLTP.frm2ºTIIAMostraListaPreenchida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cadastro de Usuário com carregamento de Listas<br />
        <br />
        Usuarios:
        <asp:ListBox ID="lstUsuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstUsuarios_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        Logradouros:<asp:DropDownList ID="ddlLogradouros" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        ID: <asp:Label ID="lblID" runat="server"></asp:Label>
        <br />
        Texto:
        <asp:Label ID="lblTexto" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" />
        <br />
    
    </div>
    </form>
</body>
</html>
