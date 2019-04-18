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
                this.dd_tid.DataSource = null;
                this.dd_tid.DataSource = Obj_DALid.DS1;
                this.dd_tid.DataValueField = "ID_TIPO_IDENTIFICACION";
                this.dd_tid.DataTextField = "Nombre";
                this.dd_tid.DataBind();
                this.dd_tid.Items.Insert(0, new ListItem("Tipo_ID", "0"));


            }
            else
            {
                //errores.
            }
            cls_genero_DAL Obj_DALg = new cls_genero_DAL();
            cls_Genero_BLL Obj_BLLg = new cls_Genero_BLL();
            Obj_BLLg.Listar_genero(ref Obj_DALg, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.ddg.DataSource = null;
                this.ddg.DataSource = Obj_DALg.DS1;
                this.ddg.DataValueField = "ID_Genero";
                this.ddg.DataTextField = "Tipo";
                this.DataBind();
                this.ddg.Items.Insert(0, new ListItem("Género", "0"));
            }
            else
            {
                //error
            }
            cls_estadoC_DAL Obj_DALe = new cls_estadoC_DAL();
            cls_estadoC_BLL Obj_BLLe = new cls_estadoC_BLL();
            Obj_BLLe.Listar_estadoC(ref Obj_DALe, sMsjError);
            if (sMsjError == string.Empty)
            {
                this.dd_ec.DataSource = null;
                this.dd_ec.DataSource = Obj_DALe.DS1;
                this.dd_ec.DataValueField = "ID_ESTADO_CIVIL";
                this.dd_ec.DataTextField = "ESTADO";
                this.DataBind();
                this.dd_ec.Items.Insert(0, new ListItem("Estado Civil","0"));
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

        protected void dd_tid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (dd_tid.SelectedIndex == 3)
                {
                    this.txt_A.Attributes.Remove("disabled");
                }
            }
            }

        protected void btn_S_ServerClick(object sender, EventArgs e)
        {
            if (txt_A.Value != string.Empty)
            {
                cls_Persona_DAL Obj_DALpers = new cls_Persona_DAL();
                cls_Persona_BLL Obj_BLLpers = new cls_Persona_BLL();
                string sMsjError = string.Empty;
                Obj_BLLpers.Insertar_Persona(ref Obj_DALpers, Txt_C.Value, Txt_N.Value, Txt_ape1.Value, txt_ape2.Value, email.Value, Txtcel.Value, TxtF.Value, txt_A.Value, dd_pro.SelectedValue, dd_can.SelectedValue, dd_dis.SelectedValue, ddg.SelectedValue, dd_ec.SelectedValue, dd_tid.SelectedValue, ref sMsjError);
               
            }
            else
            {
                cls_Persona_DAL Obj_DALpers = new cls_Persona_DAL();
                cls_Persona_BLL Obj_BLLpers = new cls_Persona_BLL();
                string sMsjError = string.Empty;
                Obj_BLLpers.Insertar_Personab(ref Obj_DALpers, Txt_C.Value, Txt_N.Value, Txt_ape1.Value, txt_ape2.Value, email.Value, Txtcel.Value, TxtF.Value, dd_pro.SelectedValue, dd_can.SelectedValue, dd_dis.SelectedValue, ddg.SelectedValue, dd_ec.SelectedValue, dd_tid.SelectedValue, ref sMsjError);
                
            }
            cls_usuarios_DAL Obj_DALu = new cls_usuarios_DAL();
            cls_usuarios_BLL Obj_BLLu = new cls_usuarios_BLL();
            string sMsjError2 = string.Empty;
            int iValor = 0;
            if (chk_A.Checked == true)
            {
                Obj_BLLu.Insertar_Usuarios(ref Obj_DALu, ref iValor, Txt_C.Value, Txt_Usuario.Value, txt_Contraseña.Value, "1", ref sMsjError2);
            }
            else
            {
                Obj_BLLu.Insertar_Usuarios(ref Obj_DALu, ref iValor, Txt_C.Value, Txt_Usuario.Value, txt_Contraseña.Value, "2", ref sMsjError2);
            }
            

        }
    }
}
