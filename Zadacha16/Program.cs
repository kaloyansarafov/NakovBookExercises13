using System;
using System.Text.RegularExpressions;

namespace Zadacha16
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"<a href=""(?<url>[^""]+)"">(?<text>[^<]+)<\/a>");
            string cleanString = regex.Replace(input, ProcessTag);
            Console.WriteLine(cleanString);
        }

        private static string ProcessTag(Match m)
        {
            string url = m.Groups["url"].Value;
            string text = m.Groups["text"].Value;
            return $"[URL={url}]{text}[/URL]";
        }
    }
}
