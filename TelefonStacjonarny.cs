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

        public int GetNumer();
        public void OdbierzPolaczenie();
        public void SetNumer(int numer);
        public void WykonajPolaczenie();

        TelefonStacjonarny(string numer)
        {
            this.numer = Convert.ToInt32(numer);
        }

    }
}
