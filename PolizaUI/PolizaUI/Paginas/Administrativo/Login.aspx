<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Login" %>
<asp:Content ID="Login_head" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <link rel="stylesheet" href="../../styles/Login.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <br>
    <br>
    <div>
        <form>
            <div id="h">
                <h1 class="H1Global">Login</h1>
            </div>
  <div class="form-group">
    <label>Usuario:</label>
    <input type="text" runat="server" class="form-control" id="txt_U" onkeypress="return controlEspacio()"/>
  </div>
  <div class="form-group">
    <label>Contraseña:</label>
    <input runat="server" type="password" autocomplete="on" class="form-control" id="txt_P" onkeypress="return controlEspacio()"/>
  </div>
  <div class="checkbox">
    <label><input id="chk" type="checkbox"/> Recuerdame</label>
  </div>
  <button type="button" runat="server" class="btn btn-default" onclick="validarCookies()">Ingresar</button>
   <div>
       <p >No tienes cuenta? <a href="Registrar.aspx">Crea una nueva cuenta aqui</a></p>
   </div>
</form>
    </div>
</asp:Content>
