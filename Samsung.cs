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

        public bool CzyDualSim
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        public void WlaczWiFi();
        public void ZrobZdjecie();
        public void ZrobZdjecie(string trybKamery);
    }
}
