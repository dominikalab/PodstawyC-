using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._7
{
    internal class Program
    {
        static int suma(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            // Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma.

            Console.WriteLine($"suma 3 + 5 = {suma(3, 5)}");

            Console.ReadKey(true);
        }
    }
}
