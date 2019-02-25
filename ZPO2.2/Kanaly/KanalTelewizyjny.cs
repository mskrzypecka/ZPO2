using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO2._2.Wiadomosci;

namespace ZPO2._2.Kanaly
{
    public class KanalTelewizyjny
    {
        ObserwowanaWiadomosc wiadomosc;

        public KanalTelewizyjny(ObserwowanaWiadomosc wiadomosc)
        {
            this.wiadomosc = wiadomosc;
            this.wiadomosc.aktualizacjaWiadomosci += Wiadomosc_AktualizacjaWiadomosci;
        }

        private void Wiadomosc_AktualizacjaWiadomosci()
            => wiadomosc.otrzymaneWiadomosci
            .ForEach(x => Console.WriteLine("TV [{0}]: {1}", x.DataUtworzenia, x.Tresc));
    }
}
