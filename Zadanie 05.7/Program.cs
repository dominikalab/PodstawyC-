using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n > 1 i wypisz wszystkie liczby pierwsze z przedziału[1, n].

            int n;
            Console.Write("podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());

            int x = 0;

            for (int i = 2; i<= n; i++)
            {
                for (int j = 2; j<i; j++)
                {
                    if (i%j == 0)
                    {
                        x += 1;
                    }

                }
                if (x == 0)
                {
                    Console.Write($"{i}, ");
                }
                x = 0;
            }

            Console.ReadKey(true);
        }
    }
}
