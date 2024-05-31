// Fig. 8.8: StudentPoll.cs
// Poll analysis application.
using System;

public class StudentPoll
{
   public static void Main( string[] args )
   {
      // array of survey responses
      int[] responses = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6, 
         10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6, 
         4, 8, 6, 8, 10 };
      int[] frequency = new int[ 11 ]; // array of frequency counters

      // for each answer, select responses element and use that value 
      // as frequency index to determine element to increment
      for ( int answer = 0; answer < responses.Length; answer++ )
         ++frequency[ responses[ answer ] ];

      Console.WriteLine( "{0}{1,10}", "Rating", "Frequency" );

      // output each array element's value
      for ( int rating = 1; rating < frequency.Length; rating++ )
         Console.WriteLine( "{0,6}{1,10}", rating, frequency[ rating ] );
   } // end Main
} // end class StudentPoll


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
