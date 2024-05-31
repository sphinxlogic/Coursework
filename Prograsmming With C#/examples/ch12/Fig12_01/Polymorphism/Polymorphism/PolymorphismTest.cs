﻿// Fig. 12.1: PolymorphismTest.cs
// Assigning base class and derived class references to base class and
// derived class variables.
using System;

public class PolymorphismTest
{
   public static void Main( string[] args )
   {
      // assign base class reference to base class variable
      CommissionEmployee commissionEmployee = new CommissionEmployee(
         "Sue", "Jones", "222-22-2222", 10000.00M, .06M );

      // assign derived class reference to derived class variable
      BasePlusCommissionEmployee basePlusCommissionEmployee =
         new BasePlusCommissionEmployee( "Bob", "Lewis",
         "333-33-3333", 5000.00M, .04M, 300.00M );

      // invoke ToString and Earnings on base class object 
      // using base class variable
      Console.WriteLine( "{0} {1}:\n\n{2}\n{3}: {4:C}\n",
         "Call CommissionEmployee's ToString with base class reference",
         "to base class object", commissionEmployee.ToString(),
         "earnings", commissionEmployee.Earnings() );

      // invoke ToString and Earnings on derived class object 
      // using derived class variable      
      Console.WriteLine( "{0} {1}:\n\n{2}\n{3}: {4:C}\n",
         "Call BasePlusCommissionEmployee's ToString with derived class",
         "reference to derived class object",
         basePlusCommissionEmployee.ToString(),
         "earnings", basePlusCommissionEmployee.Earnings() );

      // invoke ToString and Earnings on derived class object 
      // using base class variable
      CommissionEmployee commissionEmployee2 =
         basePlusCommissionEmployee;
      Console.WriteLine( "{0} {1}:\n\n{2}\n{3}: {4:C}",
         "Call BasePlusCommissionEmployee's ToString with base class",
         "reference to derived class object",
         commissionEmployee2.ToString(), "earnings",
         commissionEmployee2.Earnings() );
   } // end Main
} // end class PolymorphismTest

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