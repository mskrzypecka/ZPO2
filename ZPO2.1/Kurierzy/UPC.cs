﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO2.PomocnicyZamowienia;

namespace ZPO2.Kurierzy
{
    class UPC : IKosztyWysylki
    {
        public double obliczKosztPrzesylki(Zamowienie zamowienie)
            => zamowienie.WartoscTowaru > 1000 ? 70 : 20;
    }
}
