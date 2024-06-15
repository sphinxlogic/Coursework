// Fig. 10.25: TimeExtensionsTest.cs
// Demonstrating extension methods.
using System;

class TimeExtensionsTest
{
   static void Main( string[] args )
   {
      Time myTime = new Time(); // call Time constructor
      myTime.SetTime( 11, 34, 15 ); // set the time to 11:34:15

      // test the DisplayTime extension method
      Console.Write( "Use the DisplayTime method: " );
      myTime.DisplayTime();

      // test the AddHours extension method
      Console.Write( "Add 5 hours to the Time object: " );
      Time timeAdded = myTime.AddHours( 5 ); // add five hours
      timeAdded.DisplayTime(); // display the new Time object

      // add hours and display the time in one statement
      Console.Write( "Add 15 hours to the Time object: " );
      myTime.AddHours( 15 ).DisplayTime(); // add hours and display time

      // use fully qualified extension method name to display the time
      Console.Write( "Use fully qualified extension method name: " );
      TimeExtensions.DisplayTime( myTime );
   } // end Main
} // end class TimeExtensionsTest

// extension methods class
static class TimeExtensions
{
   // display the Time object in console
   public static void DisplayTime( this Time aTime )
   {
      Console.WriteLine( aTime.ToString() );
   } // end method DisplayTime

   // add the specified number of hours to the time
   // and return a new Time object
   public static Time AddHours( this Time aTime, int hours )
   {
      Time newTime = new Time(); // create a new Time object
      newTime.Minute = aTime.Minute; // set the minutes
      newTime.Second = aTime.Second; // set the seconds

      // add the specified number of hours to the given time
      newTime.Hour = ( aTime.Hour + hours ) % 24;

      return newTime; // return the new Time object
   } // end method AddHours
} // end class TimeExtensions

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