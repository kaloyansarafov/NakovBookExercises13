using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '(')
                    count++;
                else if (charArr[i] == ')')
                    count--;
            }
            if (count == 0)
                Console.WriteLine("Syntax is correct");
            else
                Console.WriteLine("Syntax is incorrect");
        }
    }
}
