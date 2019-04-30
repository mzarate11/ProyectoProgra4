using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Configuration;
using System.Data;

namespace BLL
{
    public class cls_p2_BLL
    {
        public void Crear_Tabla(ref cls_p2_DAL Obj_DAL)
        {
            Obj_DAL.dtParametros = new DataTable("parametros");
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }

        public void listar_p2(ref cls_p2_DAL Obj_DAL, string sMsjError)
        {
            sreferencia.IservicioClient ObjSVC = new sreferencia.IservicioClient();
            Obj_DAL.DS1 = new DataSet();
            Obj_DAL.sNombreSP = ConfigurationManager.AppSettings["Listar_p2"].ToString().Trim();
            Obj_DAL.DS1.Tables.Add(ObjSVC.ListarDatos(Obj_DAL.sNombreSP,ref sMsjError));
        }
        public void Insertar_p2(ref cls_p2_DAL Obj_DAL, string sValor1, string sValor2, ref string sMsjError)
        {
            sreferencia.IservicioClient Obj_SVC = new sreferencia.IservicioClient();
            Crear_Tabla(ref Obj_DAL);
            Obj_DAL.dtParametros.Rows.Add("@id", 1, sValor1);
            Obj_DAL.dtParametros.Rows.Add("@descrip", 2, sValor2);
            Obj_DAL.sNombreSP = ConfigurationManager.AppSettings["insert_p2"].ToString().Trim();
            Obj_SVC.Consultas_sin_I(Obj_DAL.sNombreSP,Obj_DAL.dtParametros,ref sMsjError); 
        }
    }
}
