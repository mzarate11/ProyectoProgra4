using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.DAL_ADMIN;
using BLL.BLL_ADMIN;

namespace PolizaUI.Paginas.Administrativo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            cls_usuarios_DAL Obj_DAL = new cls_usuarios_DAL();
            cls_usuarios_BLL Obj_BLL = new cls_usuarios_BLL();
            string sMsjError = string.Empty;
            int Login = Obj_BLL.Login(ref Obj_DAL, sMsjError, txt_U.Value, txt_P.Value);
            if (Login == -1)
            {
                //user malo
                lblogin.InnerText = "Usuario Incorrecto";
            }
            else if (Login == -2)
            {
                //pass malo
                lblogin.InnerText = "Contraseña Incorrecta";
            }
            else if (Login == 1)
            {
                Obj_BLL.Listar_Usuario(ref Obj_DAL, sMsjError);
                if (sMsjError == string.Empty)
                {
                    Obj_BLL.Filtrar_Usuario(ref Obj_DAL, sMsjError, txt_U.Value);
                    Session["user"] = txt_U.Value;
                    Session["Rol"] = Obj_DAL.DS1.Tables[0].Rows[0][1].ToString();
                    Response.Redirect("../../IndexPoliza.aspx");
                }
                else
                {
                    //cochinos errores
                }

            }
        }
    }
}