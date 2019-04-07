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
    
        //se Crea en e web!!!!
        //Obj_DAL.dtParametros = new DataTable("Parametros");
        //    DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
        //    DataColumn dcTipoDato = new DataColumn(@"TipoDato", typeof(string));
        //    DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

        //    Obj_DAL.dtParametros.Columns.Add(dcNombre);
        //    Obj_DAL.dtParametros.Columns.Add(dcTipoDato);
        //    Obj_DAL.dtParametros.Columns.Add(dcValor);

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

                   
                    foreach (DataRow dr in Obj_DB_DAL.dtParametros.Rows)
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
            
        public string ExecuteScalar(string sNombre_SP, DataTable dtParametros, ref string sValorScalar ,ref string sMsjError)
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


                    foreach (DataRow dr in Obj_DB_DAL.dtParametros.Rows)
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
               Obj_DB_DAL.iValorScalar = Obj_DB_DAL.sql_CMD.ExecuteNonQuery();

                sMsjError = string.Empty;
                return sValorScalar;
            }

            catch (SqlException ex)
            {
                sMsjError = ex.Message.ToString();
                return null;
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
        //if (ObjDB_DAL.dtParametros != null)
        //{
        //    SqlDbType sqlDataType = SqlDbType.VarChar;
        //    foreach (DataRow dr in ObjDB_DAL.dtParametros.Rows)
        //    {
        //        switch (dr["Tipo de Dato"].ToString())
        //        {
        //            case "1":
        //                sqlDataType = SqlDbType.Int;
        //                break;

        //            case "2":
        //                sqlDataType = SqlDbType.VarChar;
        //                break;

        //            case "3":
        //                sqlDataType = SqlDbType.DateTime;
        //                break;

        //            case "4":
        //                sqlDataType = SqlDbType.Money;
        //                break;
        //            default:
        //                break;

    }

        //public void Ejec_NonQuery(ref cls_DB_DAL ObjDB_DAL)
        //{
        //    try
        //    {
        //        Traer_cnx(ref ObjDB_DAL);
        //        if (ObjDB_DAL.sql_CNX != null)
        //        {
        //            Abrir_cnx(ref ObjDB_DAL);

        //            ObjDB_DAL.sql_CMD = new SqlCommand(ObjDB_DAL.sSentencia, ObjDB_DAL.sql_CNX);
        //            ObjDB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

        //            if (ObjDB_DAL.dtParametros != null)
        //            {
        //                SqlDbType sqlDataType = SqlDbType.VarChar;
        //                foreach (DataRow dr in ObjDB_DAL.dtParametros.Rows)
        //                {
        //                    switch (dr["Tipo de Dato"].ToString())
        //                    {
        //                        case "1":
        //                            sqlDataType = SqlDbType.Int;
        //                            break;

        //                        case "2":
        //                            sqlDataType = SqlDbType.VarChar;
        //                            break;

        //                        case "3":
        //                            sqlDataType = SqlDbType.DateTime;
        //                            break;

        //                        case "4":
        //                            sqlDataType = SqlDbType.Money;
        //                            break;
        //                        default:
        //                            break;

        //                    }
        //                    ObjDB_DAL.sql_CMD.Parameters.Add(dr["Nombre"].ToString(), sqlDataType).Value = dr["Valor"].ToString();
        //                }
        //            }
        //            ObjDB_DAL.sql_CMD.ExecuteNonQuery();
        //        }
        //        ObjDB_DAL.sMsgError = string.Empty;
        //    }
        //    catch (SqlException ex)
        //    {
        //        ObjDB_DAL.sMsgError = ex.Message;
        //    }

        //    finally
        //    {
        //        Cerrar_cnx(ref ObjDB_DAL);
        //        ObjDB_DAL.sql_CMD.Dispose();
        //    }
        //}

        //public void Ejec_Scalar(ref cls_DB_DAL ObjDB_DAL)
        //{
        //    try
        //    {
        //        Traer_cnx(ref ObjDB_DAL);
        //        if (ObjDB_DAL.sql_CNX != null)
        //        {
        //            Abrir_cnx(ref ObjDB_DAL);

        //            ObjDB_DAL.sql_CMD = new SqlCommand(ObjDB_DAL.sSentencia, ObjDB_DAL.sql_CNX);
        //            ObjDB_DAL.sql_CMD.CommandType = CommandType.StoredProcedure;

        //            if (ObjDB_DAL.dtParametros != null)
        //            {
        //                SqlDbType sqlDataType = SqlDbType.VarChar;
        //                foreach (DataRow dr in ObjDB_DAL.dtParametros.Rows)
        //                {
        //                    switch (dr["Tipo de Dato"].ToString())
        //                    {
        //                        case "1":
        //                            sqlDataType = SqlDbType.Int;
        //                            break;

        //                        case "2":
        //                            sqlDataType = SqlDbType.VarChar;
        //                            break;

        //                        case "3":
        //                            sqlDataType = SqlDbType.DateTime;
        //                            break;

        //                        case "4":
        //                            sqlDataType = SqlDbType.Money;
        //                            break;
        //                        default:
        //                            break;

        //                    }
        //                    ObjDB_DAL.sql_CMD.Parameters.Add(dr["Nombre"].ToString(), sqlDataType).Value = dr["Valor"].ToString();
        //                }
        //            }
        //            ObjDB_DAL.iValorScalar = Convert.ToInt32(ObjDB_DAL.sql_CMD.ExecuteScalar());
        //        }
        //        ObjDB_DAL.sMsgError = string.Empty;
        //    }
        //    catch (SqlException ex)
        //    {
        //        ObjDB_DAL.sMsgError = ex.Message;
        //    }

        //    finally
        //    {
        //        Cerrar_cnx(ref ObjDB_DAL);
        //        ObjDB_DAL.sql_CMD.Dispose();
        //    }
        //}
    

