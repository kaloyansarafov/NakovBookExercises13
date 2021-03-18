using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
