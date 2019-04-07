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
    public partial class Provincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, ref string sMsjError)
        {

        }
        public void cargarDatos(ref string sMsjError)
        {
            cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            Obj_BLL.Listar_provincias(ref Obj_DAL, sMsjError);
            if (sMsjError == string.Empty)
            {
                GV.DataSource = null;
                GV.DataSource = Obj_DAL.DT1;
            }
            else
            {
                GV.DataSource = null;
                
            }
        }

        protected void GV_Load(object sender, EventArgs e, ref string sMsjError)
        {
            cargarDatos(ref sMsjError);
            if (sMsjError == string.Empty)
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alerta", "error();", true);
            }
        
    }
    }
}