using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._7
{
    internal class Program
    {
        //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
        //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
        static int ile_cyfr(int n)
        {
            int ile = 0;

            while (n / 10 > 0)
            {
                n/=10;
                ile++;
            }
            return ile+1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"liczba 27748393 ma {ile_cyfr(27748393)} cyfr");
            Console.ReadKey(true);
        }
    }
}
