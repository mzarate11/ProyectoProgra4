<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Venta.aspx.cs" Inherits="PolizaUI.Paginas.Cliente.Venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <link rel="stylesheet" href="../../styles/Login.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <br />
    <h4>Nombre;</h4>
<input type="text" runat="server" name="txtname" id="txtname" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <h4>Apellido:</h4>
<input type="text" runat="server" name="txtLname" id="txtLname" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <h4>Cedula:</h4>
<input type="text" runat="server" name="nced" id="nced" onkeypress="return SoloLetras(event)" class="Inputs-Margin" required/>
    <br />
    <h4>Provincia de residencia:</h4>

    <%--Aqui van drop down list con las provincias--%>

    <br />
    <h4>Canton:</h4>
    <%--Aqui van drop down list con los cantones segun la provincia--%>


    <br />
    <h4>Distrito:</h4>

    <%--Aqui van drop down list con los distritos segun el canton--%>


    <br />
    <h4>Poliza a optar:</h4>
    <asp:DropDownList style="background-color:#104b59;" runat="server" class="btn btn-primary dropdown-toggle">
      <asp:listitem Text="Polizas" value="0"></asp:listitem>
      <asp:listitem Text="Póliza Colectiva de Vida." value="1"></asp:listitem>
      <asp:listitem Text="Póliza de Seguro Médico Básico." value="2"></asp:listitem>
      <asp:listitem Text="Seguro Grupal de Responsabilidad Civil Profesional." value="3"></asp:listitem>
      <asp:listitem Text="Pólizas de Seguros Médicos Voluntarios." value="4"></asp:listitem>
      <asp:listitem Text="Póliza de Seguro Voluntario Automóvilisticos" value="5"></asp:listitem>
      <asp:listitem Text="Procedimiento para la presentación de reclamos y Solicitud de Beneficios." value="6"></asp:listitem>
      <asp:listitem Text="Médicos Pensionados." value="7"></asp:listitem>
      <asp:listitem Text="Seguro de Asistencia al Viajero." value="8"></asp:listitem>
      <asp:listitem Text="Póliza Colectiva de Vida." value="9"></asp:listitem>
      <asp:listitem Text="Formularios del Seguro Básico del Colegio de Médicos." value="10"></asp:listitem>

  </asp:DropDownList>  
    <br />
    <h4>Metodo Pago</h4>
     <asp:DropDownList style="background-color:#104b59;" runat="server" class="btn btn-primary dropdown-toggle">
         <asp:listitem Text="Tarjeta." value="0"></asp:listitem>
      <asp:listitem Text="Credito." value="1"></asp:listitem>
      <asp:listitem Text="Debito." value="2"></asp:listitem>
     </asp:DropDownList>
    <br />
    <br />

    <p class="ws_shadow"><input type="button" runat="server" value="Obtener Seguro" class="btn btn-group-lg" id="btn_S" />
    <br />
    

</asp:Content>
