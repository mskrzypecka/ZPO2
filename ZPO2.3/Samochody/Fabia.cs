﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2._3.Samochody
{
    public class Fabia : ISamochod
    {
        public string Nazwa => "Fabia";

        public void Wlacz() => Console.WriteLine("Wlacz: " + Nazwa);

        public void Wylacz() => Console.WriteLine("Wylacz: " + Nazwa);
    }
}
