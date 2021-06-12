using System;
using System.Collections.Generic;
using Main.CodeWars;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO-DO: use xUnit to create test cases
            //Console.WriteLine("=== SOLUTION TEST ===");

            //Console.WriteLine("== GetIntegersFromList ==");
            //var list = new List<object>() { 1, 2, "a", "b" };
            //Console.WriteLine(String.Join(' ', ListFilterer.GetIntegersFromList(list)));

            //Console.WriteLine("== ToJadenCase ==");
            //Console.WriteLine("How can mirrors be real if our eyes aren't real".ToJadenCase());

            //var result = Kata.Divisors(15);
            //result = Kata.Divisors(16);
            //result = Kata.Divisors(253);
            //result = Kata.Divisors(24);

            //var a = "xyaabbbccccdefww";
            //var b = "xxxxyyyyabklmopq";
            //Console.WriteLine(Kata.Longest(a, b));

            Console.WriteLine(Kata.FindMissingLetter(new char[] { 'e', 'f', 'h' }));
            Console.ReadLine();
        }
    }
}
