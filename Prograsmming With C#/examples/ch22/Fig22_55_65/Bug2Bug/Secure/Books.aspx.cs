// Fig. 22.63: Books.aspx.cs
// Code-behind file that defines event handlers for the secure books
// database application.
using System;
using System.Linq;
using System.Web.UI.WebControls;

public partial class Secure_Books : System.Web.UI.Page
{
   // instantiate data context queried by data sources
   BooksDBDataContext booksDatabase = new BooksDBDataContext();

   // runs a query and uses the result as authorsLinqDataSource's data
   protected void authorsLinqDataSource_Selecting( 
      object sender, LinqDataSourceSelectEventArgs e )
   {
      // select LINQ query returning all authors full names and IDs
      e.Result = from authors in booksDatabase.Authors
         select new
         {
            Name = authors.FirstName + " " + authors.LastName,
            authors.AuthorID
         };
   } // end method authorsLinqDataSource_Selecting

   // runs a query and uses the result as booksLinqDataSource's data
   protected void booksLinqDataSource_Selecting( 
      object sender, LinqDataSourceSelectEventArgs e )
   {
      // select LINQ query return all books by the selected author
      e.Result = from book in booksDatabase.Books
         join isbn in booksDatabase.AuthorISBNs
         on book.ISBN equals isbn.ISBN
         where isbn.AuthorID.Equals(authorsDropDownList.SelectedValue)
         select book;
   } // end method booksLinqDataSource_Selecting

   // updates the books list whenever the user selects a new author
   protected void authorsDropDownList_SelectedIndexChanged( 
      object sender, EventArgs e )
   {
      booksGridView.DataBind(); // update the GridView
   } // end method authorsDropDownList_SelectedIndexChanged
} // end class Secure_Books
