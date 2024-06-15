// Fig. 9.6: ListCollection.cs
// Generic List collection demonstration.
using System;
using System.Collections.Generic;

public class ListCollection
{
   public static void Main( string[] args )
   {
      // create a new List of strings
      List< string > items = new List< string >(); 

      items.Add( "red" ); // append an item to the List
      items.Insert( 0, "yellow" ); // insert the value at index 0

      // header
      Console.Write( 
         "Display list contents with counter-controlled loop:" ); 

      // display the colors in the list
      for ( int i = 0; i < items.Count; i++ )
         Console.Write( " {0}", items[ i ] );

      // display colors using foreach in the Display method
      Display( items,
         "\nDisplay list contents with foreach statement:" );

      items.Add( "green" ); // add "green" to the end of the List
      items.Add( "yellow" ); // add "yellow" to the end of the List
      // display the List
      Display( items, "List with two new elements:" ); 

      items.Remove( "yellow" ); // remove the first "yellow"
      // display List
      Display( items, "Remove first instance of yellow:" ); 

      items.RemoveAt( 1 ); // remove item at index 1
      // display List
      Display( items, "Remove second list element (green):" ); 

      // check if a value is in the List
      Console.WriteLine( "\"red\" is {0}in the list",
         items.Contains( "red" ) ? string.Empty : "not " );

      // display number of elements in the List
      Console.WriteLine( "Count: {0}", items.Count );

      // display the capacity of the List
      Console.WriteLine( "Capacity: {0}", items.Capacity );
   } // end Main

   // display the List's elements on the console
   public static void Display( List< string > items, string header )
   {
      Console.Write( header ); // display header

      // display each element in items
      foreach ( var item in items )
         Console.Write( " {0}", item );

      Console.WriteLine(); // display end of line
   } // end method Display
} // end class ListCollection

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
