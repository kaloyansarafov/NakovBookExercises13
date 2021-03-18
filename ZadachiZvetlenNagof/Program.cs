using System;
using System.Text;

namespace ZadachiZvetlenNagof
{
    static class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
                sb.Append(input[i]);
            
            Console.WriteLine(sb);
        }
    }
}
