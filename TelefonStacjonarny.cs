using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8_6
{
    class TelefonStacjonarny : IStacjonarny
    {
        private int numer;

        //znów brak wnętrz
        public int GetNumer()
        {
            return numer;
        }

        public void OdbierzPolaczenie()
        {
            Console.WriteLine("odbieram polaczenie");
        }

        public void SetNumer(int numer)
        {
            this.numer = numer;
        }

        public void WykonajPolaczenie()
        {
            Console.WriteLine("Dzwonie....");
        }

        public TelefonStacjonarny(string numer) //<= brak modyfikator dostepu
        {
            this.numer = Convert.ToInt32(numer);
        }

    }
}
