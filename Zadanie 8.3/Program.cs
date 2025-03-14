using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
            //przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.

            int p, k;

            Console.Write("podaj rok początkowy: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj rok końcowy: ");
            k = Convert.ToInt32(Console.ReadLine());

            for (int i = p; i <= k; i++)
            {
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                    Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
    }
}
