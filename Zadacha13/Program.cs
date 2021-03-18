using System;
using System.Text.RegularExpressions;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<protocol>[^:]+):\/\/(?<server>[^\/]+)\/(?<resource>[^:]+)");
            Match m = regex.Match(input);
            string protocol = m.Groups["protocol"].Value;
            string server = m.Groups["server"].Value;
            string resource = m.Groups["resource"].Value;

            Console.WriteLine("[protocol]=" + protocol + "\n" + "[server]=" + server + "\n" + "[resource]=" + resource);
        }
    }
}
