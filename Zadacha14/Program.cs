using System;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string endResult = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                endResult += input[i] + " ";
            }
            Console.WriteLine(endResult);
        }
    }
}
