using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDefEditor
{
    public static class Serialization
    {
        /// <summary>
        /// Validate a string for defs by replacing line feed and carrier return characters with an empty space.
        /// </summary>
        /// <param name="str">The string to validate.</param>
        /// <returns>The validated string.</returns>
        public static string ValidateString(string str)
        {
            if (str == null || str.Length == 0)
                return str;

            str = str.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");
            return str;
        }
    }
}
