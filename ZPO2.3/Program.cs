using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabryka fabryka = new Fabryka();

            foreach (var samochod in fabryka.Samochody)
                Console.WriteLine("Samochod typ: " + samochod.Nazwa);

            Console.WriteLine("Samochod nowy: " + fabryka.UtworzNowySamochod(TypSamochodu.Fabia).Nazwa);
            Console.WriteLine("Samochod nowy: " + fabryka.UtworzNowySamochod(TypSamochodu.Punto).Nazwa);
            Console.WriteLine("Samochod nowy: " + fabryka.UtworzNowySamochod(TypSamochodu.Yaris).Nazwa);

            Console.ReadKey();
        }
    }

    public enum TypSamochodu
    {
        Fabia,
        Punto,
        Yaris
    }
}
