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

        public string KartaSim //poprawki
        {
            get {return kartaSim;}
            set {kartaSim = value;}
        }

        public int PamiecWewnetrzna //poprawki
        {
            get {return pamiecWewnetrzna;}
        }

        public string Procesor
        {
            get { return procesor; }
        }
        
        //brak wnętrza do kolejnych metod
        public void OdbierzPolaczenie()  
        {
            Console.WriteLine("Odbieram połączenie");
        }

        public void PobierzNumerIMEI()
        {
            Console.WriteLine("Imei: {0}", numerIMEI);
        }

        public void WykonajPolaczenie()
        {
            Console.WriteLine("Dzwonie");
        }

        public void WyslijSMS()
        {
            Console.WriteLine("Wysyłam sms");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Pstryk!");
        }

    }
}
