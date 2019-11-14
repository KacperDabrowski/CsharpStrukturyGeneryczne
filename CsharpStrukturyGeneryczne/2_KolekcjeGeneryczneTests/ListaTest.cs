using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            ListaLiczb.Add(4);

            Assert.AreEqual(4, ListaLiczb[3]);
        }

        [TestMethod]
        public void ListaMozemyDodacNaPozycji()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            ListaLiczb.Insert(1, 8);  //wstawienie elementu na określoną pozycję listy

            Assert.AreEqual(8, ListaLiczb[1]);
        }

        [TestMethod]
        public void ListaMozemuUsuwacElement()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };
            ListaLiczb.Remove(2); //usuwany element drugi z listy

            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 3 }));  //sprawdzenie nowej sekwencji liczb w liście
        }

        [TestMethod]
        public void ListaMozemuUsuwacElementNaPozycji()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };
            ListaLiczb.RemoveAt(2);

            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 2 }));  //sprawdzenie nowej sekwencji liczb w liście
        }

        [TestMethod]
        public void ListaMozemuWyszukiwacIndexElementu()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            Assert.AreEqual(ListaLiczb.IndexOf(3), 2);
            
        }

        [TestMethod]
        public void ListaMozemuWyszukiwacCzyZawiera()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            Assert.IsTrue(ListaLiczb.Contains(3));

        }

        [TestMethod]
        public void ListaMozemyDodawacNaKoniecZakresLiczb()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            var zakres = new List<int> { 4, 5, 6, 7  };
            ListaLiczb.AddRange(zakres);   //trzeba dodać nową utworzoną listę

            Assert.AreEqual(7, ListaLiczb[6]);
        }

    }
}
