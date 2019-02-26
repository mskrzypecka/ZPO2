using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO2._3
{
    public interface ISamochod
    {
        string Nazwa { get; }
        void Wlacz();
        void Wylacz();
    }
}
