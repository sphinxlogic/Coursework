// Fig. 21.27: JoiningTest.cs
// Using LINQ to perform a join and aggregate data across tables.
using System;
using System.Linq;

namespace JoiningWithLINQ
{
   public class JoiningTest
   {
      public static void Main( string[] args )
      {
         // create database connection
         BooksDataContext database = new BooksDataContext();

         // get authors and ISBNs of each book they co-authored
         var authorsAndISBNs =
            from author in database.Authors
            join book in database.AuthorISBNs
               on author.AuthorID equals book.AuthorID
            orderby author.LastName, author.FirstName
            select new { author.FirstName, author.LastName, book.ISBN };

         Console.WriteLine( "Authors and ISBNs:" ); // display header

         // display authors and ISBNs in tabular format
         foreach ( var element in authorsAndISBNs )
         {
            Console.WriteLine( "\t{0,-10} {1,-10} {2,-10}",
               element.FirstName, element.LastName, element.ISBN );
         } // end foreach

         // get authors and titles of each book they co-authored
         var authorsAndTitles =
            from title in database.Titles
            from book in title.AuthorISBNs
            let author = book.Author
            orderby author.LastName, author.FirstName, title.BookTitle
            select new { author.FirstName, author.LastName,
               title.BookTitle };

         Console.WriteLine( "\nAuthors and titles:" ); // header

         // display authors and titles in tabular format
         foreach ( var element in authorsAndTitles )
         {
            Console.WriteLine( "\t{0,-10} {1,-10} {2}",
               element.FirstName, element.LastName, element.BookTitle );
         } // end foreach

         // get authors and titles of each book 
         // they co-authored; group by author
         var titlesByAuthor =
            from author in database.Authors
            orderby author.LastName, author.FirstName
            let name = author.FirstName + " " + author.LastName
            let titles =
               from book in author.AuthorISBNs
               orderby book.Title.BookTitle
               select book.Title.BookTitle
            select new { Name = name, Titles = titles };

         Console.WriteLine( "\nTitles grouped by author:" ); // header

         // display titles written by each author, grouped by author
         foreach ( var author in titlesByAuthor )
         {
            // display author's name
            Console.WriteLine( "\t" + author.Name + ":" );

            // display titles written by that author
            foreach ( var title in author.Titles )
            {
               Console.WriteLine( "\t\t" + title );
            } // end inner foreach
         } // end outer foreach
      } // end Main
   } // end class JoiningTest
} // end namespace JoiningWithLINQ

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
