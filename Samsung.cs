using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8_6
{
    class Samsung : Mobile
    {
        private bool czyDualSim;

        public bool CzyDualSim //poprawki
        {
            get { return czyDualSim; }
            set { czyDualSim = value; }
        }
        
        //znów brak wnętrza do metod
        public void WlaczWiFi()
        {
            Console.WriteLine("Wifi on");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Wykonano zdjęcie");
        }

        public void ZrobZdjecie(string trybKamery)
        {
            Console.WriteLine("Wykonano zdjęcie, tryb: {0}", trybKamery);
        }
    }
}
