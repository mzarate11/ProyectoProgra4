<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Provincia.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Provincia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
        <link rel="stylesheet" href="../../Resources/bootstrap.min.css"/>
   <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/provincia.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/v/bs/dt-1.10.18/b-1.5.6/fc-3.2.5/fh-3.1.4/r-2.2.2/sl-1.3.0/datatables.min.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs/dt-1.10.18/b-1.5.6/fc-3.2.5/fh-3.1.4/r-2.2.2/sl-1.3.0/datatables.min.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="provincia"  runat="server">
        <asp:GridView  cssclass="display"  ID="GV_provincia" runat="server">
            
        </asp:GridView>
       
    </div>
</asp:Content>
