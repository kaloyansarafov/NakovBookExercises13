using System;

namespace Zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in banWord)
                text = text.Replace(item, new string('*', item.Length));
            Console.WriteLine(text);
        }
    }
}
