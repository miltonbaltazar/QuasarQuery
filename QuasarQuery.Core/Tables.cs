using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Core
{
    public class Table
    {
        private string tableName;
        private ColumnsCollection columns;
        public string TABLENAME
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }

        public ColumnsCollection Columns
        {
            get { return columns; }
            set { columns = value;}
        }
    }
}
