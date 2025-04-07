using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący kwotę w złotych, a następnie przeliczający ją na taką walutę jaką
            //wybierze użytkownik: funty, dolary, euro.Użyj instrukcji switch.

            double x;
            int y;
            Console.Write("podaj kwotę: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. funty");
            Console.WriteLine("2. dolary");
            Console.WriteLine("3. euro");
            Console.WriteLine("Na którą walutę:");
            y = Convert.ToInt32(Console.ReadLine());

            switch (y)
            {
                case 1:
                    Console.WriteLine($"po przeliczeniu {x * 2}");
                    break;
                case 2:
                    Console.WriteLine($"po przeliczeniu {x * 3}");
                    break;
                case 3:
                    Console.WriteLine($"po przeliczeniu {x * 4}");
                    break;
                default:
                    Console.WriteLine("nie ma takiej opcji");
                    break;
            }

            Console.ReadKey(true);

        }
        }
}
