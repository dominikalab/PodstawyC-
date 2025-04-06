using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dany jest ciąg arytmetyczny a(n) = 3n - 1.Napisać program wczytujący numer wyrazu ciągu(n) i
            //wypisujący na ekranie jego wartość.

            int n, a;

            Console.WriteLine("Podaj numer wyrazu ciągu:");
            n = Convert.ToInt32(Console.ReadLine());

            a = 3 * n - 1;

            Console.WriteLine($"Wartość {n} wyrazu ciągu wynosi: {a}");

            Console.ReadKey(true);
        }
    }
}
