using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboRampage
{
    class Card
    {
        string type { get; set; }
        int speed { get; set; }
        string turnType { get; set; }

       
        public Card(string Stype, int Sspeed, string SturnType)
        {
            type = Stype;
            if (Stype == "turn")
                speed = 0;
            else
                speed = Sspeed;
            if (Stype == "move")
                turnType = "null";
            else
                turnType = SturnType;
        }

        
        public override string ToString()
        {
            return "Type: " + type + " Speed: " + speed + " Turn Type: " + turnType;
        }
    }
}
