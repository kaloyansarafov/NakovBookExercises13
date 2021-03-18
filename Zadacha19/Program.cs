using System;
using System.Text.RegularExpressions;

namespace Zadacha19
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([\w\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)");

            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}
