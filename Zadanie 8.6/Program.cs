using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb naturalnych i wypisujący na ekranie
            //wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
            //pętli foreach.

            int n;
            Console.Write("podaj długość ciągu <= 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"podaj element nr {i + 1}: ");
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(liczby);
            Console.Write("parzyste liczby w kolejności niemalejącej: ");
            foreach (int el in liczby)
            {
                if (el % 2 == 0)
                {
                    Console.Write($"{el} ");
                }
            }
            Console.ReadKey(true);
        }
    }
}
