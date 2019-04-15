using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL_ADMIN;
using System.Configuration;
using System.Data;

namespace BLL.BLL_ADMIN
{
    public class cls_Provincia_BLL
    {
        public void Crear_tabla(ref cls_Provincia_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }

        public void Listar_provincias(ref cls_Provincia_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_provincias"].ToString();  
           Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_sp, ref sMsjError));
            
        }
        public void Filtrar_provincias(ref cls_Provincia_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings[].ToString();
        }
    }
}
