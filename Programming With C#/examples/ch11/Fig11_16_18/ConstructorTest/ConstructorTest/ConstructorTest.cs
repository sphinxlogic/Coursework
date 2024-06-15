// Fig. 11.18: ConstructorTest.cs
// Display order in which base class and derived class constructors 
// are called.
using System;

public class ConstructorTest
{
   public static void Main( string[] args )
   {
      CommissionEmployee employee1 = new CommissionEmployee( "Bob",
         "Lewis", "333-33-3333", 5000.00M, .04M );

      Console.WriteLine();
      BasePlusCommissionEmployee employee2 =
         new BasePlusCommissionEmployee( "Lisa", "Jones",
         "555-55-5555", 2000.00M, .06M, 800.00M );

      Console.WriteLine();
      BasePlusCommissionEmployee employee3 =
         new BasePlusCommissionEmployee( "Mark", "Sands",
         "888-88-8888", 8000.00M, .15M, 2000.00M );
   } // end Main
} // end class ConstructorTest

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