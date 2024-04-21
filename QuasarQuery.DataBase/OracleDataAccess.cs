using System;
using System.Collections.Generic;
using System.Text;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Data;
using Oracle.DataAccess.Types;
using QuasarQuery.Entity;
using QuasarQuery.Entity.Interface;
using QuasarQuery.Core;
using QuasarQuery.Common;
using QuasarQuery.Entity.Enumeradores;
using System.Data.SqlClient;

namespace QuasarQuery.DataBase
{
    public class OracleDataAccess: IDataAccess
    {

        #region Miembros de IDataAccess

        public ValidateResult SetConnect(ref Session pSession)
        {
            ValidateResult Result = new ValidateResult();
            OracleConnection connect = new OracleConnection(pSession.ConnectionString);
            try
            {
                connect.Open();
                pSession.ConnectResult = QuasarQuery.Entity.Enumeradores.EConnectResult.Correct;
                Result.Info(Common.Constantes.KEY_CONNECTION_STABLISHED);
                return Result;
            }
            catch (Exception ex)
            {
                pSession.ConnectResult = QuasarQuery.Entity.Enumeradores.EConnectResult.Error;
                Result.Error(String.Format("{0}: {1}", Common.Constantes.KEY_CONNECTION_FAILE, ex.Message));
                return Result;
            }
        }

        public DataTable ExecuteQuery(Session pSession, string query, DataTypeCollection parametros)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleRefCursor cursor = null;
                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();

                        foreach (DataType vartype in parametros)
                        {
                            cmd.Parameters.Add(vartype.Name, OracleDbType.Int32).Direction = ParameterDirection.Output;
                            //cmd.Parameter.Add("CUR_SEL", OracleDbType.RefCursor).Direction = ParameterDirection.Output; 
                        }

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                
                return null;
            }

        }

        public QuasarQuery.Core.DataBaseObject GetUserObjects(Session pSession)
        {
            try
            { 
                DataBaseObject DBUserAll = new DataBaseObject();
                TablesCollection tables = new TablesCollection();
                ColumnsCollection columns = new ColumnsCollection();
                ProcedureCollection procedures = new ProcedureCollection();
                FunctionCollection functions = new FunctionCollection();

                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        //Tablas
                        cmd.Connection = cn;
                        cmd.CommandText = "select table_name TABLENAME  from user_tables";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cn.Open();
                        using (OracleDataReader dr = cmd.ExecuteReader())
                        {
                            Table table;
                            while (dr.Read())
                            {
                                table = new Table();
                                tables.Add(new EntityMapper<Table>(dr, table).FillEntity());
                            }
                        }

                        ////Columnas
                        //cmd.Parameter.Clear();
                        //cmd.CommandText = "select table_name, column_name ColumnName, data_type DataType, data_type_mod, data_type_owner," +
                        //                  "data_length, data_precision, data_scale, nullable, column_id," +
                        //                  "default_length, data_default, num_distinct, low_value, high_value," +
                        //                  "density, num_nulls, num_buckets, last_analyzed, sample_size," +
                        //                  "character_set_name, char_col_decl_length," + 
                        //                  "global_stats, user_stats, avg_col_len, char_length, char_used," + 
                        //                  "v80_fmt_image, data_upgraded, histogram " +
                        //                  "from user_tab_cols";
                        //using (OracleDataReader dr = cmd.ExecuteReader())
                        //{
                        //    Column column;
                        //    while (dr.Read())
                        //    {
                        //        column = new Column();
                        //        columns.Add(new EntityMapper<Column>(dr, column).FillEntity());
                        //    }
                        //}

                        //Procedures
                        cmd.Parameters.Clear();
                        cmd.CommandText = "select object_name PROCEDURENAME from user_objects where object_type = 'PROCEDURE'";
                        using (OracleDataReader dr = cmd.ExecuteReader())
                        {
                            Procedure procedure;
                            while (dr.Read())
                            {
                                procedure = new Procedure();
                                procedures.Add(new EntityMapper<Procedure>(dr, procedure).FillEntity());
                            }
                        }

                        cmd.Parameters.Clear();
                        cmd.CommandText = "select object_name FUNCTIONNAME from user_objects where object_type = 'FUNCTION'";
                        using (OracleDataReader dr = cmd.ExecuteReader())
                        {
                            Function function;
                            while (dr.Read())
                            {
                                function = new Function();
                                functions.Add(new EntityMapper<Function>(dr, function).FillEntity());
                            }
                        }
                    }
                    cn.Close();
                    DBUserAll.Tables = tables;
                    DBUserAll.Procedures = procedures;
                    DBUserAll.Functions = functions;
                }

                return DBUserAll;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetSchema(Session pSession, string pTableName)
        {
            try
            {
                DataTable dt;
                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = "select * from " + pTableName;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cn.Open();
                        using (OracleDataReader dr = cmd.ExecuteReader( CommandBehavior.SchemaOnly))
                        {
                            dt = dr.GetSchemaTable();
                            dr.Close();
                        }
                    }
                    cn.Close();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetTableInfo(Session pSession, string pTableName)
        {
            try
            {
                DataTable dt;
                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = "select * from " + pTableName;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cn.Open();
                        using (OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
                        {
                            dt = dr.GetSchemaTable();
                            dr.Close();
                        }
                    }
                    cn.Close();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string GetScriptText(Session pSession, ETypeScript typeScript, string pTableName)
        {

            try
            {
                string script = string.Empty;

                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = "select * from " + pTableName;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cn.Open();
                        using (OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
                        {
                            DataTable dt = dr.GetSchemaTable();
                            dr.Close();

                            if (typeScript == QuasarQuery.Entity.Enumeradores.ETypeScript.Select)
                            {
                                string columns = string.Empty;
                                
                                foreach (DataRow row in dt.Rows)
                                {
                                    if (string.IsNullOrEmpty(columns))
                                    {
                                        columns = row[0].ToString();
                                    }
                                    else
                                    {
                                        columns = columns + ", " + row[0].ToString();
                                    }
                                }
                                script = "SELECT " + columns + " FROM " + pTableName.ToUpper();
                            }
                        }

                    }
                    cn.Close();
                }

                return script;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion




        #region IDataAccess Members


        public DataTable ExecuteQuery(Session pSession, string pQuery)
        {
            try
            {
                DataTable dt = new DataTable();
                using (OracleConnection cn = new OracleConnection(pSession.ConnectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = pQuery;
                        cmd.CommandType = CommandType.Text;                         
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        #endregion



        #region IDataAccess Members


        public string CodeStoreProcedureFromTablee(string TableName, string pConnectString, EnumProviders pProvider)
        {
            throw new NotImplementedException();
        }

        public Procedure MetaDataFromStoreProcedure(string pPackague, string pCommandText)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
