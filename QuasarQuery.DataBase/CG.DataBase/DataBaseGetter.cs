using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
#region "NameSpaces"
// ERROR: Not supported in C#: OptionDeclaration
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Text;
using System.Data.OracleClient;
using System.Xml.Serialization;
using QuasarQuery.Common;
using QuasarQuery.Core;

#endregion
namespace QuasarQuery.DataBase
{

// The sctrucure is to hold parameter info. An Array of this structure
// is sent to the DAL bcos we should not bind to a 
// specific type of parameter like SQLParamter
[Serializable()]
public struct ParamStruct
{
    public string ParamName;
    public DbType DataType;
    public object value;
    public ParameterDirection direction;
    public string sourceColumn;
    public Int16 size;
}

#region "Provider Factory"

public class ProviderFactory
{

    // Should not be instantiated. So that is always shared
    private ProviderFactory()
    {
    }


    #region "Command"
    public static IDbCommand GetCommand(EnumProviders provider)
    {

        switch (provider)
        {
            case EnumProviders.ODBC:
                return new OdbcCommand();
            case EnumProviders.SQLServer:
                return new SqlCommand();
            case EnumProviders.OLEDB:
                return new OleDbCommand();
            case EnumProviders.Oracle:
                return new OracleCommand();
            default:
                return null;
        }

    }


    public static IDbCommand GetCommand(string strCmdText, CommandType cmdType, int cmdTimeout, ParamStruct[] ParameterArray, EnumProviders provider)
    {
        IDbCommand cmd = GetCommand(provider);
        Int16 i = default(Int16);

        if ((ParameterArray != null))
        {
            for (i = 0; i <= ParameterArray.Length - 1; i++)
            {
                ParamStruct ps = ParameterArray[i];
                IDbDataParameter pm = GetParameter(ps.ParamName, ps.direction, ps.value, ps.DataType, ps.sourceColumn, ps.size, provider);
                cmd.Parameters.Add(pm);
            }
        }
        cmd.CommandType = cmdType;
        cmd.CommandText = strCmdText;
        return cmd;
    }

    #endregion

    #region "Connection"
    public static IDbConnection GetConnection(EnumProviders provider)
    {

        switch (provider)
        {
            case EnumProviders.ODBC:
                return new OdbcConnection();
            case EnumProviders.SQLServer:
                return new SqlConnection();
            case EnumProviders.OLEDB:
                return new OleDbConnection();
            case EnumProviders.Oracle:
                return new OracleConnection();
            default:
                return null;
        }

    }

    public static IDbConnection GetConnection(string strConnString, EnumProviders provider)
    {
        IDbConnection con = GetConnection(provider);
        con.ConnectionString = strConnString;
        return con;

    }
    #endregion

    #region "Data Adapter"
    public static IDbDataAdapter GetAdapter(EnumProviders provider)
    {

        switch (provider)
        {
            case EnumProviders.ODBC:
                return new OdbcDataAdapter();
            case EnumProviders.SQLServer:
                return new SqlDataAdapter();
            case EnumProviders.OLEDB:
                return new OleDbDataAdapter();
            default:
                return null;
        }

    }

    #endregion

    #region "Parameters"

    public static IDbDataParameter GetParameter(EnumProviders provider)
    {
        switch (provider)
        {
            case EnumProviders.ODBC:
                return new OdbcParameter();
            case EnumProviders.SQLServer:
                return new SqlParameter();
            case EnumProviders.OLEDB:
                return new OleDbParameter();
            case  EnumProviders.Oracle:
                return new OracleParameter();
            default:
                return null;

        }
    }

    public static IDbDataParameter GetParameter(string paramName, ParameterDirection paramDirection, object paramValue, DbType paramtype, string sourceColumn, Int16 size, EnumProviders provider)
    {
        IDbDataParameter param = GetParameter(provider);
        param.ParameterName = paramName;
        param.DbType = paramtype;
        if (size > 0)
        {
            param.Size = size;
        }
        if ((paramValue != null))
        {
            param.Value = paramValue;
        }
        param.Direction = paramDirection;
        if (!string.IsNullOrEmpty(sourceColumn))
        {
            param.SourceColumn = sourceColumn;
        }
        return param;
    }

