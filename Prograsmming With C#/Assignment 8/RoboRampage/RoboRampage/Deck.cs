using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboRampage
{
    class Deck
    {
        private Card[] deck;
        private int CurrentCard;
        private Random randomNum;

        
        public Deck()
        {
            string[] type = { "move", "turn" };
            int[] speed = { -1, 1, 2, 3 };
            string[] turnType = { "left", "right", "u-turn" };

            
            deck = new Card[84];
            CurrentCard = 0;
            randomNum = new Random();

            
            int count;


            
            for (count = 0; count < deck.Length; count++)
            {
                
                int speedCount;
                int turnCount;

                
                if (count < 6)
                    speedCount = 0;
                else if (count >= 6 && count < 24)
                    speedCount = 1;
                else if (count >= 24 && count < 36)
                    speedCount = 2;
                else
                    speedCount = 3;

                
                if (count >= 42 && count < 60)
                    turnCount = 0;
                else if (count >= 60 && count < 78)
                    turnCount = 1;
                else
                    turnCount = 2;

                
                deck[count] = new Card(type[count / 42], speed[speedCount], turnType[turnCount]);
            }
        }

        
        public void Shuffle()
        {
            CurrentCard = 0;
            int count;
            for (count = 0; count < deck.Length; count++)
            {
                int next = randomNum.Next(84);

                Card temp = deck[count];
                deck[count] = deck[next];
                deck[next] = temp;
            }
        }

        
        public Card DealCard()
        {
            return deck[CurrentCard++];
        }
    }
}
