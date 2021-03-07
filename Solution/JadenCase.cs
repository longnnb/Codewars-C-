using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Solution
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            //Linq
            //return string.Join(' ', phrase.Split().Select(word => Char.ToUpper(word[0]) + word.Substring(1)));

            //Globalization
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}
