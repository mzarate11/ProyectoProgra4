using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using DAL.DAL_ADMIN;
using BLL.BLL_ADMIN;

namespace PolizaUI.Paginas.Administrativo
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sMsjError = string.Empty;
                cargar_Drops(ref sMsjError);
            }

        }
        public void cargar_Drops(ref string sMsjError)
        {
            cls_Provincia_DAL Obj_DALp = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLLp = new cls_Provincia_BLL();
            Obj_BLLp.Listar_provincias(ref Obj_DALp, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.dd_pro.DataSource = null;
                this.dd_pro.DataSource = Obj_DALp.DS1;
                this.dd_pro.DataValueField = "ID_Provincia";
                this.dd_pro.DataTextField = "Nombre";
                this.dd_pro.DataBind();
                this.dd_pro.Items.Insert(0, new ListItem("Provincia","0"));
                

            }
            else
            {
                //errores.
            }
            cls_tipoID_DAL Obj_DALid = new cls_tipoID_DAL();
            cls_TipoID_BLL Obj_BLLid = new cls_TipoID_BLL();
            Obj_BLLid.Listar_TipoID(ref Obj_DALid, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.dd_pro.DataSource = null;
                this.dd_pro.DataSource = Obj_DALid.DS1;
                this.dd_pro.DataValueField = "ID_TIPO_IDENTIFICACION";
                this.dd_pro.DataTextField = "Nombre";
                this.dd_pro.DataBind();
                this.dd_pro.Items.Insert(0, new ListItem("Provincia", "0"));


            }
            else
            {
                //errores.
            }
            

        }

        protected void dd_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            if (IsPostBack)
            {
                cls_Canton_DAL Obj_DALc = new cls_Canton_DAL();
                cls_Canton_BLL Obj_BLLc = new cls_Canton_BLL();
                Obj_BLLc.filtro_drop(ref Obj_DALc, dd_pro.SelectedValue.Trim(), ref sMsjError);
                if (sMsjError == string.Empty)
                {
                    this.dd_can.DataSource = null;
                    this.dd_can.DataSource = Obj_DALc.DS1;
                    this.dd_can.DataValueField = "ID_CANTON";
                    this.dd_can.DataTextField = "NOMBRE";
                    this.dd_can.DataBind();
                    this.dd_can.Items.Insert(0, new ListItem("Cantón","0"));
                }
                else
                {
                    //error;
                }
            }  
            
        }

        protected void dd_can_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            if (IsPostBack)
            {
                cls_Distrito_DAL Obj_DALd = new cls_Distrito_DAL();
                cls_Distrito_BLL Obj_BLLd = new cls_Distrito_BLL();
                Obj_BLLd.Filtro_drop(ref Obj_DALd, dd_can.SelectedValue.Trim(), ref sMsjError);
                if (sMsjError == string.Empty)
                {
                    this.dd_dis.DataSource = null;
                    this.dd_dis.DataSource = Obj_DALd.DS1;
                    this.dd_dis.DataValueField = "ID_DISTRITO";
                    this.dd_dis.DataTextField = "NOMBRE";
                    this.dd_dis.DataBind();
                    this.dd_dis.Items.Insert(0, new ListItem("Distrito","0"));
                }
                else
                {
                    //errores
                }
            }
        }
    }
}