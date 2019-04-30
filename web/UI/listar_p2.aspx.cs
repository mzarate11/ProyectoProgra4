using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;


namespace UI
{
    public partial class listar_p2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            if (!IsPostBack)
            {
                CargarDatos(ref sMsjError);
            }
        }
        public void CargarDatos(ref string sMsjError)
        {
            cls_p2_DAL Obj_DAL = new cls_p2_DAL();
            cls_p2_BLL Obj_BLL = new cls_p2_BLL();
            Obj_BLL.listar_p2(ref Obj_DAL, sMsjError);
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

        protected void btn_a_ServerClick(object sender, EventArgs e)
        {
            cls_p2_DAL Obj_DAL = new cls_p2_DAL();
            cls_p2_BLL Obj_BLL = new cls_p2_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Insertar_p2(ref Obj_DAL, txt_ID.Value, txt_nombre.Value, ref sMsjError);
            CargarDatos(ref sMsjError);
        }
    }
}