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
            Obj_DAL.dtParametros = new DataTable("Parametros");
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

        public void Ejec_DataAdapter(ref cls_DB_DAL ObjDB_DAL)
        {
            try
            {
                Traer_cnx(ref ObjDB_DAL);
                if (ObjDB_DAL.sql_CNX != null)
                {
                    Abrir_cnx(ref ObjDB_DAL);

                    ObjDB_DAL.sql_DA = new SqlDataAdapter(ObjDB_DAL.sSentencia, ObjDB_DAL.sql_CNX);

                    ObjDB_DAL.sql_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (ObjDB_DAL.dtParametros != null)
                    {
                        SqlDbType sqlDataType = SqlDbType.VarChar;
                        foreach (DataRow dr in ObjDB_DAL.dtParametros.Rows)
                        {
                            switch (dr["Tipo de Dato"].ToString())
                            {
                                case "1":
                                    sqlDataType = SqlDbType.Int;
                                    break;

                                case "2":
                                    sqlDataType = SqlDbType.VarChar;
                                    break;

                                case "3":
                                    sqlDataType = SqlDbType.DateTime;
                                    break;

                                case "4":
                                    sqlDataType = SqlDbType.Money;
                                    break;
                                default:
                                    break;

                            }
                            ObjDB_DAL.sql_DA.SelectCommand.Parameters.Add(dr["Nombre"].ToString(), sqlDataType).Value = dr["Valor"].ToString();
                        }
                    }
                    ObjDB_DAL.DS = new DataSet();
                    ObjDB_DAL.sql_DA.Fill(ObjDB_DAL.DS, ObjDB_DAL.sNombreTabla.ToString());
                }
                ObjDB_DAL.sMsgError = string.Empty;
            }
            catch (Exception ex)
            {
                ObjDB_DAL.sMsgError = ex.Message;
            }

            finally
            {
                Cerrar_cnx(ref ObjDB_DAL);
            }

        }

        public void Ejec_NonQuery(ref cls_DB_DAL ObjDB_DAL)
        {
            try
            {
                Traer_cnx(ref ObjDB_DAL);
                if (ObjDB_DAL.sql_CNX != null)
                {
                    Abrir_cnx(ref ObjDB_DAL);

                    ObjDB_DAL.sql_CMD = new SqlCommand(ObjDB_DAL.sSentencia, ObjDB_DAL.sql_CNX);
                    ObjDB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;



                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
