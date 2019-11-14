using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);   //tutaj wstawiamy nawiasach <> jakiego typu chcemy utworzyć kolejkę kołową

            //var kolejkaInt = new KolejkaKolowa<int>(); //w nawiasach () mamy konstruktor domyślny 
            //var kolejkaString = new KolejkaKolowa<string>(1000);

            //var kolejkaOsob = new KolejkaKolowa<Osoba>();
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Marcin", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Tomek", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Jacek", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Marcin", Nazwisko = "Nowak" });


            //while (!kolejkaOsob.JestPusty)
            //{
            //    var wynik = kolejkaOsob.Czytaj().Imie;     //czytaj dopóki kolejkaOsób jest pełna
            //    Console.WriteLine(wynik);
            //}


            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);

            Console.ReadKey();
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            var suma = 0.0;

            Console.WriteLine("W naszej kolejce jest:");

            while (!kolejka.JestPusty)
            {
                //Console.WriteLine("\t\t" + kolejka.Czytaj());   //  \t\t tabulatory

                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true) //pętla nieskończona
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))  //liczba która zostanie wprowadzona przez użytkownika zostaje sparsowana do zmiennej wartosc
                {
                    kolejka.Zapisz(wartosc);
                    continue; //wykonać kolejną iterację dla pętli nieskończonej
                }
                break;    //wyjście z pętli w przypadku gdy użytkownik wciśnie enter lub jakiś ciąg znaów 

            }
        }
    }

    //public class Osoba
    //{
    //    public string Imie { get; set; }

    //    public string Nazwisko { get; set; }
    //}
}