    #endregion

    #region "Transaction"

    public static IDbTransaction GetTransaction(IDbConnection conn, IsolationLevel transisolationLevel)
    {
        return conn.BeginTransaction(transisolationLevel);
    }


    #endregion

    #region "CommandBuilder"
    public static object GetCommandBuilder(EnumProviders provider)
    {
        switch (provider)
        {
            case EnumProviders.ODBC:
                return new OdbcCommandBuilder();
            case EnumProviders.SQLServer:
                return new SqlCommandBuilder();
            case EnumProviders.OLEDB:
                return new OleDbCommandBuilder();
            default:
                return null;
        }
    }


    #endregion

 

}
#endregion

#region "DataBaseGetter Class"

public class DataBaseGetter
{

    private IDbTransaction _trans;
    private IsolationLevel _isolationLevel;
    private IDbConnection _conn;
    private Int32 _cmdTimeout;
    private string _connString;
    private EnumProviders _provider;
    private const int COMMAND_TIMEOUT = 100;

    private CommandBehavior _commandBehavior;


    // Getting the config settings and set the default isolation level and
    // DataReader command behavior
    public DataBaseGetter()
    {
        _isolationLevel = IsolationLevel.ReadCommitted;
        _commandBehavior = CommandBehavior.CloseConnection;
    }


    // This method is used by ExecDataSet, ExecScalar, ExecReader and ExecNonQuery. This is a common piece of 
    // code called in these methods
    private void PrepareAll(ref IDbCommand cmd, ref IDbConnection conn, string strSQL, CommandType cmdType, ParamStruct[] parameterArray)
    {
        // If transaction has already been started
        if (!IsInTransaction())
        {
            conn = ProviderFactory.GetConnection(ConnectionString,Provider);
            cmd = ProviderFactory.GetCommand(strSQL, cmdType, CmdTimeout, parameterArray, Provider);
            cmd.Connection = conn;
            conn.Open();
        }
        else
        {
            cmd = ProviderFactory.GetCommand(strSQL, cmdType, CmdTimeout, parameterArray, Provider);
            cmd.Transaction = _trans;
            cmd.Connection = _conn;
        }
    }

    public ValidateResult TestConnect( EnumProviders provEnum, string ConnectionString)
    {
        try
        {
            IDbConnection Connect = ProviderFactory.GetConnection(provEnum);
            Connect.ConnectionString = ConnectionString;
            Connect.Open();
            return new ValidateResult("Conexión establecida", eTypeResult.Confirmacion);
        }
        catch(Exception ex)
        {
            return new ValidateResult("Error al realizar la conexión", ex.Message, eTypeResult.Err);
        }
    }


    #region "Public Properties"
    public EnumProviders Provider
    {
        get { return _provider; }
        set { _provider = value; }
    }

    public string ConnectionString
    {
        get { return _connString; }
        set { _connString = value; }
    }

    public IsolationLevel TransIsolationLevel
    {
        get { return _isolationLevel; }
        set { _isolationLevel = value; }
    }

    public Int32 CmdTimeout
    {
        get
        {
            if (_cmdTimeout == 0)
            {
                return COMMAND_TIMEOUT;
            }
            return _cmdTimeout;
        }
        set { _cmdTimeout = value; }
    }

    // To be used exclusively by the Datareader
    public CommandBehavior ReaderCommandBehavior
    {
        get { return _commandBehavior; }
        set { _commandBehavior = value; }
    }



    #endregion

    #region "Transactions"
    public void BeginTrans(string connString, IsolationLevel transisolationLevel)
    {
        _conn = ProviderFactory.GetConnection(connString, Provider);
        _conn.Open();
        _trans = ProviderFactory.GetTransaction(_conn, transisolationLevel);
    }

    public void BeginTrans(IsolationLevel transisolationLevel)
    {
        _conn = ProviderFactory.GetConnection(_connString, Provider);
        _conn.Open();
        _trans = ProviderFactory.GetTransaction(_conn, transisolationLevel);
    }

