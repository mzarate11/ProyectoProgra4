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
    public partial class Planes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void cargarDatos(ref string sMsjError)
        {
            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            Obj_BLL.Listar_Planes(ref Obj_DAL, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.GV_planes.DataSource = null;
                this.GV_planes.DataSource = Obj_DAL.DS1.Tables[0];
                this.GV_planes.DataBind();
            }
            else
            {
                GV_planes.DataSource = null;

            }
        }
    }
}