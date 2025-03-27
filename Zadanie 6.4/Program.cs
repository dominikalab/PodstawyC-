using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero)


            int x;
            double a, b, wynik;

            do
            {
                Console.WriteLine("1 - pole prostokąta");
                Console.WriteLine("2 - pole kwadratu");
                Console.WriteLine("3 - pole trójkąta");
                Console.WriteLine("0 - koniec");
                Console.WriteLine("twój wybór: ");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = a * b;
                        Console.WriteLine($"pole wynosi: {wynik}");
                        break;
                    case 2:
                        Console.Write("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        wynik = a * a;
                        Console.WriteLine($"pole wynosi: {wynik}");
                        break;
                    case 3:
                        Console.Write("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("podaj h: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        wynik = a * b / 2;
                        Console.WriteLine($"pole wynosi: {wynik}");
                        break;
                    default:
                        Console.WriteLine("zły wybór");
                        break;
                }
            } while (x != 0);
            

        }
    }
}
