// Fig. 10.6: BoxTest.cs
// Indexers provide access to a Box object's members.
using System;

public class BoxTest
{
   public static void Main( string[] args )
   {
      // create a box
      Box box = new Box( 30, 30, 30 );

      // show dimensions with numeric indexers
      Console.WriteLine( "Created a box with the dimensions:" );
      Console.WriteLine( "box[ 0 ] = {0}", box[ 0 ] );
      Console.WriteLine( "box[ 1 ] = {0}", box[ 1 ] );
      Console.WriteLine( "box[ 2 ] = {0}", box[ 2 ] );

      // set a dimension with the numeric indexer
      Console.WriteLine( "\nSetting box[ 0 ] to 10...\n" );
      box[ 0 ] = 10;

      // set a dimension with the string indexer
      Console.WriteLine( "Setting box[ \"width\" ] to 20...\n" );
      box[ "width" ] = 20;

      // show dimensions with string indexers
      Console.WriteLine( "Now the box has the dimensions:" );
      Console.WriteLine( "box[ \"length\" ] = {0}", box[ "length" ] );
      Console.WriteLine( "box[ \"width\" ] = {0}", box[ "width" ] );
      Console.WriteLine( "box[ \"height\" ] = {0}", box[ "height" ] );
   } // end Main
} // end class BoxTest

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