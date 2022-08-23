<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="presentacion.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="resources/css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css" />
</head>
<body>
    <div class="container well contenedor">
        <div class="row">
            <div class="col-xs-12">
                <h2>Iniciar Sesion</h2>
            </div>
        </div>
        <form id="form1" runat="server">

        <div class="form-group">
            <asp:Label ID="lblCedula" runat="server" Text="Cedula" CssClass="control-label col-sm-2"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

            <div class="form-group">
                <asp:Label ID="lblClave" runat="server" Text="Clave" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar" OnClick="btnIniciar_Click" CssClass="form-control btn btn-primary" />
            </div>
        </form>
    </div>
</body>
</html>
