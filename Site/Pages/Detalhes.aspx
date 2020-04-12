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
                    Informe o código.<br />
                    <asp:TextBox ID="txtCodigo" runat="server" placeholder="" Width="5%" CssClass="form-control" />
                    <br />
                    <asp:Button ID="btnPesquisar" runat="server" CssClass="btn btn-info" Text="Pesquisar" OnClick="btnPesquisarCliente" />

                    <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="pnlDados" runat="server">
                        Nome do cliente:
                        <br />
                        <asp:TextBox ID="txtNome" runat="server" placeholder="" Width="45%" CssClass="form-control" />
                        <br />
                        <br />
                        Endereço do cliente:
                        <br />
                        <asp:TextBox ID="txtEndereco" runat="server" placeholder="" Width="50%" CssClass="form-control" />
                        <br />
                        <br />
                        E-mail do cliente:
                        <br />
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="" Width="25%" CssClass="form-control" />
                        <br />
                        <br />
                        <asp:Label ID="lblMensagem" runat="server" />

                        <asp:Button ID="btnExclui" runat="server" CssClass="btn btn-danger" Text="Excluir" OnClick="btnExcluirCliente" />

                        <asp:Button ID="btnAtualiza" runat="server" CssClass="btn btn-primary" Text="Atualizar" OnClick="btnAtualizarCliente" />


                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
