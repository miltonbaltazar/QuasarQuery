using System.Data;
using QuasarQuery.Core;
using QuasarQuery.Entity.Enumeradores;
using QuasarQuery.Common;

namespace QuasarQuery.Entity.Interface
{
    public interface IDataAccess
    {
        ValidateResult SetConnect(ref Session pSesion);
        DataTable ExecuteQuery(Session pSession, string pQuery, DataTypeCollection parametros);
        DataTable ExecuteQuery(Session pSession, string pQuery);
        DataBaseObject GetUserObjects(Session pSession);
        DataTable GetSchema(Session pSession, string pTableName);
        string GetScriptText(Session pSession, ETypeScript typeScript, string pTableName);
    
    }
}
