using System;
using System.Text.RegularExpressions;

namespace Zadacha18
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<day>[0-9]?[0-9])\.(?<month>[0-9]?[0-9])\.(?<year>[0-9]{4}) (?<hour>[0-2]?[0-9]):(?<minutes>[0-5]?[0-9]):(?<seconds>[0-5]?[0-9])");

            string date1 = Console.ReadLine();

            Match m1 = regex.Match(date1);
            int day1 = int.Parse(m1.Groups["day"].Value);
            int month1 = int.Parse(m1.Groups["month"].Value);
            int year1 = int.Parse(m1.Groups["year"].Value);
            int minutes = int.Parse(m1.Groups["minutes"].Value);
            int seconds = int.Parse(m1.Groups["seconds"].Value);
            int hour = int.Parse(m1.Groups["hour"].Value);

            DateTime firstDate = new DateTime(year1, month1, day1, hour, minutes, seconds);
            DateTime final = firstDate.AddHours(6.5);
            Console.WriteLine(final.ToString());
        }
    }
}
