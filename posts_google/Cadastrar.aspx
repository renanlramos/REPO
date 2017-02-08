<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style="text-align: center">Cadastro de Posts</h2>
        <p style="text-align: center">
            <asp:HyperLink ID="hplVoltardoCadastro" runat="server" NavigateUrl="~/index.aspx">&lt;&lt;Voltar</asp:HyperLink>
        </p>
        <p class="auto-style2">
&nbsp;
            <asp:Label ID="lblAutor" runat="server" Text="Autor:"></asp:Label>
            <asp:TextBox ID="txtbAutor" runat="server" Width="204px"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
            <asp:TextBox ID="txtbTitulo" runat="server" Width="204px"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:Label ID="lblConteudo" runat="server" style="text-align: left" Text="Conteúdo:"></asp:Label>
            <asp:TextBox ID="txtbConteudo" runat="server" Height="261px" TextMode="MultiLine" Width="387px"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-style: italic" Text="Desenvolvido por Renan Ramos"></asp:Label>
        </p>
    </form>
</body>
</html>
