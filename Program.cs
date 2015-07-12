using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово: ");
            string a = Console.ReadLine();
            char[] z = a.ToCharArray();
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(z[i]);
            Console.Write("Введите второе слово: ");
            string b = Console.ReadLine();
            char[] x = b.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            for (int i = 0; i < z.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                    if (z[i] == x[j]) Console.Write("Да ");
                    else Console.Write("Нет ");
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}