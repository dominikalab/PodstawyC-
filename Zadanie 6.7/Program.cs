using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._7
{
    internal class Program
    {
        //        Napisać procedurę(czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
        //parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
        //będący wypełnieniem kwadratu.Procedura ma rysować na ekranie kwadrat o zadanych
        //argumentach. Przetestuj działanie utworzonej procedury.

        static void kwadrat(int a, char znak1, char znak2)
        {
            for (int i = 0; i <= a; i++)
            {
                Console.Write(znak1);
            }
            Console.WriteLine("");

            for (int j = 2; j <= a-1; j++)
            {
                Console.Write(znak1);
                for (int k = 2; k <= a-1; k++)
                {
                    Console.Write(znak2);
                }
                Console.Write(znak1);
                Console.WriteLine("");
            }
            
            for(int l = 0; l <= a; l++)
            {
                Console.Write(znak1);
            }
        }
        static void Main(string[] args)
        {
            kwadrat(5,'+','#');
            Console.ReadKey(true);
        }
    }
}
