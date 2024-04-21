using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using QuasarQuery.Common;
using QuasarQuery.Core;

namespace QuasarQuery.DataBase
{
    public class MetaDataOracle  
    {

        #region IMetaDataProvider Members

        private string ConnectString;
        private EnumProviders Provider;

        public MetaDataOracle(string pConn, EnumProviders prov)
        {
            ConnectString = pConn;
            Provider = prov;
        }

        public Procedure GetStoreProcedure(string pPacketeName, string pStoreName, string pUser)
        {
            DataBaseGetter DAL = new DataBaseGetter();
            DAL.ConnectionString = ConnectString;
            DAL.Provider = Provider;
            DAL.CmdTimeout = 1;

             Procedure procedure = new Procedure();

            //Obtener los parametros de entrada
            string QueryGetParameters = string.Empty;


            ParamStruct[] prm = new ParamStruct[3];

            QueryGetParameters = "SELECT OWNER, OBJECT_ID, ARGUMENT_NAME, POSITION , DATA_TYPE, IN_OUT, DATA_LENGTH, DATA_PRECISION, PLS_TYPE " +
                                 "FROM SYS.ALL_ARGUMENTS " +
                                 "WHERE OWNER = :OWNER AND NVL(PACKAGE_NAME,'N') = :PACKAGE_NAME AND OBJECT_NAME = :OBJECT_NAME " +
                                 "ORDER BY POSITION ";

            prm[0].direction = ParameterDirection.Input;
            prm[0].DataType = DbType.String;
            prm[0].ParamName = "OWNER";
            prm[0].value = pUser.ToUpper();

            prm[1].direction = ParameterDirection.Input;
            prm[1].DataType = DbType.String;
            prm[1].ParamName = "PACKAGE_NAME";
            prm[1].value = string.IsNullOrEmpty(pPacketeName)? "N" : pPacketeName;

            prm[2].direction = ParameterDirection.Input;
            prm[2].DataType = DbType.String;
            prm[2].ParamName = "OBJECT_NAME";
            prm[2].value = string.IsNullOrEmpty(pStoreName)? "" : pStoreName.ToUpper();


            IDataReader iReaderParams = DAL.ExecDataReader(QueryGetParameters, CommandType.Text, prm, CommandBehavior.Default);
            int FieldCount = iReaderParams.FieldCount;


            int INDEX_ORDINAL_POSITION = iReaderParams.GetOrdinal("POSITION");
            int INDEX_PARAMETER_MODE = iReaderParams.GetOrdinal("IN_OUT");
            int INDEX_PARAMETER_NAME = iReaderParams.GetOrdinal("ARGUMENT_NAME");
            int INDEX_DATA_TYPE = iReaderParams.GetOrdinal("DATA_TYPE");
            int CHARACTER_MAXIMUM_LENGTH = iReaderParams.GetOrdinal("DATA_LENGTH");
            int CHARACTER_PRESICION = iReaderParams.GetOrdinal("DATA_PRECISION");

            object[] values = new object[FieldCount];

            ProcedureParameterCollection StoreParams = new ProcedureParameterCollection();
            while (iReaderParams.Read())
            {
                iReaderParams.GetValues(values);
                if (!string.IsNullOrEmpty(values[INDEX_PARAMETER_NAME].ToString()))
                {
                    ProcedureParameter StoreParam = new ProcedureParameter();

                    StoreParam.Ordinal = Convert.ToInt32(values[INDEX_ORDINAL_POSITION]);
                    StoreParam.DataType = UtilProvider.SerializerDataType(values[INDEX_DATA_TYPE].ToString(), Provider);
                    StoreParam.Length = Convert.ToInt32((DBNull.Value == values[CHARACTER_MAXIMUM_LENGTH])? 0 : values[CHARACTER_MAXIMUM_LENGTH]);
                    StoreParam.Presicion = Convert.ToInt32((DBNull.Value == values[CHARACTER_PRESICION]) ? 0 : values[CHARACTER_PRESICION]);
                    StoreParam.Name = values[INDEX_PARAMETER_NAME].ToString();
                    StoreParam.Direction = values[INDEX_PARAMETER_MODE].ToString();

                    StoreParams.Add(StoreParam);
                }
            }

            iReaderParams.Close();
            procedure.Parameters = StoreParams;



            prm = new ParamStruct[StoreParams.Count];
            for (int ItemIndex = 0; ItemIndex <= prm.Length -1; ItemIndex++)
            {
                prm[ItemIndex].DataType = UtilProvider.ConvertDataType(procedure.Parameters[ItemIndex].DataType);
                prm[ItemIndex].direction = UtilProvider.ConvertDirection(procedure.Parameters[ItemIndex].Direction);
                prm[ItemIndex].ParamName = procedure.Parameters[ItemIndex].Name;
                prm[ItemIndex].value = DBNull.Value;
            }
            pStoreName = pPacketeName + "." + pStoreName;
             IDataReader iReader = DAL.ExecDataReader(pStoreName, CommandType.StoredProcedure, prm, CommandBehavior.SchemaOnly);
             DataTable dt = iReader.GetSchemaTable();
             FieldCount = iReader.FieldCount;
            
             ProcedureResultColumn resultcol = null;
             ProcedureResultColumnCollection resultCollection = new ProcedureResultColumnCollection();
             foreach (DataRow drow in dt.Rows)
             {
                 resultcol = new ProcedureResultColumn();
                 resultcol.Name = drow["ColumnName"].ToString();
                 resultcol.DataType = UtilProvider.SerializerDataType(drow["DataTypeName"].ToString(), Provider);
                 resultCollection.Add(resultcol);
             }
             procedure.ResultColumns = resultCollection; 
            
            return procedure;
        }

        #endregion
    }
}
