using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuasarQuery.Core;
using QuasarQuery.Common;

namespace QuasarQuery.DataBase
{
    public class MetaDataSQLServer
    {

        #region IMetaDataProvider Members

        private string ConnectString;
        private EnumProviders Provider;

        public MetaDataSQLServer(string pConn, EnumProviders prov)
        {
            ConnectString = pConn;
            Provider = prov;
        }

        public Procedure GetStoreProcedure(string pPackage, string pStoreName)
        {
            DataBaseGetter DAL = new DataBaseGetter();
            DAL.ConnectionString = ConnectString;
            DAL.Provider = Provider;
            DAL.CmdTimeout = 1;

            Procedure procedure = new Procedure();

            //Obtener los parametros de entrada
            string QueryGetParameters = string.Empty;


            ParamStruct[] prm = new ParamStruct[1];

            QueryGetParameters = "SELECT ORDINAL_POSITION, PARAMETER_MODE, IS_RESULT, PARAMETER_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH " +
                                 "FROM information_schema.PARAMETERS " +
                                 "WHERE SPECIFIC_NAME = @STORE_NAME " +
                                 "ORDER BY ORDINAL_POSITION ";

            prm[0].direction = ParameterDirection.Input;
            prm[0].DataType = DbType.String;
            prm[0].ParamName = "STORE_NAME";
            prm[0].value = pStoreName;


            IDataReader iReaderParams = DAL.ExecDataReader(QueryGetParameters, CommandType.Text, prm, CommandBehavior.Default);
            int FieldCount = iReaderParams.FieldCount;


            int INDEX_ORDINAL_POSITION = iReaderParams.GetOrdinal("ORDINAL_POSITION");
            int INDEX_PARAMETER_MODE = iReaderParams.GetOrdinal("PARAMETER_MODE");
            int INDEX_IS_RESULT = iReaderParams.GetOrdinal("IS_RESULT");
            int INDEX_PARAMETER_NAME = iReaderParams.GetOrdinal("PARAMETER_NAME");
            int INDEX_DATA_TYPE = iReaderParams.GetOrdinal("DATA_TYPE");
            int CHARACTER_MAXIMUM_LENGTH = iReaderParams.GetOrdinal("CHARACTER_MAXIMUM_LENGTH");
            object[] values = new object[FieldCount];

            ProcedureParameterCollection StoreParams = new ProcedureParameterCollection();
            while (iReaderParams.Read())
            {
                iReaderParams.GetValues(values);
                ProcedureParameter StoreParam = new ProcedureParameter();

                StoreParam.Ordinal = Convert.ToInt32(values[INDEX_ORDINAL_POSITION]);
                StoreParam.DataType = UtilProvider.SerializerDataType(values[INDEX_DATA_TYPE].ToString(), Provider);
                StoreParam.Length = Convert.ToInt32((DBNull.Value == values[CHARACTER_MAXIMUM_LENGTH])? 0 : values[CHARACTER_MAXIMUM_LENGTH]);
                StoreParam.Name = values[INDEX_PARAMETER_NAME].ToString();
                StoreParam.Direction = values[INDEX_PARAMETER_MODE].ToString();

                StoreParams.Add(StoreParam);
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
