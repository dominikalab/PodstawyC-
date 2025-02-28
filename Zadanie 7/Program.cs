using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
            //uwzględnieniem części całkowitej i reszty z dzielenia.

            int a, b, iloraz, reszta;

            Console.WriteLine("podaj pierwszą liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            b = Convert.ToInt32(Console.ReadLine());

            iloraz = a / b;
            reszta = a % b;

            Console.WriteLine("iloraz {0} i {1} równa się {2} z resztą {3}", a, b, iloraz, reszta);
            Console.WriteLine($"{a} / {b} = {iloraz} r {reszta}");

            Console.ReadKey(true);

        }
    }
}
