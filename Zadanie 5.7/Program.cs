using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._7
{
    internal class Program
    {
        //        Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą.Jako wartość funkcja
        //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
        //utworzonej funkcji.

        static int czy_pierwsza(int n)
        {
            if (n < 2)
            {
                return 0;
            }

            for (int i = 2; i <= n/2; i++)
            {
                if (n%i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }    
        static void Main(string[] args)
        {
            Console.WriteLine($"czy pierwsza {czy_pierwsza(12)}");
        }
    }
}
