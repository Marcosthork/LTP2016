<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPegaSession.aspx.cs" Inherits="SistemaTesteAulaLTP.frmPegaSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Seja bem-vindo
        <asp:Label ID="lblNomeUsuario" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        Visitas:
        <asp:Label ID="lblVisitas" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
        <asp:Button ID="btnSair" runat="server" OnClick="btnSair_Click" Text="Sair" />
    
    </div>
    </form>
</body>
</html>
