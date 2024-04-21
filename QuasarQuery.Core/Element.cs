using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuasarQuery.Core
{
    public class Element
    {
        private string name = string.Empty;
        private int enumKey;
        private string enumName;
        private string keyValue;
        private string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string EnumName
        {
            get { return enumName; }
            set { enumName = value; }
        }

        public int EnumKey
        {
            get { return enumKey; }
            set { enumKey = value; }
        }

        public string Value
        {
            get { return keyValue; }
            set { keyValue = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
