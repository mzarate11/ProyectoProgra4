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
    class cls_Distrito_BLL
    {
        public void Crear_tabla(ref cls_Distrito_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_Distritos(ref cls_Distrito_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_Distrito"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_sp, ref sMsjError));
        }
        public void Filtrar_Distritos(ref cls_Distrito_DAL Obj_DAL, string sMsjError, string sFiltro)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", SqlDbType.VarChar, sFiltro);
            Obj_DAL.sNombre_P = "Nombre";
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Filtrar_ Distrito"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp, Obj_DAL.sNombre_P, ref sMsjError));
        }
        public void Insertar_Distritos(ref cls_Distrito_DAL Obj_DAL, string sValor1, string sValor2, string sValor3, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Distrito", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                  //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", 2, sValor2);
            Obj_DAL.dtParametros.Rows.Add("ID_CANTON", 1, sValor3);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Distrito"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);//es sin I porque la tabla no tiene identity las que si lo llevan usan el otro metodo
        }
        public void Delete_Distritos(ref cls_Distrito_DAL Obj_DAL, string sValor, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Distrito", 1, sValor);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Delete_Distrito"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
    }
}
