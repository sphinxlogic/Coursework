// Fig. 10.5: Box.cs
// Box class definition represents a box with length, 
// width and height dimensions with indexers.
public class Box
{
   private string[] names = { "length", "width", "height" };
   private double[] dimensions = new double[ 3 ];

   // constructor
   public Box( double length, double width, double height )
   {
      dimensions[ 0 ] = length;
      dimensions[ 1 ] = width;
      dimensions[ 2 ] = height;
   }

   // indexer to access dimensions by integer index number
   public double this[ int index ]
   {
      get
      {
         // validate index to get
         if ( ( index < 0 ) || ( index >= dimensions.Length ) )
            return -1;
         else
            return dimensions[ index ];
      } // end get
      set
      {
         if ( index >= 0 && index < dimensions.Length )
            dimensions[ index ] = value;
      } // end set
   } // end numeric indexer

   // indexer to access dimensions by their string names
   public double this[ string name ]
   {
      get
      {
         // locate element to get
         int i = 0;
         while ( ( i < names.Length ) &&
            ( name.ToLower() != names[ i ] ) )
            ++i;

         return ( i == names.Length ) ? -1 : dimensions[ i ];
      } // end get
      set
      {
         // locate element to set
         int i = 0;
         while ( ( i < names.Length ) &&
            ( name.ToLower() != names[ i ] ) )
            ++i;

         if ( i != names.Length )
            dimensions[ i ] = value;
      } // end set
   } // end string indexer
} // end class Box


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