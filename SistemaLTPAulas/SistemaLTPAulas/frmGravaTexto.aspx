<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGravaTexto.aspx.cs" Inherits="SistemaTesteAulaLTP.frmGravaTexto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<table>
<tr><td>Nome do Drive:</td><td>
<asp:Label ID="lblDriveName"
runat="server" Text="Label" />
</td></tr>
<tr><td>Tipo do Drive:</td><td>
<asp:Label ID="lblDriveType"
runat="server" Text="Label"/>
</td></tr>
<tr><td>Espaço Avaliado:</td><td>
<asp:Label ID="lblAvailableFreeSpace"
runat="server" Text="Label" />
</td></tr>
<tr><td>Formato do Drive:</td><td>
<asp:Label ID="lblDriveFormat"
runat="server" Text="Label" />
</td></tr>
<tr><td>Espaço Total</td><td>
<asp:Label ID="lblTotalFreeSpace" runat="server" Text="Label" />
    </td></tr>
<tr><td>Tamanho Total:</td><td>
<asp:Label ID="lblTotalSize"
runat="server" Text="Label" />
</td></tr>
<tr><td>Nome do Volume</td><td>
<asp:Label ID="lblVolumeLabel"
runat="server" Text="Label" />
</td></tr>
</table>
        <br />
        <asp:Button ID="btnCriaDiretorio" runat="server" OnClick="btnCriaDiretorio_Click" Text="Cria Diretorio" />
        <asp:Button ID="btnApagaDiretorio" runat="server" OnClick="btnApagaDiretorio_Click" Text="Apaga Diretorio" />
        <br />
        DataCriação: <asp:Label ID="lblDataCriacaoDir" runat="server"></asp:Label>
        <br />
        Último Acesso:
        <asp:Label ID="lblUltimoAcesso" runat="server"></asp:Label>
        <br />
        Última Gravação: <asp:Label ID="lblUltimaGravacao" runat="server"></asp:Label>
        <br />
        <br />
</div>
        <br />
        <div>
    
        Observação:
        <asp:TextBox ID="txtObsrvacao" runat="server" Height="143px" TextMode="MultiLine" Width="436px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="txtGravaArquivo" runat="server" OnClick="txtGravaArquivo_Click" Text="Gravar em Arquivo" />
    
            
    
            <asp:Button ID="btnLerArquivo" runat="server" OnClick="btnLerArquivo_Click" Text="Ler Arquivo" />
    
            
    
            <asp:Button ID="btnApagaArquivo" runat="server" OnClick="btnApagaArquivo_Click" Text="Apaga Arquivo" />
    
            
    
    </div>
        <br />
        <div>
            Localização: <asp:Label ID="lblLocation" runat="server" /><br />
            Tamanho: <asp:Label ID="lblSize" runat="server" /><br />
            Criado: <asp:Label ID="lblCreated" runat="server" /><br />
            Modificado: <asp:Label ID="lblModified" runat="server" /><br />
            Acessado: <asp:Label ID="lblAccessed" runat="server" /><br />
            Atributos: <asp:Label ID="lblAttributes" runat="server" /><br />


            <br />
            <br />
            <br />


Resultado: <asp:Label runat="server" ID="lblResult" />
</div>
    </form>
</body>
</html>
