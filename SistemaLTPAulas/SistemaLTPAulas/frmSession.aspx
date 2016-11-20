<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSession.aspx.cs" Inherits="SistemaTesteAulaLTP.frmSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuário:
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        Senha:
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="Logar" />
        <br />
        <asp:CheckBox ID="chkManterLogado" runat="server" Text="Manter Logado" />
        <br />
        Visitas: <asp:Label ID="lblVisitas" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
