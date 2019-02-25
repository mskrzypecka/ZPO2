using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO2.PomocnicyZamowienia;

namespace ZPO2
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorZamowien kalkulator;
            List<Zamowienie> zamowienia = new List<Zamowienie>();

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                500,
                Przewoznik.DHL
                ));

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                1500,
                Przewoznik.DHL
                ));

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                500,
                Przewoznik.GLS
                ));

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                1500,
                Przewoznik.GLS
                ));

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                500,
                Przewoznik.UPC
                ));

            zamowienia.Add(new Zamowienie(
                new Adres("Kowalski", "Sezamkowa", "Nibylandia", "12-345"),
                new Adres("Nowak", "Marcepanowa", "Nibylandia", "12-543"),
                1500,
                Przewoznik.UPC
                ));

            foreach (var zamowienie in zamowienia)
            {
                kalkulator = new KalkulatorZamowien();
                Console.WriteLine("Zamowienie o wartosci {0}zl u kieriera {1} kosztuje {2}zl.",
                                    zamowienie.WartoscTowaru, zamowienie.RodzajTransportu, kalkulator.Sumuj(zamowienie));
            };

            Console.ReadKey();
        }
    }
}
