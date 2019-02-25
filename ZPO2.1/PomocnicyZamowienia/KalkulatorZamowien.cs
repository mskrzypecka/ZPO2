using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO2.Kurierzy;

namespace ZPO2.PomocnicyZamowienia
{
    public class KalkulatorZamowien
    {
        private Zamowienie zamowienie;

        internal double Sumuj(Zamowienie zamowienie)
        {
            IKosztyWysylki kurier = null;

            switch (zamowienie.RodzajTransportu)
            {
                case Przewoznik.DHL:
                    kurier = new DHL();
                    break;
                case Przewoznik.GLS:
                    kurier = new GLS();
                    break;
                case Przewoznik.UPC:
                    kurier = new UPC();
                    break;
            }

            return kurier.obliczKosztPrzesylki(zamowienie);
        }
    }
}
