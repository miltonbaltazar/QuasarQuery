using System;
using System.Collections.Generic;
using System.Text;
using QuasarQuery.Common;

namespace QuasarQuery.Core
{
    public class DataBaseObject
    {
        private string name = string.Empty;
        private string connectionstring = string.Empty;
        private EnumProviders enumKey;
        private string enumName;
        private TablesCollection tables;
        private ProcedureCollection procedures;
        private FunctionCollection functions;
        private string schema;

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

        public string ConnectionString
        {
            get { return connectionstring; }
            set { connectionstring = value; }
        }

        public EnumProviders EnumKey
        {
            get { return enumKey; }
            set { enumKey = value; }
        }

        public string Schema
        {
            get
            {
                return schema;
            }
            set
            {
                schema = value;
            }
        }

        public TablesCollection Tables
        {
            get
            {
                return tables;
            }
            set
            {
                tables = value;
            }
 
        }

        public ProcedureCollection Procedures
        {
            get { return procedures; }
            set { procedures = value; }
        }

        public FunctionCollection Functions
        {
            get { return functions; }
            set { functions = value; }
        }


    }
}
