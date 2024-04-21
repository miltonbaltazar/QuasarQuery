using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QuasarQuery.Core
{
     
    [Serializable()]
    public class ProcedureResultColumn
    {
        private string name;
        private int ordinal;
        private string dataType;
        private int length;

        [XmlAttribute("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [XmlAttribute("Ordinal")]
        public int Ordinal
        {
            get { return ordinal; }
            set { ordinal = value; }
        }

        [XmlAttribute("DataType")]
        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        [XmlAttribute("Length")]
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
