﻿// Fig. 7.11: Scope.cs
// Scope class demonstrates instance and local variable scopes.
using System;

public class Scope
{
   // instance variable that is accessible to all methods of this class 
   private int x = 1;

   // method Begin creates and initializes local variable x 
   // and calls methods UseLocalVariable and UseInstanceVariable
   public void Begin()
   {
      int x = 5; // method's local variable x hides instance variable x

      Console.WriteLine( "local x in method Begin is {0}", x );

      // UseLocalVariable has its own local x
      UseLocalVariable();

      // UseInstanceVariable uses class Scope's instance variable x
      UseInstanceVariable();

      // UseLocalVariable reinitializes its own local x
      UseLocalVariable();

      // class Scope's instance variable x retains its value
      UseInstanceVariable();

      Console.WriteLine( "\nlocal x in method Begin is {0}", x );
   } // end method Begin

   // create and initialize local variable x during each call
   public void UseLocalVariable()
   {
      int x = 25; // initialized each time UseLocalVariable is called

      Console.WriteLine(
         "\nlocal x on entering method UseLocalVariable is {0}", x );
      ++x; // modifies this method's local variable x
      Console.WriteLine(
         "local x before exiting method UseLocalVariable is {0}", x );
   } // end method UseLocalVariable

   // modify class Scope's instance variable x during each call
   public void UseInstanceVariable()
   {
      Console.WriteLine( "\ninstance variable x on entering {0} is {1}",
         "method UseInstanceVariable", x );
      x *= 10; // modifies class Scope's instance variable x
      Console.WriteLine( "instance variable x before exiting {0} is {1}",
         "method UseInstanceVariable", x );
   } // end method UseInstanceVariable
} // end class Scope


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
