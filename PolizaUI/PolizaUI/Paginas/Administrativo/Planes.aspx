<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="PolizaUI.Paginas.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
        <link rel="stylesheet" href="Resources/bootstrap.min.css"/>
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js" ></script>
    <script type="text/javascript" src="../../Scripts/provincia.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="planes" runat="server">
        <asp:GridView style="text-align:center"  ID="GV" runat="server">

        </asp:GridView>

    </div>
</asp:Content>
