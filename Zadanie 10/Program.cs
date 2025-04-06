using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.

            double r, pole, obwod;

            Console.WriteLine("Podaj promień koła: ");
            r = Convert.ToDouble(Console.ReadLine());

            pole = 3.14 * r * r;
            obwod = 2 * 3.14 * r;

            Console.WriteLine($"Pole koła wynosi: {pole}");
            Console.WriteLine($"Obwod kola wynosi: {obwod}");

            Console.ReadKey(true);
        }
    }
}
