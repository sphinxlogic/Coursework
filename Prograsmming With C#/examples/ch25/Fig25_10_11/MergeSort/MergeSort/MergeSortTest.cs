// Fig. 25.11: MergeSortTest.cs
// Testing the merge sort class.
using System;

public class MergeSortTest
{
   public static void Main( string[] args )
   {
      // create object to perform merge sort
      MergeSort sortArray = new MergeSort( 10 );

      // print unsorted array
      Console.WriteLine( "Unsorted: {0}\n", sortArray );

      sortArray.Sort(); // sort array

      // print sorted array
      Console.WriteLine( "Sorted: {0}", sortArray );
   } // end Main
} // end class MergeSortTest

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
 **************************************************************************/