using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8_6
{
    class Mobile : IMobile
    {
        private string kartaSim;
        private string numerIMEI;
        private int pamiecWewnetrzna;
        private string procesor;

        public string KartaSim
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int PamiecWewnetrzna
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public string Procesor
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void Odbierz();
        public void PobierzNumer();
        public void WykonajPolaczenie();
        public void WyslijSMS();
        public void ZrobZdjecie();

    }
}
