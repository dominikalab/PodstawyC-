using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych(dodatnich i ujemnych) i
            //wypisujący wczytane liczby na ekranie.

            int n;
            
            Console.Write("podaj długość ciągu <= 1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] liczb = new int[n];

            for (int i=0; i<n; i++)
            {
                Console.Write($"podaj element nr {i+1}: ");
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
