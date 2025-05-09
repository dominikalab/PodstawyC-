using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._9
{
    struct Uczen
    {
        public string imie;
        public string nazwisko;
        public byte[] oceny;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
            //Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
            //umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
            //Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.

            Uczen[] uczniowie;
            int ilu_uczniow, ile_ocen, i, j;
            Console.Write("Podaj liczbę uczniów: ");
            ilu_uczniow = int.Parse(Console.ReadLine());
            uczniowie = new Uczen[ilu_uczniow];

            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podaj imię ucznia: ");
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia: ");
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.Write("Podaj liczbę ocen: ");
                ile_ocen = int.Parse(Console.ReadLine());
                uczniowie[i].oceny = new byte[ile_ocen];
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocenę {0}: ", j + 1);
                    uczniowie[i].oceny[j] = byte.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nLista uczniów:");
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write($"{i + 1}. {uczniowie[i].imie} {uczniowie[i].nazwisko}");
                Console.Write(", Oceny: ");
                foreach(byte ocena in uczniowie[i].oceny)
                {
                    Console.Write($"{ocena}, ");
                }
                Console.WriteLine("");
            }

        }
    }
}
