using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;


namespace QuasarQuery.Common
{

    public class UtilProvider
    {
        public static EnumProviders Provider {get;set;}

        public static DbType ConvertDataType(string pDataType)
        {
            pDataType = pDataType.ToLower();


            if (Provider == EnumProviders.SQLServer)
            {
                switch (pDataType)
                {
                    case "varchar":
                    case "varchar2":
                    case "nvarchar":
                        return DbType.String;
                    case "int":
                    case "integer":
                        return DbType.Int32;
                    default:
                        return DbType.String;
                }
            }
            else if (Provider == EnumProviders.Oracle)
            {
                switch (pDataType)
                {
                    case "oracledbtype.char":
                        return DbType.String;
                    case "oracledbtype.varchar2":
                        return DbType.String;// DbType.String;
                    case "oracledbtype.int32":
                        return DbType.Int32;
                    case "oracledbtype.refcursor":
                        return DbType.Object;
                    case "oracledbtype.array":
                        return DbType.Object;
                    default:
                        return DbType.String;
                }
            }
            else
            {
                return DbType.String;
            }

        }

        public static string SerializerDataType(string pDataType, EnumProviders Provider)
        {
            string returntype = string.Empty;

            if (Provider == EnumProviders.SQLServer)
            {
                switch (pDataType)
                {
                    case "nchar":
                    case "char":
                        returntype = "SqlDbType.Char";
                        break;
                    case "varchar":
                    case "varchar2":
                    case "nvarchar":
                        returntype = "SqlDbType.VarChar";
                        break;
                    case "int":
                    case "integer":
                        returntype = "SqlDbType.Int";
                        break;
                    case "datetime":
                        returntype = "SqlDbType.DateTime";
                        break;
                    default:
                        returntype = string.Empty;
                        break;
                }
            }
            else if (Provider == EnumProviders.Oracle)
            {
                pDataType = pDataType.ToLower();
                switch (pDataType)
                {
                    case "nchar":
                    case "char":
                        returntype = "OracleDbType.Char";
                        break;
                    case "varchar2":
                        returntype = "OracleDbType.Varchar2";
                        break;
                    case "number":
                    case "integer":
                        returntype = "OracleDbType.Int32";
                        break;
                    case "ref cursor":
                        returntype = "OracleDbType.RefCursor";
                        break;
                    case "table":
                        returntype = "OracleDbType.Array";
                        break;
                    default:
                        returntype = string.Empty;
                        break;
                }
            }
            return returntype;
        }

        public static ParameterDirection ConvertDirection(string pDirection)
        {
            pDirection = pDirection.ToLower();

            switch (pDirection)
            {
                case "in":
                    return ParameterDirection.Input;
                case "inout":
                    return ParameterDirection.InputOutput;
                case "out":
                    return ParameterDirection.Output;
                default:
                    return ParameterDirection.Input;
            }
        }

        public string XslTypeReader(string xmlType, string xmlProvider)
        {
            if (xmlProvider == "SQLServer")
            {
                if (xmlType == "SqlDbType.DateTime") return "(!reader.IsDBNull(ordinal)) ? reader.GetDateTime(ordinal) : DateTime.MinValue;";
                if (xmlType == "SqlDbType.VarChar") return "(!reader.IsDBNull(ordinal)) ? reader.GetString(ordinal) : string.Empty;";
                if (xmlType == "SqlDbType.Char") return "(!reader.IsDBNull(ordinal)) ? reader.GetString(ordinal) : string.Empty;";
                if (xmlType == "SqlDbType.Int") return "(!reader.IsDBNull(ordinal)) ? reader.GetInt32(ordinal) : 0;";
                if (xmlType == "SqlDbType.Decimal") return "(!reader.IsDBNull(ordinal)) ? reader.GetDecimal(ordinal) : 0;";
                return "none";
            }
            else if (xmlProvider == "Oracle")
            {
                return "none";
            }
            else
            {
                return "none";
            }

        }
    }
}
