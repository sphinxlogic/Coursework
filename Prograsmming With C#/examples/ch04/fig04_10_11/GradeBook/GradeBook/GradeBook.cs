﻿// Fig. 4.10: GradeBook.cs
// GradeBook class with an auto-implemented property.
using System;

public class GradeBook
{
   // auto-implemented property CourseName implicitly creates
   // an instance variable for this GradeBook's course name
   public string CourseName { get; set; }

   // display a welcome message to the GradeBook user
   public void DisplayMessage()
   {
      // use auto-implemented property CourseName to get the 
      // name of the course that this GradeBook represents
      Console.WriteLine( "Welcome to the grade book for\n{0}!",
         CourseName ); // display auto-implemented property CourseName
   } // end method DisplayMessage
} // end class GradeBook


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
