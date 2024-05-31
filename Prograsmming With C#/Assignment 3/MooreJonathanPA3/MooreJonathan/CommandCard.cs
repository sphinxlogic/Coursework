//Defintion of the Command Card Class
//Creates Card Types

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class CommandCard
    {
        public string turntype;
        public int move;
        public string type;


        public CommandCard(string cardttype, int cardmove, string cardtype)
        {
            turntype = cardttype;
            move = cardmove;
            type = cardtype;
        }

    }
}
