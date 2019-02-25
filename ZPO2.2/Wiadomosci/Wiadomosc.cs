using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2._2.Wiadomosci
{
    public class Wiadomosc
    {
        public DateTime DataUtworzenia { get; set; }
        public string Tresc { get; set; }

        public Wiadomosc(DateTime now, string tresc)
        {
            DataUtworzenia = now;
            Tresc = tresc;
        }
    }
}
