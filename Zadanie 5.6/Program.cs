using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.

            int n, i=0;
            int[] tab = new int[1000];

            Console.Write("podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());

            while ((n/2 != 0) || ((n/2 ==0) && (n%2 != 0)))
            {
                tab[i++] = n % 2;
                n = n / 2;
            }

            for (int j = i-1; j>=0; j--)
            {
                Console.Write($"{tab[j]}");
            }
            

            Console.ReadKey(true);
        }
    }
}
