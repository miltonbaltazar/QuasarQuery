using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace OraDeveloperNet.DataBase
{
    public class GenerationCode
    {
        private static DataAccess DAL = new DataAccess();

        public static string CodeStoreProcedureFromTable(String TableName)
        {
            DAL.ConnectionString = ApplicationFow.CurrentConect.ConnectionStirng;
            DAL.Provider = ApplicationFow.CurrentConect.Provider;
            DAL.CmdTimeout = 1;
            String executeSQL = string.Empty;
            String ColumnsString = string.Empty;
            String ResultString = string.Empty;
            executeSQL = "select * from " + TableName;

            IDataReader iReader = DAL.ExecDataReader(executeSQL, System.Data.CommandType.Text, CommandBehavior.SchemaOnly);
            DataTable dt = iReader.GetSchemaTable();
            foreach (DataRow drow in dt.Rows)
            {
                ColumnsString = ColumnsString + "ordinal = reader.GetOrdinal(" + '\u0022' + drow["ColumnName"].ToString() +'\u0022' + ");" +  '\n';
            }
            ResultString = ColumnsString;
            return ResultString;
        }

        public static StoreProcedure MetaDataFromStoreProcedure(string pPackague, string pCommandText)
        {

            switch (ApplicationFow.CurrentConect.Provider)
            { 
                case EnumProviders.SQLServer:
                    MetaDataSQLServer providerSQLServer = new MetaDataSQLServer();
                    return providerSQLServer.GetStoreProcedure(string.Empty, pCommandText); 
                  case EnumProviders.Oracle:
                    MetaDataOracle providerOracle = new MetaDataOracle();
                    return providerOracle.GetStoreProcedure(pPackague, pCommandText); 
                default:
                    return null;
            }
        }


    }
}
