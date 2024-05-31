//The Intramural Class which has a constructor an override of the ToString Method
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Intramural:Organizations 
    {
        string sport;
       
        public Intramural()
        {
            name = "KillerBees";
            contactperson = "John Doe";
            funding = 100.00M;
            sport = "Flagfootball";
        }

        public override string ToString()
        {
            return string.Format("Intramural:{0}\nContact Person:{1}\nFunding:{2}\nSport:{3}",name,contactperson,funding,sport);
        }

    }
}
