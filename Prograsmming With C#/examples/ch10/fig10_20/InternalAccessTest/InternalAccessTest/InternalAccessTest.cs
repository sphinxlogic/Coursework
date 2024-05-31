// Fig. 10.20: InternalAccessTest.cs
// Members declared internal in a class are accessible by other classes 
// in the same assembly.
using System;

public class InternalAccessTest
{
   public static void Main( string[] args )
   {
      InternalData internalData = new InternalData();

      // output string representation of internalData
      Console.WriteLine( "After instantiation:\n{0}", internalData );

      // change internal access data in internalData
      internalData.number = 77;
      internalData.message = "Goodbye";

      // output string representation of internalData
      Console.WriteLine( "\nAfter changing values:\n{0}", internalData );
   } // end Main
} // end class InternalAccessTest

// class with internal access instance variables
class InternalData
{
   internal int number; // internal-access instance variable   
   internal string message; // internal-access instance variable

   // constructor
   public InternalData()
   {
      number = 0;
      message = "Hello";
   } // end InternalData constructor

   // return InternalData object string representation
   public override string ToString()
   {
      return string.Format(
         "number: {0}; message: {1}", number, message );
   } // end method ToString
} // end class InternalData


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
