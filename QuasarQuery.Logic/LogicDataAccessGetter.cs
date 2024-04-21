using System;
using QuasarQuery.Core;
using QuasarQuery.DataBase;
using System.Data;
using QuasarQuery.Common;
using QuasarQuery.Entity;

namespace QuasarQuery.Logic
{
    public class LogicDataAccessGetter
    {
        private DataBaseGetter bd;

        public string CodeStoreProcedureFromTable(string TableName, string pConnectString, EnumProviders pProvider)
        {
            bd = new DataBaseGetter();
            bd.ConnectionString = pConnectString;
            bd.Provider = pProvider;
            bd.CmdTimeout = 1;
            String executeSQL = string.Empty;
            String ColumnsString = string.Empty;
            String ResultString = string.Empty;
            executeSQL = "select * from " + TableName;

            IDataReader iReader = bd.ExecDataReader(executeSQL, CommandType.Text, CommandBehavior.SchemaOnly);
            DataTable dt = iReader.GetSchemaTable();
            foreach (DataRow drow in dt.Rows)
            {
                ColumnsString = ColumnsString + "ordinal = reader.GetOrdinal(" + '\u0022' + drow["ColumnName"].ToString() + '\u0022' + ");" + '\n';
            }
            ResultString = ColumnsString;
            return ResultString;
        }

        public Procedure MetaDataFromStoreProcedure(string pPackague, string pCommandText, string pConnectString, EnumProviders pProvider, string pUser)
        {
            bd = new DataBaseGetter();

            switch (pProvider)
            {
                case EnumProviders.SQLServer:
                    MetaDataSQLServer providerSQLServer = new MetaDataSQLServer(pConnectString, pProvider);
                    return providerSQLServer.GetStoreProcedure(string.Empty, pCommandText);
                case EnumProviders.Oracle:
                    MetaDataOracle providerOracle = new MetaDataOracle(pConnectString, pProvider);
                    return providerOracle.GetStoreProcedure(pPackague, pCommandText, pUser);
                default:
                    return null;
            }
        }

        public ValidateResult TestConnect(EnumProviders provEnum, Session pSession)
        {
            try
            {
                IDbConnection Connect = ProviderFactory.GetConnection(provEnum);
                Connect.ConnectionString = pSession.ConnectionString;
                Connect.Open();
                return new ValidateResult("Conexión establecida", eTypeResult.Confirmacion);
            }
            catch (Exception ex)
            {
                return new ValidateResult("Error al realizar la conexión", ex.Message, eTypeResult.Err);
            }
        }

    }
}
