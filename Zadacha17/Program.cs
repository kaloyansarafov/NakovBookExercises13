using System;
using System.Text.RegularExpressions;

namespace Zadacha17
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<day>[0-9]?[0-9])\.(?<month>[0-9]?[0-9])\.(?<year>[0-9]{4})");

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Match m1 = regex.Match(date1);
            int day1 = int.Parse(m1.Groups["day"].Value);
            int month1 = int.Parse(m1.Groups["month"].Value);
            int year1 = int.Parse(m1.Groups["year"].Value);

            Match m2 = regex.Match(date2);
            int day2 = int.Parse(m2.Groups["day"].Value);
            int month2 = int.Parse(m2.Groups["month"].Value);
            int year2 = int.Parse(m2.Groups["year"].Value);

            DateTime firstDate = new DateTime(year1, month1, day1);
            DateTime secondDate = new DateTime(year2, month2, day2);

            TimeSpan diff = secondDate - firstDate;

            Console.WriteLine(diff.Days);
        }
    }
}
