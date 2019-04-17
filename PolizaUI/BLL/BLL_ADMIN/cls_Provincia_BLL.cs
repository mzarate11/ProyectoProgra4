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
        public void Filtrar_provincias(ref cls_Provincia_DAL Obj_DAL, string sFiltro, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_P = "@NombreProvincia";
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Filtrar_provincia"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp, Obj_DAL.sNombre_P,SqlDbType.VarChar , sFiltro, ref sMsjError));
        }
        public void Insertar_provincias(ref cls_Provincia_DAL Obj_DAL,string sValor1,string sValor2, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_PROVINCIA", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                       //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", 2, sValor2);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Provincia"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp,Obj_DAL.dtParametros,ref sMsjError);//es sin I porque la tabla no tiene identity las que si lo llevan usan el otro metodo
        }
        public void Delete_provincias(ref cls_Provincia_DAL Obj_DAL, string sValor, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_provi", 1, sValor);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Delete_Provincia"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
        public void Editar_provincias(ref cls_Provincia_DAL Obj_DAL, int sValor1, string sValor2, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add(@"ID_provi", 1, sValor1);
            Obj_DAL.dtParametros.Rows.Add(@"Nombre", 2, sValor2);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Update_Provincia"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
    }
}
