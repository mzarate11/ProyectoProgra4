<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
   <link type="text/css" rel="../../Resources/bootstrap.min.css" />
    <link type="text/css" rel="../../DataTables/datatables.min.css" />
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../DataTables/datatables.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="planes"  runat="server">
        <asp:GridView  cssclass="table"  ID="GV_planes" runat="server">
            <Columns> 
             <asp:TemplateField HeaderStyle-ForeColor="Black">
                    <ItemTemplate>
                        <input type="button" class="btn btn-success" id="btnButton" runat="server" value="Editar" />
                        <input type="button" class="btn btn-danger" id="Button1" runat="server" value="Eliminar" />
                    </ItemTemplate>
                </asp:TemplateField>  
</Columns> 
        </asp:GridView>
       
    </div>
</asp:Content>
