using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.

            int a, b, c;

            Console.WriteLine("podaj pierwszą liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbę");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c)) Console.WriteLine($"największa liczba to {a}");
            else if ((b >= a) && (b >= c)) Console.WriteLine($"największa liczba to {b}");
            else Console.WriteLine($"największa liczba to {c}");

            if ((a <= b) && (a <= c)) Console.WriteLine($"najmniejsza liczba to {a}");
            else if ((b <= a) && (b <= c)) Console.WriteLine($"najmniejsza liczba to {b}");
            else Console.WriteLine($"najmniejsza liczba to {c}");

            Console.ReadKey(true);
        }
    }
}
