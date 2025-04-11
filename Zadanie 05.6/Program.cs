using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n>0 i oblicz 1^1 + 2^2 + ... + n^n. Nie można używać funkcji matematycznych.

            int n, suma = 0;

            Console.Write("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int pot = 1;
                for (int j = 1; j <= i; j++)
                {
                    
                    pot *= i;
                    
                }
                suma += pot;
            }
            Console.WriteLine($"suma = {suma}");
            

            Console.ReadKey(true);
        }
    }
}
