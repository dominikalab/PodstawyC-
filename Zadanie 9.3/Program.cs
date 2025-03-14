using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wypisz tabliczkę mnożenia do 100 w formie tabelki:
            int w;
            for (int i =1; i<=10; i++)
            {
                for (int j = 1; j<=10; j++)
                {
                    w = i * j;
                    Console.Write($"{w} ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
