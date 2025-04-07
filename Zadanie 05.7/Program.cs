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

            for (int i = 1; i<= n; i++)
            {
                if (n % i == 0) ;
            }
        }
    }
}
