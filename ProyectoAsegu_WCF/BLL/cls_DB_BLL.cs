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
    
        public DataTable Ejec_DataAdapter(string sNombre_SP, string sNombreParametro, SqlDbType DbType, string sValorParametro, ref string sMsjError)
        {
            cls_DB_DAL ObjDB_DAL = new cls_DB_DAL();
            try
            {

                ObjDB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                ObjDB_DAL.sql_CNX = new SqlConnection(ObjDB_DAL.sCadena);

                if (ObjDB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    ObjDB_DAL.sql_CNX.Open();
                }

                ObjDB_DAL.sql_DA = new SqlDataAdapter(sNombre_SP, ObjDB_DAL.sql_CNX);



                ObjDB_DAL.sql_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (sValorParametro != string.Empty)
                {
                    ObjDB_DAL.sql_DA.SelectCommand.Parameters.Add(sNombreParametro, DbType).Value = sValorParametro;

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

            public bool ExecuteNonQuery(string sNombre_SP, DataTable dtParametros, ref string sMsjError)
            {
            cls_DB_DAL Obj_DB_DAL = new cls_DB_DAL();
            try
            {
                
                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                Obj_DB_DAL.sql_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.sql_CNX.Open();
                }

                Obj_DB_DAL.sql_CMD = new SqlCommand(sNombre_SP, Obj_DB_DAL.sql_CNX);

                Obj_DB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

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
                                sqlDataType = SqlDbType.DateTime;
                                break;

                            case "4":
                                sqlDataType = SqlDbType.Money;
                                break;
                            case "5":
                                sqlDataType = SqlDbType.Bit;
                                break;
                            default:
                                break;


                        }
                        Obj_DB_DAL.sql_CMD.Parameters.Add(dr[0].ToString(), sqlDataType).Value = dr[2].ToString();
                    }
                }
                    Obj_DB_DAL.sql_CMD.ExecuteNonQuery();

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
                if (Obj_DB_DAL.sql_CNX != null)
                {
                    if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.sql_CNX.Close();
                    }

                    Obj_DB_DAL.sql_CNX.Dispose();
                }

            }
        }
            
        public bool ExecuteScalar(string sNombre_SP, DataTable dtParametros, int iValorScalar, ref string sMsjError)
        {
            cls_DB_DAL Obj_DB_DAL = new cls_DB_DAL();
            try
            {

                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                Obj_DB_DAL.sql_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.sql_CNX.Open();
                }

                Obj_DB_DAL.sql_CMD = new SqlCommand(sNombre_SP, Obj_DB_DAL.sql_CNX);

                Obj_DB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

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
                                sqlDataType = SqlDbType.DateTime;
                                break;

                            case "4":
                                sqlDataType = SqlDbType.Money;
                                break;
                            case "5":
                                sqlDataType = SqlDbType.Bit;
                                break;
                            default:
                                break;


                        }
                        Obj_DB_DAL.sql_CMD.Parameters.Add(dr[0].ToString(), sqlDataType).Value = dr[2].ToString();
                    }
                }
               iValorScalar = Convert.ToInt32(Obj_DB_DAL.sql_CMD.ExecuteScalar());

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
                if (Obj_DB_DAL.sql_CNX != null)
                {
                    if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.sql_CNX.Close();
                    }

                    Obj_DB_DAL.sql_CNX.Dispose();
                }

            }
        }
        public int ExecuteNonQueryL(string sNombre_SP, DataTable dtParametros, ref string sMsjError)
        {
            cls_DB_DAL Obj_DB_DAL = new cls_DB_DAL();
            try
            {

                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();

                Obj_DB_DAL.sql_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.sql_CNX.Open();
                }

                Obj_DB_DAL.sql_CMD = new SqlCommand(sNombre_SP, Obj_DB_DAL.sql_CNX);

                Obj_DB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

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
                                sqlDataType = SqlDbType.DateTime;
                                break;

                            case "4":
                                sqlDataType = SqlDbType.Money;
                                break;
                            case "5":
                                sqlDataType = SqlDbType.Bit;
                                break;
                            default:
                                break;


                        }
                        Obj_DB_DAL.sql_CMD.Parameters.Add(dr[0].ToString(), sqlDataType).Value = dr[2].ToString();
                        
                    }
                }
                SqlParameter p1 = new SqlParameter("ret", SqlDbType.Int);
                p1.Direction = ParameterDirection.ReturnValue;
                Obj_DB_DAL.sql_CMD.Parameters.Add(p1);
                Obj_DB_DAL.sql_CMD.ExecuteNonQuery();
                int iLogin;
                iLogin = Convert.ToInt32(Obj_DB_DAL.sql_CMD.Parameters["ret"].Value);
                sMsjError = string.Empty;
                return iLogin;
            }

            catch (SqlException ex)
            {
                sMsjError = ex.Message.ToString();
                return 0;
            }
            finally
            {
                if (Obj_DB_DAL.sql_CNX != null)
                {
                    if (Obj_DB_DAL.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.sql_CNX.Close();
                    }

                    Obj_DB_DAL.sql_CNX.Dispose();
                }

            }
        }
    }
      

 }

 

