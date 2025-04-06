using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy
            //da się z tych odcinków zbudować trójkąt, czy też nie.
            //Wskazówka: Z trzech odcinków można zbudować trójkąt, jeżeli suma długości dowolnych
            //dwóch odcinków jest większa od długości trzeciego odcinka.

            int a, b, c;

            Console.Write("Podaj długość pierwszego odcinka: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość drugiego odcinka: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość trzeciego odcinka: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }
    }
}
