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

            var output = RomanToInt(s);
            Console.WriteLine(output.ToString());
            Console.ReadKey();
        }

        public static int RomanToInt(string s)
        {
            //Make a dictionary storing key value pairs of Roman Numerals
            Dictionary<char, int> romanDict = new Dictionary<char, int>();
            romanDict.Add('I', 1);
            romanDict.Add('V', 5);
            romanDict.Add('X', 10);
            romanDict.Add('L', 50);
            romanDict.Add('C', 100);
            romanDict.Add('D', 500);
            romanDict.Add('M', 1000);
            //convert s to char array
            char[] romanChar = s.ToCharArray();
            int total = 0;
            int j = 0;
            for (int i = 0; i <= romanChar.Length; i++)
            {
                int toAdd = 0;
                if(i == romanChar.Length)
                {
                    break;
                }
                char letter = romanChar[i];
           
                if (i + 1 < romanChar.Length)
                {
                    char nextLetter = romanChar[i + 1];

                    //cover subtraction cases for I
                    if (letter == 'I' && nextLetter == 'V')
                    {
                        toAdd = 4;
                    }
                    else if (letter == 'I' && nextLetter == 'X')
                    {
                        toAdd = 9;
                    }

                    //Cover subtraction cases for X
                    else if (letter == 'X' && nextLetter == 'L')
                    {
                        toAdd = 40;
                    }
                    else if (letter == 'X' && nextLetter == 'C')
                    {
                        toAdd = 90;
                    }

                    //Cover subtraction cases for C
                    else if (letter == 'C' && nextLetter == 'D')
                    {
                        toAdd = 500;
                    }
                    else if (letter == 'C' && nextLetter == 'M')
                    {
                        toAdd = 900;
                    }
                    else
                    {
                        total += romanDict[letter];
                        continue;
                    }
                    total += toAdd;
                    i += 1;
                    continue;
                }

                total += romanDict[letter];
            }
            return total;
        }
    }
}