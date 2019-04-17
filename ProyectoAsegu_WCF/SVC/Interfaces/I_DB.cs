using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;


namespace SVC.Interfaces
{
    [ServiceContract]
    public interface I_DB
    {
        [OperationContract]
        DataTable ListarDatos(string sNombreSP, ref string sMsjError);

        [OperationContract]
        DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DBType ,string sValor, ref string sMsjError);

        [OperationContract]
        bool Consultas_sin_I(string sNombreSP, DataTable dtParametros, ref string sMsjError);

        [OperationContract]
        string Consuultas_con_I(string sNombreSP, DataTable dtParametros, ref string sValorScalar, ref string sMsjError);
    }
}
