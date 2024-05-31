// Fig. 10.29: AnonymousTypes.cs
// Using anonymous types.
using System;

class AnonymousTypes
{
   static void Main( string[] args )
   {
      // create a "person" object using an anonymous type
      var bob = new { Name = "Bob Smith", Age = 37 };

      // display bob's information
      Console.WriteLine( "Bob: " + bob.ToString() );

      // create another "person" object using the same anonymous type
      var steve = new { Name = "Steve Jones", Age = 26 };

      // display steve's information
      Console.WriteLine( "Steve: " + steve.ToString() );

      // determine if objects of the same anonymous type are equal
      Console.WriteLine( "\nBob and Steve are {0}",
         ( bob.Equals( steve ) ? "equal" : "not equal" ) );

      // create a "person" object using an anonymous type
      var bob2 = new { Name = "Bob Smith", Age = 37 };

      // display the bob's information
      Console.WriteLine( "\nBob2: " + bob2.ToString() );

      // determine whether objects of the same anonymous type are equal
      Console.WriteLine( "\nBob and Bob2 are {0}\n",
         ( bob.Equals( bob2 ) ? "equal" : "not equal" ) );
   } // end Main
} // end class AnonymousTypes

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