<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link type="text/css" rel="stylesheet" href="content/bootstrap.min.css" />
</head>
<script src="Scripts/jquery-1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes do cliente</h3>
                    <br />
                    <br />
                    <asp:TextBox ID="txtCodigo" runat="server" placeholder="" Width="5%" CssClass="form-control" />
                    <br />
                    <asp:Button ID="btnPesquisar" runat="server" CssClass="btn btn-info" Text="Pesquisar" />
                    <br />
                    <br />
                    <asp:TextBox ID="TextNome" runat="server" placeholder="Nome do cliente" Width="45%" CssClass="form-control" />
                    <br />
                    <br />
                    <asp:TextBox ID="TextEndereco" runat="server" placeholder="Endereco do cliente" Width="50%" CssClass="form-control" />
                    <br />
                    <br />
                    <asp:TextBox ID="TextEmail" runat="server" placeholder="Email do cliente" Width="25%" CssClass="form-control" />
                    <br />
                    <br />
                    <asp:Button ID="btnExclui" runat="server" CssClass="btn btn-danger" Text="Excluir" />
                    <asp:Button ID="btnAtualiza" runat="server" CssClass="btn btn-warning" Text="Atualizar" />
                    <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
