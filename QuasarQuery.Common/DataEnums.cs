using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuasarQuery.Common
{
    public enum EnumProviders
    {
        [XmlEnum("")]
        None = 0,
        [XmlEnum("ODBC")]
        ODBC = 1,
        [XmlEnum("SQL Server")]
        SQLServer = 2,
        [XmlEnum("OLEDB")]
        OLEDB = 3,
        [XmlEnum("Oracle")]
        Oracle = 4
    }
}
