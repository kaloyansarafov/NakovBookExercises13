using System;
using System.Linq;

namespace Zadacha23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            var frequency = from f in input
                            group f by f into wordfrequency
                            orderby wordfrequency.Key
                            select
                            (
                                Word: wordfrequency.Key,
                                Frequency: wordfrequency.Count()
                            );


            foreach (var (Word, Frequency) in frequency)
            {
                Console.WriteLine($"{Word} {Frequency}");
            }
        }
    }
}
