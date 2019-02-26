using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZPO2._3.Samochody;

namespace ZPO2._3
{
    public class Fabryka
    {
        public List<ISamochod> Samochody { get; set; }

        public Fabryka()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            Samochody = new List<ISamochod>();

            foreach (var type in types)
                if (type.GetInterface(typeof(ISamochod).ToString()) != null)
                    Samochody.Add(Activator.CreateInstance(type) as ISamochod);
        }

        public ISamochod UtworzNowySamochod(TypSamochodu typ)
        {
            ISamochod samochod = null;
            switch (typ)
            {
                case TypSamochodu.Fabia:
                    samochod = new Fabia();
                    break;
                case TypSamochodu.Punto:
                    samochod = new Punto();
                    break;
                case TypSamochodu.Yaris:
                    samochod = new Yaris();
                    break;
            }
            return samochod;
        }
    }
}
