using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.DAL_ADMIN;
using BLL.BLL_ADMIN;

namespace PolizaUI
{
    public partial class Poliza : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                datos_login();
            }
        }
        public void datos_login()
        {
            if (Convert.ToString(Session["Rol"]) == "1"&&Session["user"]!=null)
            {
                Usuario.InnerHtml = Session["user"].ToString() + " Administrador";
                login.Style.Add("display","none");
            }
            else if (Convert.ToString(Session["Rol"]) == "2" &&Session["user"]!=null)
            {
                Usuario.InnerHtml = Convert.ToString(Session["user"]) + " Usuario";
                login.Style.Add("display", "none");
                administrador.Style.Add("display", "none");
            }
            else
            {
                administrador.Style.Add("display", "none");
            }
        }
    }
}