using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TypyGeneryczne
{
    public class KolejkaKolowa<T>     //klasa generyczna po wstawieniu <T>
    {
        private T[] bufor; //tablica
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5) //konstruktor domyślny, wywołany gdy nie podamy liczby
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1]; //utworzenie nowej tablicy
            poczatekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;    //określenie długości bufora
            koniecBufora = (koniecBufora + 1) % bufor.Length;  //przesuwanie indeksu w prawo o jeden

            if (koniecBufora == poczatekBufora)
            {
                poczatekBufora = (poczatekBufora + 1) % bufor.Length; //aby nie wyjść po za wielkość bufora
            }
        }

        public T Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get             //właściwość która zwraca pojemność bufora
            {
                return bufor.Length;
            }
        }

        public bool JestPusty   //właściwość która zwraca informacje czy bufor jest pusty
        {
            get
            {
                return koniecBufora == poczatekBufora;  //jeżeli tak jest pusty
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }
    }


}
