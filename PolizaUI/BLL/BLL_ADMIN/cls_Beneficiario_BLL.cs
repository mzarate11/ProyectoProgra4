using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DAL.DAL_ADMIN;

namespace BLL.BLL_ADMIN
{
    public class cls_Beneficiario_BLL
    {
        public void Crear_tabla(ref cls_Beneficiario_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_Beneficiario(ref cls_Beneficiario_DAL Obj_DAL, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_beneficiario"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_sp, ref sMsjError));

        }
        public void Filtrar_Beneficiario(ref cls_Beneficiario_DAL Obj_DAL, string sFiltro, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new DataSet();
            Obj_DAL.sNombre_P = "@ID_Beneficiario";
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Filtrar_Beneficiario"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp, Obj_DAL.sNombre_P, SqlDbType.VarChar, sFiltro, ref sMsjError));
        }
        public void Insertar_Beneficiario(ref cls_Beneficiario_DAL Obj_DAL, string sValor1, string sValor2, string sValor3, string sValor4, string sValor5, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Benficiario", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                    //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("Porcentaje", 1, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Nombre", 2, sValor3);
            Obj_DAL.dtParametros.Rows.Add("Apellido1", 2, sValor4);
            Obj_DAL.dtParametros.Rows.Add("Apellido2", 2, sValor5);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Beneficiario"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);//es sin I porque la tabla no tiene identity las que si lo llevan usan el otro metodo
        }
        public void Delete_Beneficiario(ref cls_Beneficiario_DAL Obj_DAL, string sValor, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("id_BENE", 1, sValor);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Delete_Beneficiario"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
        public void filtro_drop(ref cls_Beneficiario_DAL Obj_DAL, string iFiltro, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.sNombre_P = "@ID_Benficiario";
            Obj_DAL.DS1 = new DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["drop_cant"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp, Obj_DAL.sNombre_P, SqlDbType.Int, iFiltro, ref sMsjError));
        }
        public void Editar_Beneficiario(ref cls_Beneficiario_DAL Obj_DAL, string sValor1, string sValor2, string sValor3, string sValor4, string sValor5, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Benficiario", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                          //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("Porcentaje", 1, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Nombre", 2, sValor3);
            Obj_DAL.dtParametros.Rows.Add("Apellido1", 2, sValor4);
            Obj_DAL.dtParametros.Rows.Add("Apellido2", 2, sValor5);
            Obj_DAL.dtParametros.Rows.Add("id_BENE", 1, sValor1);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Update_Beneficiario"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
    }
}
