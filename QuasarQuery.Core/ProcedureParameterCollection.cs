using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuasarQuery.Core
{
    [Serializable, XmlInclude(typeof(ProcedureParameter))]
    public class ProcedureParameterCollection : List<ProcedureParameter>
    {
        public ProcedureParameterCollection()
        { }
    }
}
