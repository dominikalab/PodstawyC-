using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący współrzędne punktu P = (x, y) i wypisujący na ekranie informację,
            //do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/ lub osi OY.

            int x, y;

            Console.Write("podaj x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x<0 && y < 0)
            {
                Console.WriteLine("cwiartka III");
            }
            else if (x<0 && y > 0)
            {
                Console.WriteLine("cwiartka II");
            }
            else if (x>0 && y > 0)
            {
                Console.WriteLine("cwiartka I");
            }
            else
            {
                Console.WriteLine("cwiartka IV");
            }
            Console.ReadKey(true);
        }
    }
}
