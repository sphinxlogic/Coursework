﻿// Fig. 9.2: LINQWithSimpleTypeArray.cs
// LINQ to Objects using an Integer array.
using System;
using System.Linq;
using System.Collections.Generic;

class LINQWithSimpleTypeArray
{
   public static void Main( string[] args )
   {
      // create an integer array
      int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

      Display( values, "Original array:" ); // display original values

      // LINQ query that obtains values greater than 4 from the array
      var filtered =
         from value in values
         where value > 4
         select value;

      // display filtered results
      Display( filtered, "Array values greater than 4:" );

      // use orderby clause to sort original array in ascending order
      var sorted =
         from value in values
         orderby value
         select value;

      // display sorted results
      Display( sorted, "Original array, sorted:" );

      // sort the filtered results into descending order
      var sortFilteredResults =
         from value in filtered
         orderby value descending
         select value;

      // display the sorted results
      Display( sortFilteredResults,
         "Values greater than 4, descending order (separately):" );

      // filter original array and sort in descending order
      var sortAndFilter =
         from value in values
         where value > 4
         orderby value descending
         select value;

      // display the filtered and sorted results
      Display( sortAndFilter,
         "Values greater than 4, descending order (one query):" );
   } // end Main

   // display a sequence of integers with the specified header
   public static void Display( 
      IEnumerable< int > results, string header )
   {
      Console.Write( "{0}", header ); // display header

      // display each element, separated by spaces
      foreach ( var element in results )
         Console.Write( " {0}", element );

      Console.WriteLine(); // add end of line
   } // end method Display
} // end class LINQWithSimpleTypeArray

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