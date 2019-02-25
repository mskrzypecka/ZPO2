namespace ZPO2.PomocnicyZamowienia
{
    public class Adres
    {
        public Adres(string nazwaKontaktu, string ulica, string miasto, string kodPocztowy)
        {
            this.NazwaKontaktu = nazwaKontaktu;
            this.Ulica = ulica;
            this.Miasto = miasto;
            this.KodPocztowy = kodPocztowy;
        }

        public string NazwaKontaktu { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
    }
}