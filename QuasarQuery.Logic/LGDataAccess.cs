using System;
using System.Collections.Generic;
using System.Text;
using QuasarQuery.Entity.Interface;
using QuasarQuery.DataBase;
using QuasarQuery.Core;
using QuasarQuery.Common;
using System.Data;
using QuasarQuery.Entity;

namespace QuasarQuery.Logic
{
    public class LGDataAccess: IDataAccess
    {
        private IDataAccess db;
      
        #region Miembros de IDataAcces

        public ValidateResult SetConnect(ref Session pSession)
        {
            
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.SetConnect(ref pSession);
        }

        public System.Data.DataTable ExecuteQuery(Session pSession, string pQuery, DataTypeCollection parametros)
        {
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.ExecuteQuery(pSession, pQuery, parametros);
        }

        public QuasarQuery.Core.DataBaseObject GetUserObjects(Session pSession)
        {
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.GetUserObjects(pSession);
        }

        public System.Data.DataTable GetSchema(Session pSession, string pTableName)
        {
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.GetSchema(pSession, pTableName);
        }

        public string GetScriptText(Session pSession, Entity.Enumeradores.ETypeScript typeScript, string pTableName)
        {
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.GetScriptText(pSession, typeScript, pTableName);
        }


        #endregion

        #region IDataAccess Members


        public System.Data.DataTable ExecuteQuery(Session pSession, string pQuery)
        {
            if (pSession.Provider == EnumProviders.SQLServer)
                db = new SqlServerDataAccess();
            else if (pSession.Provider == EnumProviders.Oracle)
                db = new OracleDataAccess();

            return db.ExecuteQuery(pSession, pQuery);
        }

        #endregion

        #region IDataAccess Members




        #endregion
         
    }
}
