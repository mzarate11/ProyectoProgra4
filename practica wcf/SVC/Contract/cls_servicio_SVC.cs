using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using DAL;

namespace SVC.Contract
{
    public class cls_servicio_SVC : Interface.Iservicio
    {
        //aqui solo mando los parametros que ocupo llenar desde el web
        public DataTable ListarDatos(string sNombreSP, ref string sMsjError)
        {
            cls_practicawcf_BLL ObjDB_BLL = new cls_practicawcf_BLL();

            return ObjDB_BLL.Ejec_DataAdapter(sNombreSP, "", SqlDbType.VarChar, "", ref sMsjError);
        }

        public DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DBTypr, string sValor, ref string sMsjError)
        {
            cls_practicawcf_BLL ObjDB_BLL = new cls_practicawcf_BLL();

            return ObjDB_BLL.Ejec_DataAdapter(sNombreSP, sNombreParametro, SqlDbType.VarChar, sValor, ref sMsjError);
        }
        public bool Consultas_sin_I(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            cls_practicawcf_BLL ObjDb_BLL = new cls_practicawcf_BLL();

            return ObjDb_BLL.ExecuteNonQuery(sNombreSP, dtParametros, ref sMsjError);
        }
        public bool Consultas_con_I(string sNombreSP, DataTable dtParametros, ref int iValorScalar, ref string sMsjError)
        {
            cls_practicawcf_BLL ObjDB_BLL = new cls_practicawcf_BLL();
            return ObjDB_BLL.ExecuteScalar(sNombreSP, dtParametros, iValorScalar, ref sMsjError);
        }
    }
}
