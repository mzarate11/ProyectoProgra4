using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.DAL_ADMIN;
using BLL.BLL_ADMIN;


namespace PolizaUI.Paginas
{
    public partial class Persona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            if (!IsPostBack)
            {
                cargarDatos(ref sMsjError);
            }
        }
        public void cargarDatos(ref string sMsjError)
        {
            cls_Persona_DAL Obj_DAL = new cls_Persona_DAL();
            cls_Persona_BLL Obj_BLL = new cls_Persona_BLL();
            Obj_BLL.Listar_Persona(ref Obj_DAL, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.GV.DataSource = null;
                this.GV.DataSource = Obj_DAL.DS1.Tables[0];
                this.GV.DataBind();
            }
            else
            {
                GV.DataSource = null;

            }
        }
    }
}