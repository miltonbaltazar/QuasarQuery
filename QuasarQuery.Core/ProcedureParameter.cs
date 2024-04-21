using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QuasarQuery.Core
{
    [Serializable()]
    public class ProcedureParameter
    {
        private string name;
        private int ordinal;
        private string dataType;
        private int length;
        private string propertyValue;
        private string direction;
        private int presicion;

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

        [XmlAttribute("Presicion")]
        public int Presicion
        {
            get { return presicion; }
            set { presicion = value; }
        }

        [XmlAttribute("Direction")]
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        [XmlAttribute("PropertyValue")]
        public string PropertyValue
        {
            get { return propertyValue; }
            set { propertyValue = value; }
        }
    }
}
