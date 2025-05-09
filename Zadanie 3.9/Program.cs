using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._9
{
    //            3.Napisać program posiadający tablicę nazw owoców.Stwórz menu umożliwiające
    //zrealizowanie operacji na tablicy: dodawanie nowych owoców, usuwanie istniejących
    //owoców, modyfikowanie istniejących owoców, wyświetlanie listy owoców.
    //Oprogramuj odpowiednio pozycje menu i sprawdź, czy program poprawnie działa.
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            string[] fruits = new string[N];
            int count = 0;
            int choice, nr, i;

            do
            {
                Console.WriteLine("Menu:\n1-dodaj\n2-usuń\n3-modyfikuj\n4-wypisz\n5-koniec\nTwój wybór: "); 
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (count < N)
                        {
                            Console.Write("Podaj nazwę owocu: ");
                            fruits[count] = Console.ReadLine();
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Lista jest pełna");
                        }
                        break;
                    case 2:
                        Console.Write("Podaj numer owocu do usunięcia od 1 do {0}: ", count);
                        nr = int.Parse(Console.ReadLine());
                        if (nr > 0 && nr <= count)
                        {
                            for (i = nr - 1; i < count - 1; i++)
                            {
                                fruits[i] = fruits[i + 1];
                            }
                            fruits[count - 1] = null;
                            count--;
                        }
                        else
                        {
                            Console.WriteLine("Zły numer");
                        }
                        break;
                    case 3:
                        Console.Write("Podaj numer owocu do modyfikacji od 1 do {0}: ", count);
                        nr = int.Parse(Console.ReadLine());
                        if (nr > 0 && nr <= count)
                        {
                            Console.Write("Podaj nazwę: ");
                            fruits[nr - 1] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Zły numer");
                        }
                        break;
                    case 4:
                        for (i = 0; i < count; i++)
                        {
                            Console.WriteLine("{0}. {1}", i + 1, fruits[i]);
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Zły wybór");
                        break;
                }
            } while (choice != 5);

            Console.ReadKey(true);
        }
    }
}
