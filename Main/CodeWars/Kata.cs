using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.CodeWars
{
    class Kata
    {
        public static int[] Divisors(int n)
        {
            //prime
            if (n <= 3) return null;
            var result = Enumerable.Range(2, n - 3).Where(d => n % d == 0).ToArray();
            return result.Length == 0 ? null : result;

            // check the alogorithm
            //var div = Enumerable.Range(2, (int)Math.Sqrt(n))
            //    .Where(x => n % x == 0 && x < n)
            //    .SelectMany(x => new[] { x, n / x })
            //    .OrderBy(x => x)
            //    .Distinct().ToArray();

            //return div.Any() ? div : null;
        }

        public static int DuplicateCount(string str)
        {
            // my solution
            //var result = 0;
            //var lowerStr = str.ToLower();
            //foreach (var c in lowerStr.Distinct())
            //{
            //    result += lowerStr.Count(x => x == c) > 1 ? 1 : 0;
            //}
            //return result;

            //concise
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
            //or
            //return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }

        public static string AddBinary(int a, int b)
        {
            //my solution
            //var c = a + b;
            //var result = new StringBuilder();
            //while (c > 0)
            //{
            //    result.Insert(0, c % 2);
            //    c /= 2;
            //}
            //return result.ToString();

            //consice
            return Convert.ToString(a + b, 2);

        }
    }
}
