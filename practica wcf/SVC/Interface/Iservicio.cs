using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;

namespace SVC.Interface
{
    [ServiceContract]
    interface Iservicio
    {
        [OperationContract]
        DataTable ListarDatos(string sNombreSP, ref string sMsjError);

        [OperationContract]
        DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DBTypr, string sValor, ref string sMsjError);

        [OperationContract]
        bool Consultas_sin_I(string sNombreSP, DataTable dtParametros, ref string sMsjError);

        [OperationContract]
        bool Consultas_con_I(string sNombreSP, DataTable dtParametros, ref int iValorScalar, ref string sMsjError);
    }
}
