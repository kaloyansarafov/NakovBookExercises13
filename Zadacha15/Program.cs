using System;
using System.Collections.Generic;

namespace Zadacha15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] input = new string[] { "" };
            while (input[0] != "ready")
            {
                input = Console.ReadLine().Split(" - ");
                if (input[0] != "ready")
                {
                dict.Add(input[0], input[1]);
                }
            }
            //above code is responsible for filling the dictionary

            string input2 = Console.ReadLine();
            while (input2 != "done")
            {
                if (dict.ContainsKey(input2))
                {
                    Console.WriteLine(dict.GetValueOrDefault(input2));
                }
                else
                {
                    Console.WriteLine("Definition not found");
                }
                input2 = Console.ReadLine();
            }
            //^^ responsible for searching and printing definitions
        }
    }
}
