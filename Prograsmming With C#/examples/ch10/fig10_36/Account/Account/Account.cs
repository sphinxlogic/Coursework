// Fig. 10.36: Account.cs
// Class Account represents a bank account.
public class Account
{
   private int accountNumber; // account number
   private int pin; // PIN for authentication

   // automatic read-only property AvailableBalance
   public decimal AvailableBalance { get; private set; }

   // automatic read-only property TotalBalance
   public decimal TotalBalance { get; private set; }
   
   // parameterless constructor
   public Account()
   {
      // constructor body code
   } // end constructor

   // validates user PIN
   public bool ValidatePIN()
   {
      // ValidatePIN method body code
   } // end method ValidatePIN

   // credits the account
   public void Credit()
   {
      // Credit method body code
   } // end method Credit

   // debits the account
   public void Debit()
   {
      // Debit method body code
   } // end method Debit
} // end class Account


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