    public void CommitTrans()
    {
        CommitTrans(true);
    }

    // This is for DataReader usage only. The caller has to pass false here so that
    // the connection is not closed before the DR is closed
    public void CommitTrans(bool CloseConnection)
    {
        _trans.Commit();
        DisposeTrans(CloseConnection);
    }

    public void AbortTrans()
    {
        if (IsInTransaction())
        {
            _trans.Rollback();
            DisposeTrans(true);
        }
    }

    private void DisposeTrans(bool CloseConnection)
    {
        if (CloseConnection)
        {
            if ((_conn != null))
            {
                _conn.Close();
                _conn.Dispose();
            }
        }
        _trans.Dispose();
    }

    public bool IsInTransaction()
    {
        return ((_trans != null));
    }

    #endregion

    //To return a DataSet after running a SQL Statement
    #region "ExecDataSet"


    public void ExecDataSet(DataSet ds, string strSQL, CommandType cmdtype)
    {
        ExecDataSet(ds, strSQL, cmdtype, null);
    }

    public DataSet ExecDataSet(string strSQL, CommandType cmdtype)
    {

        return ExecDataSet(strSQL, cmdtype, null);
    }

    public DataSet ExecDataSet(string strSQL, CommandType cmdtype, ParamStruct[] parameterArray)
    {

        DataSet ds = new DataSet("DataSet");
        ExecDataSet(ds, strSQL, cmdtype, parameterArray);
        return ds;

    }


    public void ExecDataSet(DataSet ds, string strSQL, CommandType cmdtype, ParamStruct[] parameterArray)
    {

        IDbDataAdapter da = null;
        IDbCommand cmd = null;
        IDbConnection conn = null;
        try
        {
            da = ProviderFactory.GetAdapter(Provider);
            PrepareAll(ref cmd, ref conn, strSQL, cmdtype, parameterArray);
            da.SelectCommand = cmd;
            da.Fill(ds);

        }
        catch (Exception ex)
        {
            GenericExceptionHandler(ex);
        }
        finally
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            cmd.Dispose();
            ((IDisposable)da).Dispose();
        }


    }


    #endregion

