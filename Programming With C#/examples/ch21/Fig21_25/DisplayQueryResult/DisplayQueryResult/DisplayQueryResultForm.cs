// Fig. 21.25: DisplayQueryResultForm.cs
// Displaying the result of a user-selected query in a DataGridView.
using System;
using System.Linq;
using System.Windows.Forms;

namespace DisplayQueryResult
{
   public partial class DisplayQueryResultForm : Form
   {
      // constructor
      public DisplayQueryResultForm()
      {
         InitializeComponent();
      } // end constructor

      // LINQ to SQL data context
      private BooksDataContext database = new BooksDataContext();

      // load data from database into DataGridView
      private void DisplayQueryResultForm_Load(
         object sender, EventArgs e )
      {
         // write SQL to standard output stream
         database.Log = Console.Out;

         // set the ComboBox to show the default query that
         // selects all books from the Titles table
         queriesComboBox.SelectedIndex = 0;
      } // end method DisplayQueryResultForm_Load

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void titleBindingNavigatorSaveItem_Click(
         object sender, EventArgs e )
      {
         Validate(); // validate input fields
         titleBindingSource.EndEdit(); // indicate edits are complete
         database.SubmitChanges(); // write changes to databse file

         // when saving, return to "all titles" query
         queriesComboBox.SelectedIndex = 0;
      } // end method titleBindingNavigatorSaveItem_Click

      // loads data into TitleBindingSource based on user-selected query
      private void queriesComboBox_SelectedIndexChanged(
         object sender, EventArgs e )
      {
         // set the data displayed according to what is selected
         switch ( queriesComboBox.SelectedIndex )
         {
            case 0: // all titles
               // use LINQ to order the books by title
               titleBindingSource.DataSource =
                  from title in database.Titles
                  orderby title.BookTitle
                  select title;
               break;
            case 1: // titles with 2008 copyright
               // use LINQ to get titles with 2008
               // copyright and sort them by title
               titleBindingSource.DataSource =
                  from title in database.Titles
                  where title.Copyright == "2008"
                  orderby title.BookTitle
                  select title;
               break;
            case 2: // titles ending with "How to Program"
               // use LINQ to get titles ending with
               // "How to Program" and sort them by title
               titleBindingSource.DataSource =
                  from title in database.Titles
                  where title.BookTitle.EndsWith( "How to Program" )
                  orderby title.BookTitle
                  select title;
               break;
         } // end switch

         titleBindingSource.MoveFirst(); // move to first entry
      } // end method queriesComboBox_SelectedIndexChanged
   } // end class DisplayQueryResultForm
} // end namespace DisplayQueryResult

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
