<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
    <link href="../../styles/registro.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <br>
            <br>
            <div id="cuadro" class="panel panel-default">
        
            <div id="h">
                <h1 class="H1Global">Registro de Usuario Nuevo</h1>
            </div>
            <div class="form-horizontal">
               
                <label>Usuario<input class="form-control" type="text" runat="server" id="Txt_Usuario" onkeypress="return controlEspacio()"/></label>
                <label>Contraseña<input class="form-control" type="password" runat="server"  id="txt_Contraseña" onkeypress="return controlEspacio()" /></label>
                <label>Nombre<input class="form-control" type="text" runat="server" id="Txt_N" onkeypress="return controlEspacio()" /></label>
                <label>Telefono<input class="form-control" type="text" runat="server" id="Txtcel" onkeypress="return controlEspacio()" /></label>

                            
            </div>
            <div class="row">
                <br />
            </div>
            <div class="form-horizontal">  
             <label>Primer Apellido<input class="form-control" type="text" runat="server"  id="Txt_ape1" onkeypress="return controlEspacio()" /></label>    
            <label>Segundo Apellido<input class="form-control" type="text" runat="server"  id="txt_ape2" onkeypress="return controlEspacio()"/></label>    
            <label>Cédula o  Identificación<input class="form-control" type="text" runat="server"  id="Txt_C" onkeypress="return controlEspacio()" /></label>
            
            </div>
                <div class="row">
                    <br />
                </div>
            <div class="form-horizontal">
              <label>Fecha de nacimiento<input class="form-control" type="date" runat="server"  id="TxtF"/></label>
                     
<asp:DropDownList style="background-color:#104b59;" AutoPostBack="true" OnSelectedIndexChanged="dd_pro_SelectedIndexChanged" ID="dd_pro" runat="server" class="btn btn-primary dropdown-toggle">
            <asp:listitem text="Provincia" value="0"></asp:listitem>  
</asp:DropDownList>

<asp:DropDownList style="background-color:#104b59;" AutoPostBack="true" OnSelectedIndexChanged="dd_can_SelectedIndexChanged" ID="dd_can" runat="server" class="btn btn-primary dropdown-toggle">
            <asp:listitem text="Cantón" value="0"></asp:listitem>
</asp:DropDownList>  

  <asp:DropDownList style="background-color:#104b59;" ID="dd_dis" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:listitem text="Distrito" value="0"></asp:listitem>
  </asp:DropDownList>

  <asp:DropDownList style="background-color:#104b59;" ID="ddg" runat="server" class="btn btn-primary dropdown-toggle">
      <asp:listitem text="Género" value="0"></asp:listitem>
  </asp:DropDownList>
           
            </div>
<br/>
  <div class="form-horizontal">
      <label>Apoderado<input type="text" class="form-control" runat="server" disabled="disabled"  id="txt_A" onkeypress="return controlEspacio()" /></label>
      <asp:DropDownList style="background-color:#104b59;" ID="dd_tid" AutoPostBack="true" OnSelectedIndexChanged="dd_tid_SelectedIndexChanged" runat="server" class="btn btn-primary dropdown-toggle">
        <asp:listitem text="Identificación" value="0"></asp:listitem>
  </asp:DropDownList>
      <asp:DropDownList style="background-color:#104b59;" ID="dd_ec" runat="server" class="btn btn-primary dropdown-toggle">
                <asp:listitem text="Estado Civil" value="0"></asp:listitem>
  </asp:DropDownList>
      <label>Email<input type="email" class="form-control" runat="server" id="email" onkeypress="return controlEspacio()" /></label>  
  </div>               
<br />
 <div class="row">
     <label class="col-5">Usuario Admin </label><input class="checkbox; col-4"  type="checkbox" runat="server"  id="chk_A" />
     </div>
<br />
<div class="row">
     <p class="col-6"><input type="button" runat="server" value="Registrarse" onserverclick="btn_S_ServerClick" class="btn btn-group-lg" id="btn_S" />  <a href="Login.aspx">Ya tienes un Usuario? ingresa desde acá</a></p>
     
</div>

</div>
            

</asp:Content>
