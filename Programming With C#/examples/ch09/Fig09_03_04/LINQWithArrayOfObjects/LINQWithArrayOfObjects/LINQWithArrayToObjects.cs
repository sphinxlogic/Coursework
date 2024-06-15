// Fig. 9.4: LINQWithArrayOfObjects.cs
// LINQ to Objects using an array of Employee objects.
using System;
using System.Linq;
using System.Collections.Generic;

public class LINQWithArrayOfObjects
{
   public static void Main( string[] args )
   {
      // initialize array of employees
      Employee[] employees = {
         new Employee( "Jason", "Red", 5000M ),
         new Employee( "Ashley", "Green", 7600M ),
         new Employee( "Matthew", "Indigo", 3587.5M ),
         new Employee( "James", "Indigo", 4700.77M ),
         new Employee( "Luke", "Indigo", 6200M ),
         new Employee( "Jason", "Blue", 3200M ),
         new Employee( "Wendy", "Brown", 4236.4M ) }; // end init list

      Display( employees, "Original array" ); // display all employees

      // filter a range of salaries using && in a LINQ query
      var between4K6K =
         from e in employees
         where e.MonthlySalary >= 4000M && e.MonthlySalary <= 6000M
         select e;

      // display employees making between 4000 and 6000 per month
      Display( between4K6K, string.Format(
         "Employees earning in the range {0:C}-{1:C} per month",
         4000, 6000 ) );

      // order the employees by last name, then first name with LINQ
      var nameSorted = 
         from e in employees 
         orderby e.LastName, e.FirstName 
         select e;

      // header
      Console.WriteLine( "First employee when sorted by name:" ); 

      // attempt to display the first result of the above LINQ query
      if ( nameSorted.Any() )
         Console.WriteLine( nameSorted.First().ToString() + "\n" );
      else
         Console.WriteLine( "not found\n" );

      // use LINQ to select employee last names
      var lastNames =
         from e in employees
         select e.LastName;

      // use method Distinct to select unique last names
      Display( lastNames.Distinct(), "Unique employee last names" );

      // use LINQ to select first and last names
      var names =
         from e in employees
         select new { e.FirstName, Last = e.LastName };

      Display( names, "Names only" ); // display full names
   } // end Main

   // display a sequence of any type, each on a separate line
   public static void Display< T >( 
      IEnumerable< T > results, string header )
   {
      Console.WriteLine( "{0}:", header ); // display header

      // display each element, separated by spaces
      foreach ( T element in results )
         Console.WriteLine( element );

      Console.WriteLine(); // add a blank line
   } // end method Display
} // end class LINQWithArrayOfObjects

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