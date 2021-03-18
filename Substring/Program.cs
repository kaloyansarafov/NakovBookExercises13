using System;
using System.Text.RegularExpressions;

namespace Substring
{
    static class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();

            Console.WriteLine(Replace(input, pattern));
        }

        static string Replace(string text, string pattern)
        {
            string finalresult = text;
            while (finalresult.Contains(pattern))
            {
                finalresult = Regex.Replace(finalresult, pattern, String.Empty);
            }
            return finalresult;
        }
    }
}