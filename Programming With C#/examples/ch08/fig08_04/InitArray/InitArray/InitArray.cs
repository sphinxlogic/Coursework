﻿// Fig. 8.4: InitArray.cs
// Calculating values to be placed into the elements of an array.
using System;

public class InitArray
{
   public static void Main( string[] args )
   {
      const int ARRAY_LENGTH = 10; // create a named constant
      int[] array = new int[ ARRAY_LENGTH ]; // create array

      // calculate value for each array element
      for ( int counter = 0; counter < array.Length; counter++ )
         array[ counter ] = 2 + 2 * counter;

      Console.WriteLine( "{0}{1,8}", "Index", "Value" ); // headings

      // output each array element's value 
      for ( int counter = 0; counter < array.Length; counter++ )
         Console.WriteLine( "{0,5}{1,8}", counter, array[ counter ] );
   } // end Main
} // end class InitArray


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
