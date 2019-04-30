using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class cls_p2_DAL
    {
        private string _sNombreSP, _sNombreP;

        private DataTable _dtParametros;

        private DataSet DS;

        public string sNombreSP
        {
            get
            {
                return _sNombreSP;
            }

            set
            {
                _sNombreSP = value;
            }
        }

        public string sNombreP
        {
            get
            {
                return _sNombreP;
            }

            set
            {
                _sNombreP = value;
            }
        }

        public DataTable dtParametros
        {
            get
            {
                return _dtParametros;
            }

            set
            {
                _dtParametros = value;
            }
        }

        public DataSet DS1
        {
            get
            {
                return DS;
            }

            set
            {
                DS = value;
            }
        }
    }
}
