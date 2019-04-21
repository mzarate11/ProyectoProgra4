<%@ Page Title="" Language="C#" MasterPageFile="~/Poliza.Master" AutoEventWireup="true" CodeBehind="Cobertura.aspx.cs" Inherits="PolizaUI.Paginas.Administrativo.Cobertura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
   <link type="text/css" rel="../../Resources/bootstrap.min.css" />
    <script type="text/javascript" src="../../Resources/jquery.min.js"></script>
    <script type="text/javascript" src="../../Resources/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../Scripts/Login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>  <!--hay que ver de que manera resolvemoos esto -->
    <br>
    <br>
    <div id="cobertura" style="text-align: match-parent" runat="server">
        <label>Filtro:
            <input type="text" id="txt_filtro" runat="server" class="form-control" />
            <input type="button" id="btn_f" value="Buscar" runat="server" class="btn" onserverclick="btn_f_ServerClick" /></label>
        <button type="button" data-toggle="modal" data-target="#insert">Nuevo Registro</button>
        <asp:GridView OnSelectedIndexChanged="GV_cobertura_SelectedIndexChanged" CssClass="table table-bordered" ID="GV_cobertura" runat="server">

            <SelectedRowStyle BackColor="LightBlue"
                ForeColor="DarkBlue" />
            <Columns>
                <asp:TemplateField HeaderText="Editar columnas" HeaderStyle-ForeColor="Black">

                    <ItemTemplate>
                        <input type="button" class="btn btn-success" data-toggle="modal" data-target="#edit" id="btn_E" runat="server" value="Editar" />
                        <input type="button" class="btn btn-danger" id="btn_D" data-toggle="modal" data-target="#delete" value="Eliminar" runat="server" />
                        <!--el Command name es lo que genera el select de cada Row -->
                        <asp:Button CssClass="btn btn-primary" CommandName="Select" Text="seleccionar" runat="server" />
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
                        <label>ID_cobertura: 
                            <input type="text" id="txt_ID" onkeypress="return controlEspacio()" runat="server" class="form-control" /></label>
                        <label>Nombre: 
                            <input type="text" id="txt_nombre" onkeypress="return controlEspacio()" runat="server" class="form-control" /></label>
                        <input type="button" value="aceptar" runat="server" id="btn_a" class="btn btn-success" onserverclick="btn_a_ServerClick" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
                </div>
            </div>
           

             <div id="edit" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal edit-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Insertar Nuevo Resgistro</h4>
                    </div>
                    <div class="modal-body">
                        <label>ID_cobertura: 
                            <input type="text" id="TxtIDE" onkeypress="return controlEspacio()" runat="server" class="form-control"/></label>
                        <label>Nombre: 
                            <input type="text" id="TxtNE" onkeypress="return controlEspacio()" runat="server" class="form-control"/></label>
                        <input type="button" value="aceptar"  runat="server" id="BtnE" class="btn btn-success" onserverclick="btn_E_ServerClick" />
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
