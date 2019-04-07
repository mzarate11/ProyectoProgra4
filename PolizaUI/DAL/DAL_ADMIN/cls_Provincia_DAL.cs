using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL.DAL_ADMIN
{
    public class cls_Provincia_DAL
    {
        private string _sNombre_sp, _sNTablar, _sNombre_P;

        private DataTable DT;

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

        public DataTable DT1
        {
            get
            {
                return DT;
            }

            set
            {
                DT = value;
            }
        }
    }
}
