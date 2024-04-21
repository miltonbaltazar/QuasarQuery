using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Core
{
    public class DataType
    {
        private string direction;
        private string val;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }
    }
}
