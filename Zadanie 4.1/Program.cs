using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.

            int a, b, c, d, e;

            Console.WriteLine("podaj pierwszą liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbę");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj czwartą liczbę");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj piątą liczbę");
            e = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e)) Console.WriteLine($"największa liczba to {a}");
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e)) Console.WriteLine($"największa liczba to {b}");
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e)) Console.WriteLine($"największa liczba to {c}");
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e)) Console.WriteLine($"największa liczba to {d}");
            else Console.WriteLine($"największa liczba to {e}");

            if ((a <= b) && (a <= c) && (a <= d) && (a <= e)) Console.WriteLine($"najmniejsza liczba to {a}");
            else if ((b <= a) && (b <= c) && (b <= d) && (b <= e)) Console.WriteLine($"najmniejsza liczba to {b}");
            else if ((c <= a) && (c <= b) && (c <= d) && (c <= e)) Console.WriteLine($"najmniejsza liczba to {c}");
            else if ((d <= a) && (d <= b) && (d <= c) && (d <= e)) Console.WriteLine($"najmniejsza liczba to {d}");
            else Console.WriteLine($"najmniejsza liczba to {e}");

            Console.ReadKey(true);

        }
    }
}
