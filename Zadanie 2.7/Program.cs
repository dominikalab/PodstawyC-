using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zadanie_2._7
{
    internal class Program
    {
//        Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
//zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max

        static int max(int x, int y)
        {
            if (x > y) return x;
            else return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"wieksza z liczb 4, 8 to {max(4,8)}");
            Console.ReadKey(true);
        }
    }
}
