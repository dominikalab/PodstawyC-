using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.

            double a;
            double b;

            Console.WriteLine("bok a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("bok b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("pole = {0}", a * b);
            Console.WriteLine("obwód = {0}", 2 * a + 2 * b);

            Console.ReadKey(true);

        }
    }
}
