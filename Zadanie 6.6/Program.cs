using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach.
            string[] dni = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

            foreach (string el in dni)
            {
                Console.Write($"{el}, ");
            }

            Console.ReadKey(true);
        }
    }
}
