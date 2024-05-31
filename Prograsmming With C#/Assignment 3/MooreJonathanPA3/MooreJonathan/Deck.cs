//Definition of the Decks Class
//Creates an Array of Commad Card objects
//Has a Shuffle and Deal method
//The Construtor has 7 for loops.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Decks
    {
        private CommandCard[] deck;

        private int currentCard = 0;
        private const int NUMBER_OF_CARDS = 84;
        private Random Randomnumbers;

             

        public Decks()
        {
            deck = new CommandCard[NUMBER_OF_CARDS];
            
            Randomnumbers = new Random();
            //u-turn card
            for (int count = 0; count < 6; count++)
            {
                deck[count] = new CommandCard("uturn", 0, "turn"); 
            }
            //right card
            for (int count2 = 0; count2 < 18; count2++)
            {
                deck[count2] = new CommandCard("right", 0, "turn");
            }
            //left card
            for (int count3 = 0; count3 < 18; count3++)
            {
                deck[count3] = new CommandCard("left", 0, "turn");
            }
            //move 6 card
            for (int count4 = 0; count4 < 6; count4++)
            {
                deck[count4] = new CommandCard("Zero", 3, "move");
            }
            //move 12 card
            for (int count5 = 0; count5 < 12; count5++)
            {
                deck[count5] = new CommandCard("Zero", 2, "move");
            }
            //move 18 card
            for (int count6 = 0; count6 < 18; count6++)
            {
                deck[count6] = new CommandCard("Zero", 1, "move");
            }
            // move 6 card
            for (int count7 = 0; count7 < 6; count7++)
            {
                deck[count7] = new CommandCard("Zero", -1, "move");
            }
                      
        }

       public void Shuffle()
        {
            CommandCard temp;
            for (int first = 0; first < 17; first++)
            {
                
                int second = Randomnumbers.Next(17);

                temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }


        public CommandCard Deal()
        {
            if (currentCard < 18)
            {
                return deck[currentCard++];
            }

            else
                //return null;
                return new CommandCard("Default", 0, "turn");

        }

    }
}
