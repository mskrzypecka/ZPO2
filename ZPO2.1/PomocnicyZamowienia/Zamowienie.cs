namespace ZPO2.PomocnicyZamowienia
{
    public class Zamowienie
    {
        public Adres AdresOdbiorcy { get; set; }
        public Adres AdresNadawcy { get; set; }
        public double WartoscTowaru { get; set; }
        public Przewoznik RodzajTransportu { get; set; }

        public Zamowienie(Adres adresOdbiorcy, Adres adresNadawcy, 
                            int wartoscTowaru, Przewoznik rodzajTransportu)
        {
            this.AdresOdbiorcy = adresOdbiorcy;
            this.AdresNadawcy = adresNadawcy;
            this.WartoscTowaru = wartoscTowaru;
            this.RodzajTransportu = rodzajTransportu;
        }
    }

    public enum Przewoznik
    {
        DHL,
        GLS,
        UPC
    }
}