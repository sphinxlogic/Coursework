// Fig. 27.6: FullStackException.cs
// Indicates a stack is full.
using System;

class FullStackException : Exception
{
   // parameterless constructor
   public FullStackException() : base( "Stack is full" )
   {
      // empty constructor
   } // end FullStackException constructor

   // one-parameter constructor
   public FullStackException( string exception ) : base( exception )
   {
      // empty constructor
   } // end FullStackException constructor

   // two-parameter constructor
   public FullStackException( string exception, Exception inner )
      : base( exception, inner )
   {
      // empty constructor
   } // end FullStackException constructor
} // end class FullStackException

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