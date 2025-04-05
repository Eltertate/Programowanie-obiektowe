using System;

namespace zadanie
{
    internal class Program
    {
        internal class Samochod
        {
            internal string Marka { get; set; }
            internal int Cena { get; set; }

            public void setSamochod()
            {
                Console.WriteLine("Podaj markę samochodu:");
                Marka = Console.ReadLine();

                Console.WriteLine("Podaj cenę samochodu:");
                Cena = Convert.ToInt32(Console.ReadLine());
            }

            public void setSilnik(Silnik silnik1)
            {
                Console.WriteLine("Podaj rodzaj silnika:");
                silnik1.Rodzaj = Console.ReadLine();

                Console.WriteLine("Podaj pojemność silnika w litrach:");
                silnik1.Pojemnosc = Convert.ToInt32(Console.ReadLine());
            }

            public void Wyswietl(Silnik silnik1)
            {
                Console.WriteLine("\n\n\n\tINFORMACJA TECHNICZNA\n");
                Console.WriteLine("\tMarka: " + Marka + "\n" + "\tCena: " + Cena + "zł");
                Console.WriteLine("\tSilnik: " + silnik1.Rodzaj + "\n" + "\tPojemność: " + silnik1.Pojemnosc + "l");
            }
        }

        internal class Silnik
        {
            internal string Rodzaj { get; set; }
            internal int Pojemnosc { get; set; }
        }

        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            Silnik silnik = new Silnik();

            samochod.setSamochod();

            samochod.setSilnik(silnik);

            samochod.Wyswietl(silnik);
        }
    }
}
