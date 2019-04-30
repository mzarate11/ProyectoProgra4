using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BLL
{
    public class cls_practicawcf_BLL
    {
        public DataTable Ejec_DataAdapter(string sNombre_sp, string sNombreParametro, SqlDbType DbType, string sValorParametro, ref string sMsjError)
        {
            cls_practicawcf_DAL ObjDB_DAL = new cls_practicawcf_DAL();
            try
            {
                ObjDB_DAL.sCadena = ConfigurationManager.ConnectionStrings["Conexion"].ToString().Trim();

                ObjDB_DAL.sql_CNX = new SqlConnection(ObjDB_DAL.sCadena);

                if (ObjDB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    ObjDB_DAL.sql_CNX.Open();
                }

                ObjDB_DAL.sql_DA = new SqlDataAdapter(sNombre_sp, ObjDB_DAL.sql_CNX);

                ObjDB_DAL.sql_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (sValorParametro != string.Empty)
                {
                    ObjDB_DAL.sql_DA.SelectCommand.Parameters.Add(sNombreParametro, DbType).Value = sNombreParametro;
                }

                ObjDB_DAL.DS = new DataSet();

                ObjDB_DAL.sql_DA.Fill(ObjDB_DAL.DS);

                sMsjError = string.Empty;

                return ObjDB_DAL.DS.Tables[0];

            }
            catch (SqlException ex)
            {
                sMsjError = ex.Message.ToString();
                return null;
            }
            finally
            {
                if (ObjDB_DAL.sql_CNX != null)
                {
                    if (ObjDB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        ObjDB_DAL.sql_CNX.Close();
                    }

                    ObjDB_DAL.sql_CNX.Dispose();
                }
            }
        }

        public bool ExecuteNonQuery(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            cls_practicawcf_DAL ObjDB_DAL = new cls_practicawcf_DAL();
            try
            {

                ObjDB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                ObjDB_DAL.sql_CNX = new SqlConnection(ObjDB_DAL.sCadena);

                if (ObjDB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    ObjDB_DAL.sql_CNX.Open();
                }

                ObjDB_DAL.sql_CMD = new SqlCommand(sNombreSP, ObjDB_DAL.sql_CNX);

                ObjDB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

                if (dtParametros.Rows.Count > 0)
                {

                    foreach (DataRow dr in dtParametros.Rows)
                    {
                        SqlDbType sqlDataType = SqlDbType.VarChar;
                        switch (dr[1].ToString())
                        {
                            case "1":
                                sqlDataType = SqlDbType.Int;
                                break;
                            case "2":
                                sqlDataType = SqlDbType.VarChar;
                                break;
                            case "3":
                                sqlDataType = SqlDbType.Char;
                                break;
                            default:
                                break;

                        }
                        ObjDB_DAL.sql_CMD.Parameters.Add(dr[0].ToString(), sqlDataType).Value = dr[2].ToString();
                    }
                }
                ObjDB_DAL.sql_CMD.ExecuteNonQuery();

                sMsjError = string.Empty;
                return true;
            }
            catch (SqlException ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
            finally
            {
                if (ObjDB_DAL.sql_CNX != null)
                {
                    if (ObjDB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        ObjDB_DAL.sql_CNX.Close();
                    }

                    ObjDB_DAL.sql_CNX.Dispose();
                }
            }
        }
        public bool ExecuteScalar(string sNombreSP, DataTable dtParametros, int iValorScalar, ref string sMsjError)
        {
            cls_practicawcf_DAL ObjDB_DAL = new cls_practicawcf_DAL();
            try
            {

                ObjDB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                ObjDB_DAL.sql_CNX = new SqlConnection(ObjDB_DAL.sCadena);

                if (ObjDB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    ObjDB_DAL.sql_CNX.Open();
                }

                ObjDB_DAL.sql_CMD = new SqlCommand(sNombreSP, ObjDB_DAL.sql_CNX);

                ObjDB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

                if (dtParametros.Rows.Count > 0)
                {

                    foreach (DataRow dr in dtParametros.Rows)
                    {
                        SqlDbType sqlDataType = SqlDbType.VarChar;
                        switch (dr[1].ToString())
                        {
                            case "1":
                                sqlDataType = SqlDbType.Int;
                                break;
                            case "2":
                                sqlDataType = SqlDbType.VarChar;
                                break;
                            case "3":
                                sqlDataType = SqlDbType.Char;
                                break;
                            default:
                                break;

                        }
                        ObjDB_DAL.sql_CMD.Parameters.Add(dr[0].ToString(), sqlDataType).Value = dr[2].ToString();
                    }
                }
                iValorScalar = Convert.ToInt32(ObjDB_DAL.sql_CMD.ExecuteScalar());

                sMsjError = string.Empty;
                return true;
            }
            catch (SqlException ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
            finally
            {
                if (ObjDB_DAL.sql_CNX != null)
                {
                    if (ObjDB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        ObjDB_DAL.sql_CNX.Close();
                    }

                    ObjDB_DAL.sql_CNX.Dispose();
                }
            }
        }
    }
}
