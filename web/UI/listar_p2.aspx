<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listar_p2.aspx.cs" Inherits="UI.listar_p2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8"/>
    <title>p2</title>
<%--    <link type="text/css"  rel="stylesheet" href="Content/bootstrap.min.css" />
    <script type="text/javascript" src="scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="scripts/bootstrap.min.js"></script> --%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <button type="button" data-toggle="modal" data-target="#insert">Nuevo Registro</button>
        <asp:GridView ID="GV" runat="server"></asp:GridView>
    </div>
        <div id="insert" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal insert-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Insertar Nuevo Resgistro</h4>
                    </div>
                    <div class="modal-body">
                        <label>id: 
                            <input type="text" id="txt_ID" onkeypress="return controlEspacio()" runat="server" class="form-control" /></label>
                        <label>descripciom: 
                            <input type="text" id="txt_nombre" runat="server" class="form-control" /></label>
                        <input type="button" value="aceptar" runat="server" id="btn_a" class="btn btn-success" onserverclick="btn_a_ServerClick" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
                </div>
            </div>
    </form>
</body>
</html>
