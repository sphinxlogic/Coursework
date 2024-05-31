// Fig. 10.24: ObjectInitializerTest.cs
// Demonstrate object initializers using class Time.
using System;

class ObjectInitializerTest
{
   static void Main( string[] args )
   {
      Console.WriteLine( "Time object created with object initializer" );

      // create a Time object and initialize its properties
      Time aTime = new Time { Hour = 14, Minute = 145, Second = 12 };

      // display the time in both standard and universal format
      Console.WriteLine( "Standard time: {0}", aTime.ToString() );
      Console.WriteLine( "Universal time: {0}\n",
         aTime.ToUniversalString() );

      Console.WriteLine( "Time object created with Minute property set" );

      // create a Time object and initialize its Minute property only
      Time anotherTime = new Time { Minute = 45 };

      // display the time in both standard and universal format
      Console.WriteLine( "Standard time: {0}", anotherTime.ToString() );
      Console.WriteLine( "Universal time: {0}",
         anotherTime.ToUniversalString() );
   } // end Main
} // end class ObjectInitializerTest

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