using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący na ekranie
            //sumę kwadratów wczytanych liczb.

            int n;

            Console.Write("podaj długość ciągu: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] liczby = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"podaj element nr {i + 1}: ");
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0;
            foreach (int el in liczby)
            {
                suma += el * el;
            }
            Console.WriteLine($"suma kwadratów liczb wynosi: {suma}");
            Console.ReadKey(true);
        }
    }
}
