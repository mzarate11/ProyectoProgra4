using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL.DAL_ADMIN
{
    public class cls_PolizaDAL
    {
        private string _sNombre_sp, _sNTablar, _sNombre_P;

        private DataSet DS;

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

        public string sNombre_sp
        {
            get
            {
                return _sNombre_sp;
            }

            set
            {
                _sNombre_sp = value;
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
