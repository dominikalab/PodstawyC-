using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący na ekranie
//informację ile liczb jest dodatnich, ujemnych i równych zero.

            int n, dodatnie = 0, ujemne = 0, zero = 0;

            Console.Write("podaj długość ciągu: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] liczby = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"podaj element nr {i + 1}: ");
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int el in liczby)
            {
                if (el > 0)
                    dodatnie++;
                else if (el < 0)
                    ujemne++;
                else
                    zero++;
            }

            Console.WriteLine($"Liczb dodatnich: {dodatnie}");
            Console.WriteLine($"Liczb ujemnych: {ujemne}");
            Console.WriteLine($"Liczb równych zero: {zero}");

            Console.ReadKey(true);

        }
    }
}
