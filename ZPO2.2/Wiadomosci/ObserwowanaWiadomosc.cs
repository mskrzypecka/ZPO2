using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2._2.Wiadomosci
{
    public class ObserwowanaWiadomosc
    {
        public List<Wiadomosc> otrzymaneWiadomosci { get; set; }
        public event AktualizacjaWiadomosci aktualizacjaWiadomosci;
        public delegate void AktualizacjaWiadomosci();

        public ObserwowanaWiadomosc() => otrzymaneWiadomosci = new List<Wiadomosc>();

        public void Dodaj(Wiadomosc wiadomosc)
        {
            otrzymaneWiadomosci.Add(wiadomosc);
            aktualizacjaWiadomosci();
        }
    }
}
