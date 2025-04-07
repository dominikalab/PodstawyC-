using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Wczytaj liczbę naturalną n> 0 i oblicz n
            //n
            //.Nie można używać funkcji matematycznych.

            int n;

            Console.Write("podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());

            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * n;
            }
            Console.WriteLine($"wynik: {x}");
            Console.ReadKey(true);
        }
    }
}
