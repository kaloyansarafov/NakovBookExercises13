using System;
using System.Text.RegularExpressions;

namespace Zadacha20
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<day>[0-9]?[0-9])\.(?<month>[0-9]?[0-9])\.(?<year>[0-9]{4})");

            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}
