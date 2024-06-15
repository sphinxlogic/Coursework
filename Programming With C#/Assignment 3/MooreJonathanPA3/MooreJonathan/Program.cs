using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Decks decks = new Decks();
            decks.Shuffle();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(decks.Deal().turntype.ToString());
                Console.WriteLine(decks.Deal().move);
                Console.WriteLine(decks.Deal().type.ToString());

            }
            Console.ReadLine();
          

        }
    }
}
