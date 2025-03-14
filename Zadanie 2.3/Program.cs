using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący wartość liczby naturalnej n(n >= 0), obliczający wartość 2 ^ n(2 do
            //    potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            //    wartości wyrażenia użyj pętli for.

            int n, j, w;
            Console.WriteLine("podaj liczbę");
            n = Convert.ToInt32(Console.ReadLine());

            w = 2;
            for (j=2; j<=n; j++)
            {
                w = w*2;
            }
            Console.WriteLine($"2 ^ {n} = {w}");

            Console.ReadKey(true);
        }
    }
}
