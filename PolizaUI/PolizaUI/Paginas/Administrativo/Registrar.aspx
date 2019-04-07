<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
    <link href="../../styles/registro.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div id="cuadro" class="panel panel-default">
        
            <div id="h">
                <h1 class="H1Global">Registro de Usuario Nuevo</h1>
            </div>
            
            <div class="form-horizontal">
               
                <label>Usuario<input class="form-control" type="text" runat="server" id="Txt_Usuario" onkeypress="return controlEspacio()"/></label>
                <label>Contraseña<input class="form-control" type="password" runat="server"  id="txt_Contraseña" onkeypress="return controlEspacio()" /></label>
                <label>Apellido 1<input class="form-control" type="text" runat="server"  id="Txt_ape1" onkeypress="return controlEspacio()" /></label>    
                            
            </div>
            <div class="row">
                <br />
            </div>
            <div class="form-horizontal">  
            <label>Apellido 2<input class="form-control" type="text" runat="server"  id="txt_ape2" onkeypress="return controlEspacio()"/></label>    
            <label>Nombre<input class="form-control" type="text" runat="server" id="Txt_N" onkeypress="return controlEspacio()" /></label>
            <label>Cédula<input class="form-control" type="text" runat="server"  id="Txt_C" onkeypress="return controlEspacio()" /></label>
            
            </div>
                <div class="row">
                    <br />
                </div>
            <div class="form-horizontal">
              <label>Fecha de nacimiento<input class="form-control" type="date" runat="server"  id="Text6"/></label>
                     
            <label><div class="dropdown">
  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">Provincia
  <span class="caret"></span></button>
  <ul class="dropdown-menu">
    <li><a href="#">HTML</a></li>
    <li><a href="#">CSS</a></li>
    <li><a href="#">JavaScript</a></li>
  </ul>
</div></label>
<label class="col-4"><div class="dropdown">
  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">Cantón
  <span class="caret"></span></button>
  <ul class="dropdown-menu">
    <li><a href="#">HTML</a></li>
    <li><a href="#">CSS</a></li>
    <li><a href="#">JavaScript</a></li>
  </ul>
</div></label>  
<label><div class="dropdown">
  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">Distrito
  <span class="caret"></span></button>
  <ul class="dropdown-menu">
    <li><a href="#">HTML</a></li>
    <li><a href="#">CSS</a></li>
    <li><a href="#">JavaScript</a></li>
  </ul>
</div></label>
 <label><div class="dropdown">
  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">Genero
  <span class="caret"></span></button>
  <ul class="dropdown-menu">
    <li><a href="#">HTML</a></li>
    <li><a href="#">CSS</a></li>
    <li><a href="#">JavaScript</a></li>
  </ul>
</div></label>           
            </div>
<br/>
  <div class="form-horizontal">
  <label>Apoderado<input type="text" class="form-control" runat="server"  disabled="disabled"  id="txt_A" onkeypress="return controlEspacio()" /></label>  
  </div>               
<br />
 <div class="row">
     <label class="col-5">Usuario Admin </label><input class="checkbox; col-4"  type="checkbox" runat="server"  id="chk_A" />
</div>
</div>
</asp:Content>
