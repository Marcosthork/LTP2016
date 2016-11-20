<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmManipulaLista.aspx.cs" Inherits="SistemaTesteAulaLTP.frmManipulaLista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ID:
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        Nome:
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        RG:
        <asp:TextBox ID="txtRG" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Height="58px" OnClick="btnOK_Click" Text="OK" Width="108px" />
    
    </div>
    </form>
</body>
</html>
