<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Provincia.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Provincia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
   <link type="text/css" rel="../../Resources/bootstrap.min.css" />
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="provincia"  runat="server">
        <label>Filtro: <input type="text" id="txt_filtro" runat="server" class="form-control"/> <input type="button" id="btn_f" value="Buscar" runat="server" class="btn" onserverclick="btn_f_ServerClick" /></label>
        <button type="button" data-toggle="modal" data-target="#insert">Nuevo Registro</button>
        <asp:GridView OnSelectedIndexChanged="GV_provincia_SelectedIndexChanged" cssclass="table table-bordered"  ID="GV_provincia" runat="server">
            
            <selectedrowstyle backcolor="LightBlue"
          forecolor="DarkBlue"/>
            <Columns> 
                <asp:TemplateField HeaderText="Editar columnas" HeaderStyle-ForeColor="Black">
          
                    <ItemTemplate>
                        <input type="button" class="btn btn-success" id="btn_E" runat="server" value="Editar" />
                        <input type="button"  class="btn btn-danger" id="btn_D" data-toggle="modal" data-target="#delete" value="Eliminar" runat="server"/>
                        <!--el Command name es lo que genera el select de cada Row -->
                        <asp:button CssClass="btn btn-primary" CommandName="Select" Text="seleccionar"  runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField> 
            
</Columns> 
        </asp:GridView>
       <div id="insert" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal insert-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Insertar Nuevo Resgistro</h4>
      </div>
      <div class="modal-body">
       <label>ID_provincia:  <input type="text" id="txt_ID" runat="server" class="form-control" /></label> 
        <label>Nombre:  <input type="text" id="txt_nombre" runat="server" class="form-control" /></label>
<input type="button" value="aceptar" runat="server" id="btn_a" class="btn btn-success" onserverclick="btn_a_ServerClick" />
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>
        <div id="delete" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal <delete-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Borrar Datos</h4>
      </div>
      <div class="modal-body">
        <p>¿Está Seguro que desea borrar Los Datos?</p>
          <input type="button" runat="server" onserverclick="btn_S_ServerClick" id="btn_S" class="btn btn-danger" value="Sí" />
          <button type="button" data-dismiss="modal" id="btn_N" class="btn btn-default">No</button>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>
    </div>
</asp:Content>
