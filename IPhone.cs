using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8_6
{
    class IPhone : Mobile
    {
        //brak wnętrz
        public void TouchID()
        {
            Console.WriteLine("Weryfikacja poprawna");
        }

        public void WyslijSMS()
        {
            Console.WriteLine("wysłano sms");
        }
    }
}
