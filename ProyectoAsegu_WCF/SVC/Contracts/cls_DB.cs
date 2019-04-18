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

namespace SVC.Contracts
{
    public class cls_DB : Interfaces.I_DB
    {
        public DataTable ListarDatos(string sNombreSP, ref string sMsjError)
        {
            cls_DB_BLL Obj_DB_BLL = new cls_DB_BLL();

            return Obj_DB_BLL.Ejec_DataAdapter(sNombreSP, "", SqlDbType.VarChar, "", ref sMsjError);

        }

        public DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DBType , string sValor, ref string sMsjError)
        {
            cls_DB_BLL Obj_DB_BLL = new cls_DB_BLL();

            return Obj_DB_BLL.Ejec_DataAdapter(sNombreSP, sNombreParametro, SqlDbType.VarChar, sValor, ref sMsjError);

        }
        public bool Consultas_sin_I(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            cls_DB_BLL Obj_BD_BLL = new cls_DB_BLL();
            return Obj_BD_BLL.ExecuteNonQuery(sNombreSP, dtParametros, ref sMsjError);
        }

        public bool Consultas_con_I(string sNombreSP, DataTable dtParametros, ref int iValorScalar, ref string sMsjError)
        {
            cls_DB_BLL Obj_DB_BLL = new cls_DB_BLL();
            return Obj_DB_BLL.ExecuteScalar(sNombreSP, dtParametros,iValorScalar, ref sMsjError);
        }
    }
}
