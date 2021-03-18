using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    static class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> coll = new Dictionary<string, string>();

            while (input != "end")
            {
                string reversedIn = Reverse(input);
                coll.Add(input, reversedIn);
                input = Console.ReadLine();
            }

            foreach (var item in coll)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        static string Reverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