    // To run SQL Statements to return DataReader.
    #region "ExecDataReader"
    public IDataReader ExecDataReader(string strSQL, CommandType cmdtype, ParamStruct[] parameterArray)
    {

        IDbConnection conn = null;
        IDbCommand cmd = null;

        try
        {
            PrepareAll(ref cmd, ref conn, strSQL, cmdtype, parameterArray);
            
            return cmd.ExecuteReader(ReaderCommandBehavior);

        }
        catch (Exception ex)
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            GenericExceptionHandler(ex);
            return null;
        }
        finally
        {
            cmd.Dispose();
        }

    }

    public IDataReader ExecDataReader(string strSQL, CommandType cmdtype, ParamStruct[] parameterArray, CommandBehavior pCommandBehavior)
    {

        IDbConnection conn = null;
        IDbCommand cmd = null;

        try
        {
            PrepareAll(ref cmd, ref conn, strSQL, cmdtype, parameterArray);

            return cmd.ExecuteReader(pCommandBehavior);

        }
        catch (Exception ex)
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            GenericExceptionHandler(ex);
            return null;
        }
        finally
        {
            cmd.Dispose();
        }

    }

    public IDataReader ExecDataReader(string strSQL, CommandType cmdtype)
    {

        return ExecDataReader(strSQL, cmdtype, null);

    }

    public IDataReader ExecDataReader(string strSQL, CommandType cmdtype, CommandBehavior pCommandBehavior)
    {

        return ExecDataReader(strSQL, cmdtype, null, pCommandBehavior);

    }

    #endregion

    // TO run simple SQL statements W/O returning anything(records) back
    #region "ExecNonQuery"

    public int ExecNonQuery(string strSQL, CommandType cmdType)
    {
        return ExecNonQuery(strSQL, cmdType, null);
    }

    public int ExecNonQuery(string strSQL, CommandType cmdType, ParamStruct[] parameterArray)
    {

        IDbCommand cmd = null;
        IDbConnection conn = null;
        try
        {
            PrepareAll(ref cmd, ref conn, strSQL, cmdType, parameterArray);
            return cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            GenericExceptionHandler(ex);
            return -1;
        }
        finally
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            cmd.Dispose();
        }
    }


    #endregion

    #region "SaveDataSet"

    // This method saves data in a dataset with a single table and mandates the table name to be "Table".
    // Operations on a single table are batched.

    public void SaveDataSet(DataSet ds, string insertSQL, string deleteSQL, string updateSQL, ParamStruct[] InsertparameterArray, ParamStruct[] DeleteparameterArray, ParamStruct[] UpdateparameterArray)
    {
        IDbConnection cn = null;
        IDbDataAdapter da = null;
        IDbCommand cmd = null;
        try
        {
            da = ProviderFactory.GetAdapter(Provider);
            if (!IsInTransaction())
            {
                cn = ProviderFactory.GetConnection(ConnectionString, Provider);
                if (!string.IsNullOrEmpty(insertSQL))
                {
                    da.InsertCommand = ProviderFactory.GetCommand(insertSQL, CommandType.StoredProcedure, CmdTimeout, InsertparameterArray, Provider);
                    da.InsertCommand.Connection = cn;
                }
                if (!string.IsNullOrEmpty(updateSQL))
                {
                    da.UpdateCommand = ProviderFactory.GetCommand(updateSQL, CommandType.StoredProcedure, CmdTimeout, UpdateparameterArray, Provider);
                    da.UpdateCommand.Connection = cn;
                }
                if (!string.IsNullOrEmpty(deleteSQL))
                {
                    da.DeleteCommand = ProviderFactory.GetCommand(deleteSQL, CommandType.StoredProcedure, CmdTimeout, DeleteparameterArray, Provider);
                    da.DeleteCommand.Connection = cn;
                }
                cn.Open();
            }
            else
            {
                if (!string.IsNullOrEmpty(insertSQL))
                {
                    da.InsertCommand = ProviderFactory.GetCommand(insertSQL, CommandType.StoredProcedure, CmdTimeout, InsertparameterArray, Provider);
                    da.InsertCommand.Connection = _conn;
                    da.InsertCommand.Transaction = _trans;
                }
                if (!string.IsNullOrEmpty(updateSQL))
                {
                    da.UpdateCommand = ProviderFactory.GetCommand(updateSQL, CommandType.StoredProcedure, CmdTimeout, UpdateparameterArray, Provider);
                    da.UpdateCommand.Connection = _conn;
                    da.UpdateCommand.Transaction = _trans;
                }
                if (!string.IsNullOrEmpty(deleteSQL))
                {
                    da.DeleteCommand = ProviderFactory.GetCommand(deleteSQL, CommandType.StoredProcedure, CmdTimeout, DeleteparameterArray, Provider);
                    da.DeleteCommand.Connection = _conn;
                    da.DeleteCommand.Transaction = _trans;
                }
            }
            da.Update(ds);


        }
        catch (Exception ex)
        {
            GenericExceptionHandler(ex);
        }
        finally
        {
            if (!IsInTransaction())
            {
                cn.Close();
                cn.Dispose();
            }
            if (!string.IsNullOrEmpty(insertSQL))
            {
                da.InsertCommand.Parameters.Clear();
                da.InsertCommand.Dispose();
            }
            if (!string.IsNullOrEmpty(updateSQL))
            {
                da.UpdateCommand.Parameters.Clear();
                da.UpdateCommand.Dispose();
            }
            if (!string.IsNullOrEmpty(deleteSQL))
            {
                da.DeleteCommand.Parameters.Clear();
                da.DeleteCommand.Dispose();
            }
            ((IDisposable)da).Dispose();
        }
    }

    #endregion

    // To be used for getting single values. like Average, Sum etc from the DB
    #region "ExecScalar"

    public object ExecScalar(string strSQL, CommandType cmdtype, ParamStruct[] parameterArray)
    {

        IDbConnection conn = null;
        IDbCommand cmd = null;

        try
        {
            PrepareAll(ref cmd, ref conn, strSQL, cmdtype, parameterArray);
            return cmd.ExecuteScalar();

        }
        catch (Exception ex)
        {
            GenericExceptionHandler(ex);
            return -1;
        }
        finally
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            cmd.Dispose();
        }

    }

    public object ExecScalar(string strSQL, CommandType cmdtype)
    {
        return ExecScalar(strSQL, cmdtype, null);
    }


    #endregion

    // This can be used to execute an SP and get an array of output params from it
    #region "Prepared SQL"
    public ArrayList ExecPreparedSQL(string strSQL, CommandType cmdtype, ParamStruct[] parameterArray)
    {

        IDbCommand cmd = null;
        IDbConnection conn = null;
        ArrayList alParams = new ArrayList();
        try
        {
            PrepareAll(ref cmd, ref conn, strSQL, cmdtype, parameterArray);
            cmd.ExecuteNonQuery();
            IDbDataParameter iParam = null;
            foreach (IDbDataParameter iParam_loopVariable in cmd.Parameters)
            {
                iParam = iParam_loopVariable;
                if (iParam.Direction == ParameterDirection.Output | iParam.Direction == ParameterDirection.InputOutput)
                {
                    alParams.Add(iParam.Value);
                }
            }
            return alParams;
        }
        catch (Exception ex)
        {
            GenericExceptionHandler(ex);
            return null;
        }
        finally
        {
            if (!IsInTransaction())
            {
                conn.Close();
                conn.Dispose();
            }
            cmd.Dispose();
        }
    }

    #endregion

    // There should be one hanlder for each supported provider.
    // This is a template and more error handling code should come into place
    #region "Exception handlers"


    private void GenericExceptionHandler(Exception ex)
    {
        if (ex is SqlException)
        {
            SQLExceptionHandler(ex as SqlException);
        }
        else if (ex is OleDbException)
        {
            OLEDBExceptionHandler(ex as OleDbException);
        }
        else if (ex is OdbcException)
        {
            ODBCExceptionHandler(ex as OdbcException);
        }
        else
        {
            throw ex;
        }

    }

    private void SQLExceptionHandler(SqlException ex)
    {
        SqlError sqlerr = null;
        StringBuilder sb = new StringBuilder();
        foreach (SqlError sqlerr_loopVariable in ex.Errors)
        {
            sqlerr = sqlerr_loopVariable;
            sb.AppendFormat("Error: {0}{1}", sqlerr.Message, Environment.NewLine);
            sb.AppendFormat("Server: {0}{1}", sqlerr.Server, Environment.NewLine);
            sb.AppendFormat("Source: {0}{1}", sqlerr.Source, Environment.NewLine);
            sb.Append("-----------------------------------------------");
        }
        //TODO For each custom sql server error have an entry
        throw new Exception(sb.ToString(), ex);
    }

    private void OLEDBExceptionHandler(OleDbException ex)
    {
        OleDbError oledberr = null;
        StringBuilder sb = new StringBuilder();
        foreach (OleDbError oledberr_loopVariable in ex.Errors)
        {
            oledberr = oledberr_loopVariable;
            sb.AppendFormat("Error: {0}{1}", oledberr.Message, Environment.NewLine);
            sb.AppendFormat("Source: {0}{1}", oledberr.Source, Environment.NewLine);
            sb.Append("-----------------------------------------------");
        }
        //TODO For each custom sql server error have an entry
        throw new Exception(sb.ToString(), ex);
    }

    private void ODBCExceptionHandler(OdbcException ex)
    {
        OdbcError odbcerr = null;
        StringBuilder sb = new StringBuilder();
        foreach (OdbcError odbcerr_loopVariable in ex.Errors)
        {
            odbcerr = odbcerr_loopVariable;
            sb.AppendFormat("Error: {0}{1}", odbcerr.Message, Environment.NewLine);
            sb.AppendFormat("Source: {0}{1}", odbcerr.Source, Environment.NewLine);
            sb.Append("-----------------------------------------------");
        }
        //TODO For each custom sql server error have an entry
        throw new Exception(sb.ToString(), ex);
    }

    #endregion



}

}
#endregion
