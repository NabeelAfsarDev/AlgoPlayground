using AlgoPlayground.Problems;
using System;
using System.Collections.Generic;
namespace AlgoPlayground
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Roman string:");
            string s = Console.ReadLine();
            var output = EasyProblems.RomanToInt(s);
            Console.WriteLine(output.ToString());
            Console.ReadKey();
        }
    
    }
}