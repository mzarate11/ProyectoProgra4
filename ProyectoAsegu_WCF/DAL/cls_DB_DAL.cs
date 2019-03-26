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

        private DataTable _dtParametros = new DataTable("Parametros");

        private SqlConnection _sql_CNX;
        private SqlDataAdapter _sql_DA;
        private DataSet _DS;

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

        public SqlConnection sql_CNX
        {
            get
            {
                return _sql_CNX;
            }

            set
            {
                _sql_CNX = value;
            }
        }

        public SqlDataAdapter sql_DA
        {
            get
            {
                return _sql_DA;
            }

            set
            {
                _sql_DA = value;
            }
        }

        public DataSet DS
        {
            get
            {
                return _DS;
            }

            set
            {
                _DS = value;
            }
        }
    }
}
