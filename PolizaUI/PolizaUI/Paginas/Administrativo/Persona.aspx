<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="persona" runat="server">
        <asp:GridView style="text-align:center" ID="GV_persona" runat="server">

        </asp:GridView>

    </div>
</asp:Content>

