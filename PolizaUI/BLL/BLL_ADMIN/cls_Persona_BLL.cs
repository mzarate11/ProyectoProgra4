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
    public class cls_Persona_BLL
    {
        public void Crear_tabla(ref cls_Persona_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_Persona(ref cls_Persona_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Listar_Persona"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_sp, ref sMsjError));

        }
        public void Filtrar_Persona(ref cls_Persona_DAL Obj_DAL, string sMsjError, string sFiltro)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", SqlDbType.VarChar, sFiltro);
            Obj_DAL.sNombre_P = "ID_Persona";
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Filtrar_Persona"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_sp,Obj_DAL.sNombre_P,SqlDbType.VarChar,sFiltro, ref sMsjError));
        }
        public void Insertar_Persona(ref cls_Persona_DAL Obj_DAL, string sValor2, string sValor3, string sValor4, string sValor5, string sValor6, string sValor7, string sValor8, string sValor9, string sValor10, string sValor11, string sValor12, string sValor13, string sValor14, string sValor15, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("@Num_Cedula", 1, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Nombre", 2, sValor3);
            Obj_DAL.dtParametros.Rows.Add("APELLIDO1", 2, sValor4);
            Obj_DAL.dtParametros.Rows.Add("APELLIDO2", 2, sValor5);
            Obj_DAL.dtParametros.Rows.Add("Correo_Electronico", 2, sValor6);
            Obj_DAL.dtParametros.Rows.Add("Telefono", 1, sValor7);
            Obj_DAL.dtParametros.Rows.Add("FechaNacimiento", 3, sValor8);
            Obj_DAL.dtParametros.Rows.Add("Apoderado", 2, sValor9);
            Obj_DAL.dtParametros.Rows.Add("ID_PROVINCIA", 1, sValor10);
            Obj_DAL.dtParametros.Rows.Add("ID_CANTON", 1, sValor11);
            Obj_DAL.dtParametros.Rows.Add("ID_DISTRITO", 1, sValor12);
            Obj_DAL.dtParametros.Rows.Add("ID_GENERO", 1, sValor13);
            Obj_DAL.dtParametros.Rows.Add("ID_ESTADO_CIVIL", 1, sValor14);
            Obj_DAL.dtParametros.Rows.Add("Tipo_Identificacion", 1, sValor15);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Persona"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros,ref sMsjError);
        }
        public void Insertar_Personab(ref cls_Persona_DAL Obj_DAL, string sValor2, string sValor3, string sValor4, string sValor5, string sValor6, string sValor7, string sValor8, string sValor10, string sValor11, string sValor12, string sValor13, string sValor14, string sValor15, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("@Num_Cedula", 1, sValor2);
            Obj_DAL.dtParametros.Rows.Add("Nombre", 2, sValor3);
            Obj_DAL.dtParametros.Rows.Add("APELLIDO1", 2, sValor4);
            Obj_DAL.dtParametros.Rows.Add("APELLIDO2", 2, sValor5);
            Obj_DAL.dtParametros.Rows.Add("Correo_Electronico", 2, sValor6);
            Obj_DAL.dtParametros.Rows.Add("Telefono", 1, sValor7);
            Obj_DAL.dtParametros.Rows.Add("FechaNacimiento", 3, sValor8);
            Obj_DAL.dtParametros.Rows.Add("ID_PROVINCIA", 1, sValor10);
            Obj_DAL.dtParametros.Rows.Add("ID_CANTON", 1, sValor11);
            Obj_DAL.dtParametros.Rows.Add("ID_DISTRITO", 1, sValor12);
            Obj_DAL.dtParametros.Rows.Add("ID_GENERO", 1, sValor13);
            Obj_DAL.dtParametros.Rows.Add("ID_ESTADO_CIVIL", 1, sValor14);
            Obj_DAL.dtParametros.Rows.Add("Tipo_Identificacion", 1, sValor15);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Insert_Persona2"].ToString();// aqui se lee el stored procedure siempre desde el web config y el nombre del key
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }
        public void Delete_Persona(ref cls_Persona_DAL Obj_DAL, string sValor, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("ID_Persona", 1, sValor);
            Obj_DAL.sNombre_sp = ConfigurationManager.AppSettings["Delete_Persona"].ToString();
            ObjSVC.Consultas_sin_I(Obj_DAL.sNombre_sp, Obj_DAL.dtParametros, ref sMsjError);
        }

    }
}
