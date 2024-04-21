using System;
using System.Collections.Generic;
using System.Text;

namespace QuasarQuery.Core
{
    public class Column
    {

        public String ColumnName
        {
            get;
            set;
        }

        public DataType DataType
        {
            get;
            set;
        }

        public string Length
        {
            get;
            set;
        }

        public string Scale
        {
            get;
            set;
        }

        public Boolean IsNull
        {
            get;
            set;
        }

        public bool IsPrimary
        {
            get;
            set;
        }

        public bool Comment
        {
            get;
            set;
        }
    }
}
