using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.DAL_ADMIN;
using BLL.BLL_ADMIN;

namespace PolizaUI.Paginas.Cliente
{
    public partial class Venta : System.Web.UI.Page
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
           cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            cls_Canton_DAL Obj_DALC = new cls_Canton_DAL();
            cls_Canton_BLL Obj_BLLC = new cls_Canton_BLL();
            cls_Distrito_DAL Obj_DALD = new cls_Distrito_DAL();
            cls_Distrito_BLL Obj_BLLD = new cls_Distrito_BLL();
            Obj_BLL.Listar_provincias(ref Obj_DAL, sMsjError);
            Obj_BLLC.Listar_Canton(ref Obj_DALC, sMsjError);
            Obj_BLLD.Listar_Distritos(ref Obj_DALD, sMsjError);

                if (sMsjError == string.Empty)
                {
               ProvRes.DataSource = null;
               CantonOp.DataSource = null;
               DistritoOp.DataSource = null;
               ProvRes.DataSource = Obj_DAL.DS1;
               CantonOp.DataSource = Obj_DALC.DS1;
               DistritoOp.DataSource = Obj_DALD.DS1;
               this.ProvRes.DataValueField = "ID_Provincia";
               this.CantonOp.DataValueField = "ID_Canton";
               this.DistritoOp.DataValueField = "ID_DISTRITO";
               this.ProvRes.DataTextField = "Nombre";
               this.CantonOp.DataTextField = "Nombre";
               this.DistritoOp.DataTextField = "Nombre";
               ProvRes.DataBind();
               CantonOp.DataBind();
               DistritoOp.DataBind();
               this.ProvRes.Items.Insert(0, new ListItem("Provincia", "0"));
               this.CantonOp.Items.Insert(0, new ListItem("Canton", "0"));
               this.DistritoOp.Items.Insert(0, new ListItem("Distrito", "0"));

            }
                else
                {
                ProvRes.DataSource = null;
                CantonOp.DataSource = null;
                DistritoOp = null;
            }
            }
        }
}