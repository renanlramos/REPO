<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 class="auto-style3">Sistema de Posts</h2>
    
    </div>
        <div class="auto-style3">
            <asp:HyperLink ID="hplCadastrar" runat="server" NavigateUrl="~/Cadastrar.aspx">Cadastro de Novo Post</asp:HyperLink>
            <strong><em>
            <br />
            <br />
            </em></strong>
            <asp:HyperLink ID="hplCadastroAutor" runat="server" NavigateUrl="~/CadastroAutor.aspx">Cadastro de Novos Autores</asp:HyperLink>
            <strong><em>
            <br />
            <br />
            <asp:DataList ID="dtlPosts" runat="server">
                <ItemTemplate>
                    <strong><em>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval ("titulo") %>'></asp:Label>
                    </em></strong>
                </ItemTemplate>
            </asp:DataList>
            <br />
            <br />
            Desenvolvido por Renan Ramos</em></strong></div>
    </form>
</body>
</html>
