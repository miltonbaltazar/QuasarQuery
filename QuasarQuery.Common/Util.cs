using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace QuasarQuery.Common
{
    public class Util
    {

        public static string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }

        public static string GenerateScriptOracle(string[] array)
        {
            throw new NotImplementedException();
        }

    }
}
