using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Core
{
    public class Function
    {
        private string name;

        public string FUNCTIONNAME
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
    }
}
