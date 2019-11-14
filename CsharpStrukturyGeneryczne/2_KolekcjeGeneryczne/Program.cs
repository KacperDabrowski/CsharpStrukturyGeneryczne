using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Pracownik[] pracownicy = new Pracownik[] //tablica pracowników, jak w nawiasie podamy liczbę np 3-elementowa 
            //List<Pracownik> pracownicy = new List<Pracownik>
            //{           
            //    new Pracownik { Imie = "Marcin", Nazwisko = "Nowak"},       //Inicjalizacja tablicy 3 pracowników
            //    new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
            //    new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
            //};

            //pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "Kos" });

            //foreach (var pracownik in pracownicy)
            //{
            //    Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            //}

            //for (int i = 0; i < pracownicy.Count; i++)
            //{
            //    Console.WriteLine(pracownicy[i].Imie + " "+ pracownicy[i].Nazwisko); //odwoływanie się do indeksu w tablicy pracownicy
            //}

            ////Array.Resize(ref pracownicy, 10);  //dodanie nowych elementów do tablicy poprzez odwołanie referencyjne
            ////pracownicy[9] = new Pracownik { Imie = "Anatol", Nazwisko = "Koszyk" };
            ///

            //var liczby = new List<int>();
            //var pojemnosc = -1;


            //while (true)
            //{
            //    if (liczby.Capacity != pojemnosc)
            //    {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine(pojemnosc);
            //    }

            //    liczby.Add(1);
            //}

            Queue<Pracownik> kolejka = new Queue<Pracownik>(); // utworzenie kolejki

            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" }); //dodawanie pracownika przy pomocy metody Enqueue
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Zając" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });


            while (kolejka.Count > 0) //dopóki ktoś jest w kolejce
            {
               var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.ReadKey();
        }
    }
}
