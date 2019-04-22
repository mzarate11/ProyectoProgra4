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
            string sMsjError = string.Empty;
            if (!IsPostBack)
            {
                //cargarDatos(ref sMsjError);
            }
        }

        public void cargarDatos(ref string sMsjError)
        {
            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            if (txt_filtro.Value == string.Empty)
            {
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
            else
            {
                Obj_BLL.Filtrar_Planes(ref Obj_DAL, txt_filtro.Value, sMsjError);//le faltan arreglos
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

        protected void btn_f_ServerClick(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            cargarDatos(ref sMsjError);
        }

        protected void btn_a_ServerClick(object sender, EventArgs e)
        {
            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            string sMsjError = string.Empty;
            //Obj_BLL.Insertar_Planes(ref Obj_DAL, txt_ID.Value, txt_nombre.Value, ref sMsjError);//funciona
            cargarDatos(ref sMsjError);
        }

        protected void btn_S_ServerClick(object sender, EventArgs e)
        {
            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            string sMsjError = string.Empty;
            GridViewRow row = GV_planes.SelectedRow;//apunta al row seleccionado el cells es el espacio en ese Row
            Obj_BLL.Delete_Planes(ref Obj_DAL, row.Cells[1].Text, ref sMsjError);//funciona pero hay que cambiar el sp la forma de declarar las variables estan mal
            if (sMsjError == string.Empty)
            {
                cargarDatos(ref sMsjError);
            }
            else
            {
                //control de mensajes aún falta esto
            }
        }

        protected void GV_planes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Listar_Planes(ref Obj_DAL, sMsjError);
            GridViewRow row = GV_planes.SelectedRow;
            TxtIDE.Value = row.Cells[1].Text;
            TxtNE.Value = row.Cells[2].Text;
        }

        protected void btn_E_ServerClick(object sender, EventArgs e)
        {

            cls_Planes_DAL Obj_DAL = new cls_Planes_DAL();
            cls_Planes_BLL Obj_BLL = new cls_Planes_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Editar_Planes(ref Obj_DAL, Convert.ToInt32(TxtIDE.Value), TxtNE.Value, ref sMsjError);
            if (sMsjError == string.Empty)
            {
                cargarDatos(ref sMsjError);
            }
            else
            {
                //control de mensaje aún falta esto
            }
        }

        protected void btn_E_ServerClick1(object sender, EventArgs e)
        {

        }
    }
}