using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;

namespace BLL
{
    public class cls_DB_BLL
    {
        public void CrearDtParametros(ref cls_DB_DAL Obj_DAL)
        {
            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL.dtParametros.Columns.Add(dcNombre);
            Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
            Obj_DAL.dtParametros.Columns.Add(dcValor);
        }

        public void Traer_cnx(ref cls_DB_DAL ObjDB_DAL)
        {
            try
            {
                ObjDB_DAL.sCadena = ConfigurationManager.ConnectionStrings[].ToString().Trim();

                ObjDB_DAL.sql_CNX = new SqlConnection(ObjDB_DAL.sCadena);

                ObjDB_DAL.sMsgError = string.Empty;
            }
            catch (Exception ex)
            {
                ObjDB_DAL.sCadena = string.Empty;
                ObjDB_DAL.sql_CNX = null;
                ObjDB_DAL.sMsgError = ex.Message.ToString();
            }

        }

        public void Abrir_cnx(ref cls_DB_DAL ObjDB_DAL)
        {
            try
            {
                Traer_cnx(ref ObjDB_DAL);
                if (ObjDB_DAL.sql_CNX != null)
                {
                    if(ObjDB_DAL.sql_CNX.State == ConnectionState.Closed)
                    {
                        ObjDB_DAL.sql_CNX.Open();
                    }
                    ObjDB_DAL.sMsgError = string.Empty;

                }
            }
            catch (Exception ex)
            {
                ObjDB_DAL.sCadena = string.Empty;
                ObjDB_DAL.sql_CNX = null;
                ObjDB_DAL.sMsgError = ex.Message.ToString();
            }
        }

        public void Cerrar_cnx(ref cls_DB_DAL ObjDB_DAL)
        {
            try
            {
                Traer_cnx(ref ObjDB_DAL);
                if (ObjDB_DAL.sql_CNX != null)
                {
                    if (ObjDB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        ObjDB_DAL.sql_CNX.Close();
                    }
                    ObjDB_DAL.sMsgError = string.Empty;

                }

            }
            catch (Exception ex)
            {
                ObjDB_DAL.sCadena = string.Empty;
                ObjDB_DAL.sql_CNX = null;
                ObjDB_DAL.sMsgError = ex.Message.ToString();
            }

        }


    }
}
