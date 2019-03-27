using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;

namespace SVC.Contracts
{
    public class cls_DB : Interfaces.I_DB
    {
        public DataTable ListarDatos(string sNombreSP, ref string sMsjError)
        {
            cls_DB_BLL Obj_DB_BLL = new cls_DB_BLL();

            return Obj_DB_BLL.Ejec_DataAdapter(sNombreSP, "", SqlDbType.VarChar, "", ref sMsjError);

        }
    }
}
