using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Common
{
    public class ValidateResult :  IDisposable
    {
        private string message;
        private string details;
        private eTypeResult status;
        public string Message 
        {
            get
            {
                return string.Concat(message, " " , details).Trim();
            }
        }
     
        public eTypeResult Estado 
        { 
            get
            {
                return status;
            }
        }

        public ValidateResult()
        {
            message = string.Empty;
            status = eTypeResult.Ninguno;
        }

        public ValidateResult(string Msg, eTypeResult aEstado)
        {
            message = Msg;
            status = aEstado;
            details = string.Empty;
        }

        public ValidateResult(string pMessage, string pDetails, eTypeResult aEstado)
        {
            message = pMessage;
            details = pDetails;
            status = aEstado;
        }

        public void Error(string msg)
        {
            message = msg;
            status = eTypeResult.Err;
            details = string.Empty;
        }

        public void Info(string msg)
        {
            message = msg;
            status = eTypeResult.Confirmacion;
            details = string.Empty;
        }

        public void Warning(string msg)
        {
            message = msg;
            status = eTypeResult.Advertencia;
            details = string.Empty;
        }

        public void Question(string msg)
        {
            message = msg;
            status = eTypeResult.Pregunta;
            details = string.Empty;
        }

        public void SetKey()
        { 
        }

        #region "IDisposable Support"
        // To detect redundant calls
        private bool disposedValue;

        // IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    message = string.Empty;
                }
                //this.Dispose();
                // TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                // TODO: set large fields to null.
            }
            this.disposedValue = true;
        }

        // TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        //Protected Overrides Sub Finalize()
        //    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        //    Dispose(False)
        //    MyBase.Finalize()
        //End Sub

        // This code added by Visual Basic to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
