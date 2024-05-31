﻿// Fig. 7.9: Craps.cs
// Craps class simulates the dice game craps.
using System;

public class Craps
{
   // create random number generator for use in method RollDice
   private Random randomNumbers = new Random();

   // enumeration with constants that represent the game status
   private enum Status { CONTINUE, WON, LOST }

   // enumeration with constants that represent common rolls of the dice
   private enum DiceNames
   {
      SNAKE_EYES = 2,
      TREY = 3,
      SEVEN = 7,
      YO_LEVEN = 11,
      BOX_CARS = 12
   }

   // plays one game of craps
   public void Play()
   {
      // gameStatus can contain CONTINUE, WON or LOST
      Status gameStatus = Status.CONTINUE;
      int myPoint = 0; // point if no win or loss on first roll

      int sumOfDice = RollDice(); // first roll of the dice

      // determine game status and point based on first roll 
      switch ( ( DiceNames ) sumOfDice )
      {
         case DiceNames.SEVEN: // win with 7 on first roll
         case DiceNames.YO_LEVEN: // win with 11 on first roll           
            gameStatus = Status.WON;
            break;
         case DiceNames.SNAKE_EYES: // lose with 2 on first roll
         case DiceNames.TREY: // lose with 3 on first roll
         case DiceNames.BOX_CARS: // lose with 12 on first roll
            gameStatus = Status.LOST;
            break;
         default: // did not win or lose, so remember point         
            gameStatus = Status.CONTINUE; // game is not over
            myPoint = sumOfDice; // remember the point
            Console.WriteLine( "Point is {0}", myPoint );
            break;
      } // end switch 

      // while game is not complete
      while ( gameStatus == Status.CONTINUE ) // game not WON or LOST
      {
         sumOfDice = RollDice(); // roll dice again

         // determine game status
         if ( sumOfDice == myPoint ) // win by making point
            gameStatus = Status.WON;
         else
            // lose by rolling 7 before point
            if ( sumOfDice == ( int ) DiceNames.SEVEN )
               gameStatus = Status.LOST;
      } // end while 

      // display won or lost message
      if ( gameStatus == Status.WON )
         Console.WriteLine( "Player wins" );
      else
         Console.WriteLine( "Player loses" );
   } // end method Play

   // roll dice, calculate sum and display results
   public int RollDice()
   {
      // pick random die values
      int die1 = randomNumbers.Next( 1, 7 ); // first die roll
      int die2 = randomNumbers.Next( 1, 7 ); // second die roll

      int sum = die1 + die2; // sum of die values

      // display results of this roll
      Console.WriteLine( "Player rolled {0} + {1} = {2}",
         die1, die2, sum );
      return sum; // return sum of dice
   } // end method RollDice
} // end class Craps


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
