using System;
using System.Text.RegularExpressions;

namespace Zadacha21
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^((.)(?<1>)\2|.?)$"))
            {
                Console.WriteLine(Regex.Match(input, @"^((.)(?<1>)\2|.?)$").Value);
            }
        }
    }
}
