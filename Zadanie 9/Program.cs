using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów
            //wczytanych liczb.

            int a, b, suma;
            
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe: ");
            b = Convert.ToInt32(Console.ReadLine());

            suma = (a * a) + (b * b);

            Console.WriteLine($"Suma wynosi: {suma}");

            Console.ReadKey(true);

        }
    }
}
