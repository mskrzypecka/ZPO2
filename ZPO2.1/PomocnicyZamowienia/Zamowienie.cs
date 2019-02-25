namespace ZPO2.PomocnicyZamowienia
{
    public class Zamowienie
    {
        public Adres AdresOdbiorcy { get; set; }
        public Adres AdresNadawcy { get; set; }
        public double WartoscTowaru { get; set; }
        public Przewoznik RodzajTransportu { get; set; }

    }

    public enum Przewoznik
    {
        DHL,
        GLS,
        UPC
    }
}