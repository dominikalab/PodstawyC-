using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn iiloraz.
            double a, b;

            Console.WriteLine("podaj pierwszą liczbę");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("suma {0} i {1} wynosi {2}", a, b, a + b);
            Console.WriteLine("różnica {0} i {1} wynosi {2}", a, b, a - b);
            Console.WriteLine("iloczyn {0} i {1} wynosi {2}", a, b, a * b);
            Console.WriteLine("iloraz {0} i {1} wynosi {2}", a, b, a / b);

            Console.ReadKey(true);

        }
    }
}
