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
    public class cls_Planes_BLL
    {
        public void Crear_tabla(ref cls_Planes_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_Planes(ref cls_Planes_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_Planes"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_sp, ref sMsjError));

        }
        public void Filtrar_Planes(ref cls_Planes_DAL Obj_DAL, string sMsjError, string sFiltro)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new DataSet();
            Obj_DAL.sNombre_P = "@Nombre";
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Filtrar_Planes"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp, Obj_DAL.sNombre_P,SqlDbType.VarChar,sFiltro, ref sMsjError));
        }
        public void Insertar_Planes(ref cls_Planes_DAL Obj_DAL, string sValor1, string sValor2, string sValor3, string sValor4, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Plan", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                       //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", 2, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Costo", 4, sValor3);
            Obj_DAL.dtParametros.Rows.Add("ID_Cobertura", 1, sValor4);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Planes"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);//es sin I porque la tabla no tiene identity las que si lo llevan usan el otro metodo
        }
        public void Delete_Planes(ref cls_Planes_DAL Obj_DAL, string sValor, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_PLAN", 1, sValor);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Delete_Planes"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
        public void Editar_Planes(ref cls_Planes_DAL Obj_DAL, string sValor1, string sValor2, string sValor3, string sValor4, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Plan", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                  //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", 2, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Costo", 4, sValor3);
            Obj_DAL.dtParametros.Rows.Add("ID_Cobertura", 1, sValor4);
            Obj_DAL.dtParametros.Rows.Add("plan", 1, sValor1);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Update_Planes"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }

    }
}
