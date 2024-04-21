using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QuasarQuery.Core
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot(ElementName = "StoreProcedure")]
    public class Procedure
    {
        private string procedureName;
        public string PROCEDURENAME
        {
            get
            {
                return procedureName;
            }
            set
            {
                procedureName = value;
            }
        }

        private ProcedureParameterCollection parameters;
        private ProcedureResultColumnCollection resultColumns;

        [XmlArray("Parameters")]
        [XmlArrayItem("Parameter", typeof(ProcedureParameter))]
        public ProcedureParameterCollection Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

        [XmlArray("ResultColumns")]
        [XmlArrayItem("ResultColumn", typeof(ProcedureResultColumn))]
        public ProcedureResultColumnCollection ResultColumns
        {
            get { return resultColumns; }
            set { resultColumns = value; }
        }
    }
}
