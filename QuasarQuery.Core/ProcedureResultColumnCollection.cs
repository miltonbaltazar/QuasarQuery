using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QuasarQuery.Core
{
    [Serializable, XmlInclude(typeof(ProcedureResultColumn))]
    public class ProcedureResultColumnCollection: List<ProcedureResultColumn>
    {
        public ProcedureResultColumnCollection()
        { }
    }
}
