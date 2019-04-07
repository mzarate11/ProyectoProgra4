<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Poliza.aspx.cs" Inherits="PolizaUI.Paginas.Persona" %>
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
    <div>
        <form>
            <div id="h">
                <h1 class="H1Global">Login</h1>
            </div>
  <div class="form-group">
    <label>Polizas:</label>
    <asp:DropDownList style="background-color:#104b59;" runat="server" class="btn btn-primary dropdown-toggle">
      <asp:listitem text="Tipo Poliza :" value="0"></asp:listitem>
      <asp:listitem text="Póliza Colectiva de Vida." value="1"></asp:listitem>
      <asp:listitem text="Póliza de Seguro Médico Básico." value="2"></asp:listitem>
      <asp:listitem text="Seguro Grupal de Responsabilidad Civil Profesional." value="3"></asp:listitem>
      <asp:listitem text="Póliza de Seguro Médico Básico." value="4"></asp:listitem>
      <asp:listitem text="Pólizas de Seguros Médicos Voluntarios." value="5"></asp:listitem>
      <asp:listitem text="Póliza de Seguro de Vida 01-16VIC-299." value="6"></asp:listitem>
      <asp:listitem text="Procedimiento para la presentación de reclamos y Solicitud de Beneficios." value="7"></asp:listitem>
      <asp:listitem text="Médicos Pensionados." value="8"></asp:listitem>
      <asp:listitem text="Seguro de Asistencia al Viajero." value="9"></asp:listitem>

  </asp:DropDownList>
  </div>

  <div class="form-group">
    <label>Informacion:</label>
    
  </div>
  
</form>
    </div>
                            
                       
</asp:Content>