using System;
using System.Text.RegularExpressions;

namespace PravetsCSDev
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, I'm [from] Pravets, I'm a C# [developer].";
            Regex regex = new Regex(@"\[(?<tag>[^]]+)\]");
            string cleanString = regex.Replace(text, ProcessTag);
            Console.WriteLine(cleanString);
        }
        private static string ProcessTag(Match m)
        {
            string content = m.Groups["tag"].Value;
            return content.ToUpper();
        }
    }
}
