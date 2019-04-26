<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Login" %>
<asp:Content ID="Login_head" ContentPlaceHolderID="head" runat="server">
 

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
    <input runat="server" type="password" class="form-control" id="txt_P" onkeypress="return controlEspacio()"/>
  </div>
            <label id="lblogin" runat="server"></label>
  <div class="checkbox">
    <label><input id="chk" type="checkbox"/> Recuerdame</label>
  </div>
  <button type="button" runat="server" id="btnL" class="btn btn-default" onserverclick="Unnamed_ServerClick">Ingresar</button>
   <div>
       <p >No tienes cuenta? <a href="Registrar.aspx">Crea una nueva cuenta aqui</a></p>
   </div>
</form>
    
</asp:Content>
