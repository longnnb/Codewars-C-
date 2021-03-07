using System;
using System.Collections.Generic;
using Solution;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO-DO: use xUnit to create test cases
            Console.WriteLine("=== SOLUTION TEST ===");

            Console.WriteLine("== GetIntegersFromList ==");
            var list = new List<object>() { 1, 2, "a", "b" };
            Console.WriteLine(String.Join(' ', ListFilterer.GetIntegersFromList(list)));

            Console.WriteLine("== ToJadenCase ==");
            Console.WriteLine("How can mirrors be real if our eyes aren't real".ToJadenCase());

            Console.ReadLine();
        }
    }
}
