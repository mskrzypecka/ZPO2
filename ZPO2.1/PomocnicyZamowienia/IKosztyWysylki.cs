using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2.PomocnicyZamowienia
{
    interface IKosztyWysylki
    {
        double obliczKosztPrzesylki(Zamowienie zamowienie);
    }
}
