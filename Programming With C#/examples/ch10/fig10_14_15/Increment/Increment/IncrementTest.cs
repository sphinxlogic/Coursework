// Fig. 10.15: IncrementTest.cs
// readonly instance variable initialized with a constructor argument.
using System;

public class IncrementTest
{
   public static void Main( string[] args )
   {
      Increment incrementer = new Increment( 5 );

      Console.WriteLine( "Before incrementing: {0}\n", incrementer );

      for ( int i = 1; i <= 3; i++ )
      {
         incrementer.AddIncrementToTotal();
         Console.WriteLine( "After increment {0}: {1}", i, incrementer );
      } // end for
   } // end Main
} // end class IncrementTest

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
