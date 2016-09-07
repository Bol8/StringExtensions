using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Método que limpia,si existe, el prefijo indicado
        /// </summary>
        /// <param name="source"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string ClearPrefix(this string source, string prefix)
        {
            return source.StartsWith(prefix) ? source.Substring(prefix.Length) : source;
        }

        /// <summary>
        /// Método que concatena una cadena a la derecha del string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stringToJoin"></param>
        /// <returns></returns>
        public static string JoinUpLast(this string source, string stringToJoin)
        {
            var newString = new StringBuilder(source);
            newString.Append(stringToJoin);

            return newString.ToString();
        }

        /// <summary>
        /// Método que concatena una cadena a la izquierda del string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stringToJoin"></param>
        /// <returns></returns>
        public static string JoinUpStart(this string source, string stringToJoin)
        {
            var newString = new StringBuilder(stringToJoin);
            newString.Append(source);

            return newString.ToString();
        }



    }
}
