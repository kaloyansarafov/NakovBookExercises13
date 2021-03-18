using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Zadacha10
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternWord = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(". ");
            Console.WriteLine(string.Join(Environment.NewLine, sentences
                .Where(x => Regex.IsMatch(x, @"(\b)" + patternWord + @"(\b)?"))));
        }
    }
}
