using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący wczytane
            //liczby w odwrotnej kolejności na ekranie.

            int n;

            Console.Write("podaj długość ciągu <= 1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] liczb = new int[n];

            for (int i = n-1; i >= 0; i--)
            {
                Console.Write($"podaj element nr {n-i}: ");
                liczb[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int el in liczb)
            {
                Console.Write($"{el}, ");
            }

            Console.ReadKey(true);
        }
    }
}
