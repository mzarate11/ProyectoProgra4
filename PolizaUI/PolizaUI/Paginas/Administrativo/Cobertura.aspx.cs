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
    public partial class Cobertura : System.Web.UI.Page
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
            cls_Cobertura_DAL Obj_DAL = new cls_Cobertura_DAL();
            cls_Cobertura_BLL Obj_BLL = new cls_Cobertura_BLL();
            if (txt_filtro.Value == string.Empty)
            {
                Obj_BLL.Listar_Cobertura(ref Obj_DAL, ref sMsjError);
                if (sMsjError == string.Empty)
                {
                    this.GV_cobertura.DataSource = null;
                    this.GV_cobertura.DataSource = Obj_DAL.DS1.Tables[0];
                    this.GV_cobertura.DataBind();
                }
                else
                {
                    GV_cobertura.DataSource = null;

                }
            }
            else
            {
                Obj_BLL.Filtrar_Cobertura(ref Obj_DAL, txt_filtro.Value, ref sMsjError);//le faltan arreglos
                if (sMsjError == string.Empty)
                {
                    this.GV_cobertura.DataSource = null;
                    this.GV_cobertura.DataSource = Obj_DAL.DS1.Tables[0];
                    this.GV_cobertura.DataBind();
                }
                else
                {
                    GV_cobertura.DataSource = null;

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
            cls_Cobertura_DAL Obj_DAL = new cls_Cobertura_DAL();
            cls_Cobertura_BLL Obj_BLL = new cls_Cobertura_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Insertar_Cobertura(ref Obj_DAL, Text1.Value, Text2.Value, Text3.Value, Text4.Value, Text5.Value, ref sMsjError);//funciona
            cargarDatos(ref sMsjError);
        }

        protected void btn_S_ServerClick(object sender, EventArgs e)
        {
            cls_Cobertura_DAL Obj_DAL = new cls_Cobertura_DAL();
            cls_Cobertura_BLL Obj_BLL = new cls_Cobertura_BLL();
            string sMsjError = string.Empty;
            GridViewRow row = GV_cobertura.SelectedRow;//apunta al row seleccionado el cells es el espacio en ese Row
            Obj_BLL.Delete_Cobertura(ref Obj_DAL, row.Cells[1].Text, ref sMsjError);//funciona pero hay que cambiar el sp la forma de declarar las variables estan mal
            if (sMsjError == string.Empty)
            {
                cargarDatos(ref sMsjError);
            }
            else
            {
                //control de mensajes aún falta esto
            }
        }

        protected void GV_cobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_Cobertura_DAL Obj_DAL = new cls_Cobertura_DAL();
            cls_Cobertura_BLL Obj_BLL = new cls_Cobertura_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Listar_Cobertura(ref Obj_DAL, ref sMsjError);
            GridViewRow row = GV_cobertura.SelectedRow;
            /*TxtIDE.Value = row.Cells[1].Text;
            TxtNE.Value = row.Cells[2].Text;*/
        }

        protected void btn_E_ServerClick(object sender, EventArgs e)
        {

            cls_Cobertura_DAL Obj_DAL = new cls_Cobertura_DAL();
            cls_Cobertura_BLL Obj_BLL = new cls_Cobertura_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Editar_Cobertura(ref Obj_DAL, Text6.Value, Text7.Value, Text8.Value, Text9.Value, Text10.Value, ref sMsjError);
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