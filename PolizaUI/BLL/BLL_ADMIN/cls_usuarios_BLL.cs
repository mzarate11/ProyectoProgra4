using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using DAL.DAL_ADMIN;

namespace BLL.BLL_ADMIN
{
    public class cls_usuarios_BLL
    {
        public void Crear_tabla(ref cls_usuarios_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_Usuario(ref cls_usuarios_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_SP = ConfigurationManager.AppSettings["listar_usuarios"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombre_SP, ref sMsjError));

        }
        public void Filtrar_Usuario(ref cls_usuarios_DAL Obj_DAL, string sMsjError, string sFiltro)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", SqlDbType.VarChar, sFiltro);
            Obj_DAL.sNombre_p = "ID_Persona";
            Obj_DAL.sNombre_SP = ConfigurationManager.AppSettings["Filtrar_Persona"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNombre_SP, Obj_DAL.sNombre_p, SqlDbType.VarChar, sFiltro, ref sMsjError));
        }
        public void Insertar_Usuarios(ref cls_usuarios_DAL Obj_DAL, ref int iValorS, string sValor1, string sValor2, string sValor3,string sValor4, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("NO_CEDULA", 1, sValor1);
            Obj_DAL.dtParametros.Rows.Add("NOMBRE", 2, sValor2);
            Obj_DAL.dtParametros.Rows.Add(@"CONTRASEÑA", 2, sValor3);
            Obj_DAL.dtParametros.Rows.Add("ROL", 1, sValor4);
            Obj_DAL.DS1 = new DataSet();
            Obj_DAL.sNombre_SP = ConfigurationManager.AppSettings["Insert_Usuario"].ToString();
            ObjSVC.Consultas_con_I(Obj_DAL.sNombre_SP, Obj_DAL.dtParametros, ref iValorS, ref sMsjError);
        }
    }
}
