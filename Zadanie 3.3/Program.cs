using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący liczbę całkowitą n(n> 2) i wypisujący na ekranie wartość sumy
            //1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.

            int n, i, w=0;

            Console.WriteLine("podaj liczbę");
            n = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=n; i++)
            {
                w += i;
            }
            Console.WriteLine(w);
            Console.ReadKey(true);
        }
    }
}
