<%@ Page Title="" Language="C#" MasterPageFile="~/PolizaUIMaster.Master" AutoEventWireup="true" CodeBehind="Provincia.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Provincia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
   <link type="text/css" rel="../../Resources/bootstrap.min.css" />
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js"
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="provincia"  runat="server">
        <asp:GridView  cssclass="table"  ID="GV_provincia" runat="server">
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
