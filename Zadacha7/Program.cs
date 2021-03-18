using System;
using System.Text;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(20);
            sb.Append(input);

            if (input.Length < 20)
            {
                sb.Append(new string('*', 20 - input.Length));
            }
            Console.WriteLine(sb);
        }
    }
}
