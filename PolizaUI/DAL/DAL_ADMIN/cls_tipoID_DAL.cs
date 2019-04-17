using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.DAL_ADMIN
{
    public class cls_tipoID_DAL
    {
        private string _sNombre_P, _sNombre_SP;

        private DataSet DS;

        private DataTable _dtParametros;

        public string sNombre_P
        {
            get
            {
                return _sNombre_P;
            }

            set
            {
                _sNombre_P = value;
            }
        }

        public string sNombre_SP
        {
            get
            {
                return _sNombre_SP;
            }

            set
            {
                _sNombre_SP = value;
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
    }
}
