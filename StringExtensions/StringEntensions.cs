using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringEntensions
    {
        public static string Capitalize(this String str)
            {
            string first = str[0].ToString().ToUpper();
            return first[0] + str.Substring(1);
            }
        public static string ToCamelCase(this string str)
        {

            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(" ");
            foreach(string part in parts)
            {
                sb.Append(part.ToLower().Capitalize());
            }
            return sb.ToString();
        }

        public static int WordCount(this string s)
        {
          return  s.Split(new char[] { ' ', '.', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
