using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Wczytaj liczbę naturalną n(n> 1). Narysuj na ekranie z gwiazdek trójkąt prostokątny.Użyj
            //pętli for.

            int n;

            Console.Write("podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i<=n; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadKey(true);
        }
    }
}
