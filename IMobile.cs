﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cw8_6
{
    interface IMobile : ITelefon
    {
        string KartaSim
        {
            get;
            set;
        }

        int PamiecWewnetrzna
        {
            get;
            set;
        }

        void WyslijSMS();
        void ZrobZdjecie();
    }
}