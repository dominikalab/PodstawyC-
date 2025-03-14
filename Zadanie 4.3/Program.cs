using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for.

            int n, k;

            Console.Write("podaj liczbę wierszy:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj liczbę kolumn:");
            k = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i<=n; i++)
            {
                for (int j=1; j<=k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadKey(true);
        }
    }
}
