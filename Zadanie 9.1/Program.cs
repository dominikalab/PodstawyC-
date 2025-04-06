using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Dana jest funkcja kwadratowa f(x) = ax ^ 2 + bx + c.Napisać program wczytujący współczynniki
//funkcji kwadratowej(a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich
//braku.
//Wskazówka: Zbadaj deltę, wyznacz miejsca zerowe.

            int a, b, c;
            double del, x1, x2;

            Console.Write("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj c: ");
            c = Convert.ToInt32(Console.ReadLine());

            del = b * b - 4 * a * c;

            if (del > 0)
            {
                x1 = (-b + Math.Sqrt(del)) / (2 * a);
                x2 = (-b - Math.Sqrt(del)) / (2 * a);
                Console.WriteLine($"Miejsca zerowe to: {x1} i {x2}");
            }
            else if (del == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Miejsce zerowe to: {x1}");
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych");
            }

            Console.ReadKey(true);

        }
    }
}
