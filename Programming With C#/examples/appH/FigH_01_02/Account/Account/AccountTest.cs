// Fig. H.2: AccountTest.cs
// Creating and manipulating an Account object.
using System;

public class AccountTest
{
   // Main method begins execution of C# application
   public static void Main( string[] args )
   {
      Account account1 = new Account( 50.00M ); // create Account object

      // display initial balance of account object
      Console.WriteLine( "account1 balance: {0:C}", 
         account1.Balance );

      decimal withdrawalAmount; // withdrawal amount entered by user

      Console.Write( "Enter withdrawal amount for account1: " );
      // obtain user input
      withdrawalAmount = Convert.ToDecimal( Console.ReadLine() );

      Console.WriteLine( "\nsubtracting {0:C} from account1 balance",
         withdrawalAmount );
      account1.Debit( withdrawalAmount ); // subtract amount from account1

      // display balance
      Console.WriteLine( "account1 balance: {0:C}", account1.Balance );
      Console.WriteLine();

      Console.Write( "Enter credit amount for account1: " );
      // obtain user input
      decimal creditAmount = Convert.ToDecimal( Console.ReadLine() );

      Console.WriteLine( "\nadding {0:C} to account1 balance",
         creditAmount );
      account1.Credit( creditAmount );

      // display balance
      Console.WriteLine( "account1 balance: {0:C}", account1.Balance );
      Console.WriteLine();
   } // end Main
} // end AccountTest

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