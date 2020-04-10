<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="content/bootstrap.min.css" />
</head>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto CRUD - Controle de Clientes</h1>

            Selecione a opção desejada
            <asp:DropDownList ID="ddlMenu" runat="server" >
                <asp:ListItem Value="0" text=" - Escolha uma opção         - " />
                <asp:ListItem Value="1" text="Cadastrar Clientes" />
                <asp:ListItem Value="2" text="Consultar clientes" />
                <asp:ListItem Value="3" text="Obter os dados do cliente" />
            </asp:DropDownList>

            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar" />

            <p>

                <asp:Label ID="lblMensagem" runat="server" />

            </p>
        </div>
    </form>
</body>
</html>
