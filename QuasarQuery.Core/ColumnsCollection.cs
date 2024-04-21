using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Core
{
    public class ColumnsCollection : List<Column>
    {
        public Table Table
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
