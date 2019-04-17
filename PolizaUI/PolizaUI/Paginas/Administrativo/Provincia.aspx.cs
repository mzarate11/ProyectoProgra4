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
            if (txt_filtro.Value == string.Empty)
            {
                Obj_BLL.Listar_provincias(ref Obj_DAL, sMsjError);
                if (sMsjError == string.Empty)
                {
                    this.GV_provincia.DataSource = null;
                    this.GV_provincia.DataSource = Obj_DAL.DS1.Tables[0];
                    this.GV_provincia.DataBind();
                }
                else
                {
                    GV_provincia.DataSource = null;

                }
            }
            else
            {
                Obj_BLL.Filtrar_provincias(ref Obj_DAL, sMsjError, txt_filtro.Value);//le faltan arreglos
                if (sMsjError == string.Empty)
                {
                    this.GV_provincia.DataSource = null;
                    this.GV_provincia.DataSource = Obj_DAL.DS1.Tables[0];
                    this.GV_provincia.DataBind();
                }
                else
                {
                    GV_provincia.DataSource = null;

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
            cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Insertar_provincias(ref Obj_DAL, txt_ID.Value, txt_nombre.Value, ref sMsjError);//funciona
            cargarDatos(ref sMsjError);  
        }

        protected void btn_S_ServerClick(object sender, EventArgs e)
        {
            cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            string sMsjError = string.Empty;
            GridViewRow row = GV_provincia.SelectedRow;//apunta al row seleccionado el cells es el espacio en ese Row
            Obj_BLL.Delete_provincias(ref Obj_DAL, row.Cells[1].Text , ref sMsjError);//funciona pero hay que cambiar el sp la forma de declarar las variables estan mal
            if (sMsjError == string.Empty)
            {
                cargarDatos(ref sMsjError);
            }
            else
            {
               //control de mensajes aún falta esto
            }                                                 
        }

        protected void GV_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Listar_provincias(ref Obj_DAL, sMsjError);
            GridViewRow row = GV_provincia.SelectedRow;
            TxtIDE.Value = row.Cells[1].Text;
            TxtNE.Value = row.Cells[2].Text;
        }

        protected void btn_E_ServerClick(object sender, EventArgs e)
        {
           
            cls_Provincia_DAL Obj_DAL = new cls_Provincia_DAL();
            cls_Provincia_BLL Obj_BLL = new cls_Provincia_BLL();
            string sMsjError = string.Empty;
            Obj_BLL.Editar_provincias(ref Obj_DAL, Convert.ToInt32(txt_ID.Value), txt_nombre.Value, ref sMsjError);
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