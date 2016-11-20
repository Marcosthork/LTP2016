<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMostraListas.aspx.cs" Inherits="SistemaTesteAulaLTP.frmMostraListas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Estado :
        <asp:ListBox ID="lstUsuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label" Visible="False"></asp:Label>
        Logradouro:
        <asp:DropDownList ID="ddlUsuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Gravar" />
    
    </div>
    </form>
</body>
</html>
