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
    public class cls_Genero_BLL
    {
        public void Crear_tabla(ref cls_genero_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("Parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }
        public void Listar_genero(ref cls_genero_DAL Obj_DAL, string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNompre_SP = ConfigurationManager.AppSettings["listar_genero"].ToString();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNompre_SP, ref sMsjError));

        }
        public void Filtrar_genero(ref cls_genero_DAL Obj_DAL, string sFiltro, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Obj_DAL.DS1 = new System.Data.DataSet();
            Obj_DAL.sNombre_P = "@Tipo";
            Obj_DAL.sNompre_SP = ConfigurationManager.AppSettings["Filtrar_provincia"].ToString();//cambiar sp
            Obj_DAL.DS1.Tables.Add(ObjSVC.FiltrarDatos(Obj_DAL.sNompre_SP, Obj_DAL.sNombre_P, SqlDbType.VarChar, sFiltro, ref sMsjError));
        }
        public void Insertar_genero(ref cls_genero_DAL Obj_DAL, string sValor1, string sValor2, ref string sMsjError)
        {
            Svc_DataBase.I_DBClient ObjSVC = new Svc_DataBase.I_DBClient();
            Crear_tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("@ID_Genero", 1, sValor1); //el número corresponde al valor dentro del switch creado en el wfc -
                                                                       //en el metodo excecute nonquery cambia dependiedo del tipo de dato a insertar o valorar
            Obj_DAL.dtParametros.Rows.Add("@TIPO", 2, sValor2);
            Obj_DAL.sNompre_SP = ConfigurationManager.AppSettings["Insert_Provincia"].ToString();//cambiar sp
            ObjSVC.Consultas_sin_I(Obj_DAL.sNompre_SP, Obj_DAL.dtParametros, ref sMsjError);//es sin I porque la tabla no tiene identity las que si lo llevan usan el otro metodo
        }
    }
}
