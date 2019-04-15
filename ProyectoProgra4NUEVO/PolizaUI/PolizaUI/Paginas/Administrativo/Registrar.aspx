<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Registrar" %>
<!DOCTYPE>
<html>
<head>
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
    <link href="../../styles/registro.css" rel="stylesheet" type="text/css" />
    </head>
    <body>

            <form runat="server" id="cuadro" class="panel panel-default">

        <div id="h">
            <h1 class="H1Global">Registro de Usuario Nuevo</h1>
        </div>

        <div class="form-horizontal">

            <label>Usuario<input class="form-control" type="text" runat="server" id="Txt_Usuario" onkeypress="return controlEspacio()" /></label>
            <label>Contraseña<input class="form-control" type="password" runat="server" id="txt_Contraseña" onkeypress="return controlEspacio()" /></label>
            <label>Nombre<input class="form-control" type="text" runat="server" id="Txt_N" onkeypress="return controlEspacio()" /></label>


        </div>
        <div class="row">
            <br />
        </div>
        <div class="form-horizontal">
            <label>Primer Apellido<input class="form-control" type="text" runat="server" id="Txt_ape1" onkeypress="return controlEspacio()" /></label>
            <label>Segundo Apellido<input class="form-control" type="text" runat="server" id="txt_ape2" onkeypress="return controlEspacio()" /></label>
            <label>Cédula o  Identificación<input class="form-control" type="text" runat="server" id="Txt_C" onkeypress="return controlEspacio()" /></label>

        </div>
        <div class="row">
            <br />
        </div>
        <div class="form-horizontal">
            <label>Fecha de nacimiento<input class="form-control" type="date" runat="server" id="Text6" /></label>

            <asp:DropDownList Style="background-color: #104b59;" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:ListItem Text="Provincia" Value="0"></asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList Style="background-color: #104b59;" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:ListItem Text="Cantón" Value="0"></asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList Style="background-color: #104b59;" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:ListItem Text="Distrito" Value="0"></asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList Style="background-color: #104b59;" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:ListItem Text="Género" Value="0"></asp:ListItem>
            </asp:DropDownList>

        </div>
        <br />
        <div class="form-horizontal">
            <label>Apoderado<input type="text" class="form-control" runat="server" disabled="disabled" id="txt_A" onkeypress="return controlEspacio()" /></label>

            <asp:DropDownList Style="background-color: #104b59;" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:ListItem Text="Tipo de Identificación" Value="0"></asp:ListItem>
            </asp:DropDownList>

        </div>
        <br />
        <div class="row">
            <label class="col-5">Usuario Admin </label>
            <input class="checkbox; col-4" type="checkbox" runat="server" id="chk_A" />
        </div>
        <br />
        <div class="row">
            <p class="col-6">
                <input type="button" runat="server" value="Registrarse" class="btn btn-group-lg" id="btn_S" />
                <a href="Login.aspx">Ya tienes un Usuario? ingresa desde acá</a>
            </p>

        </div>

    </form>
</body>
</html>
