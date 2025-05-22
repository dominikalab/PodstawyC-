using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący na ekranie
            //najmniejszą i największą wczytaną liczbę.

            int n;

            Console.Write("podaj długość ciągu <= 1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] liczby = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"podaj element nr {i + 1}: ");
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = liczby.Min();
            int max = liczby.Max();

            Console.WriteLine($"Najmniejsza liczba to: {min}");
            Console.WriteLine($"Największa liczba to: {max}");

            Console.ReadKey(true);
        }
    }
}
