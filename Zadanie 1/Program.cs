using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.

            int a;

            Console.WriteLine("podaj liczbę");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine($"liczba {a} jest parzysta");
                
            else
                Console.WriteLine($"liczba {a} jest nieparzysta");

            Console.ReadKey(true);

        }
    }
}
