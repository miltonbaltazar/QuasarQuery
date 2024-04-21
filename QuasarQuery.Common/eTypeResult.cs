using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Common
{
    /// <summary>
    /// Establece si la coneccion se produjo correctamente o con errores
    /// </summary>
    /// <remarks></remarks>
    public enum eTypeResult : int
    {
        Ninguno,
        Confirmacion,
        Err,
        Pregunta,
        Advertencia
    }
}
