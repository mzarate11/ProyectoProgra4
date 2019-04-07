using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL_ADMIN;
using System.Configuration;

namespace BLL.BLL_ADMIN
{
    public class cls_Provincia_BLL
    {
        public void Listar_provincias(ref cls_Provincia_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_provincias"].ToString();  
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp,Obj_DAL.DT1, ref sMsjError);
            
        }
    }
}
