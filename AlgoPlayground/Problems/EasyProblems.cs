using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPlayground.Problems
{
    public static class EasyProblems
    {
        public static int RomanToInt(string s)
        {
            //Make a dictionary storing key value pairs of Roman Numerals
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
