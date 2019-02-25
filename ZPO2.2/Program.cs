using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO2._2.Kanaly;
using ZPO2._2.Wiadomosci;

namespace ZPO2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObserwowanaWiadomosc wiadomosc = new ObserwowanaWiadomosc();
            KanalRadiowy kanalRadiowy = new KanalRadiowy(wiadomosc);
            KanalTelewizyjny kanalTelewizyjny = new KanalTelewizyjny(wiadomosc);

            do
            {
                Console.Clear();
                Console.Write("Twoja wiadomosc: ");
                string wpisanaWiadomosc = Console.ReadLine();
                wiadomosc.Dodaj(new Wiadomosc(DateTime.Now, wpisanaWiadomosc));
                Console.WriteLine("Kliknij 'x' aby przerwać.");
            } while (char.ToLower((Console.ReadKey().KeyChar)) != 'x');
            
            Console.ReadKey();
        }
    }
}
