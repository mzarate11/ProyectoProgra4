using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cls_DB_DAL
    {
        private string _sCadena, _sSentencia, _sNombreTabla, _sMsgError;
        private int _iValorScalar;
        private DataTable _dtParametros;

        public SqlConnection sql_CNX;
        public SqlDataAdapter sql_DA;
        public SqlCommand sql_CMD;
        public DataSet DS;

        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sSentencia
        {
            get
            {
                return _sSentencia;
            }

            set
            {
                _sSentencia = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }

        public string sMsgError
        {
            get
            {
                return _sMsgError;
            }

            set
            {
                _sMsgError = value;
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
        public int iValorScalar
        {
            get
            {
                return _iValorScalar;
            }

            set
            {
                _iValorScalar = value;
            }
        }
    }
}
