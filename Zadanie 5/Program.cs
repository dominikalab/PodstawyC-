using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.

            double r, h, V, l, Pc;

            Console.WriteLine("podaj r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj h");
            h = Convert.ToDouble(Console.ReadLine());

            V = 1.0 / 3 * Math.PI * r * r * h;
            l = Math.Sqrt(r * r + h * h);
            Pc = Math.PI * r * r + Math.PI * r * l;

            Console.WriteLine("objętość {0}", V);
            Console.WriteLine("pole {0}", Pc);

            Console.ReadKey(true);
        }
    }
}
