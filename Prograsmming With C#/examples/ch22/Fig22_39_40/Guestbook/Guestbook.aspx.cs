// Fig. 22.40: Guestbook.aspx.cs
// Code-behind file that defines event handlers for the guestbook.
using System;
using System.Collections.Generic;

public partial class Guestbook : System.Web.UI.Page
{
   // Submit Button adds a new guestbook entry to the database, clears
   // the form and displays the updated list of guestbook entries
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // create dictionary of parameters for inserting
      Dictionary< string, string > parameters =
         new Dictionary< string, string >();

      // add current date and the user's name, e-mail, address and
      // message to dictionary of insert parameters
      parameters.Add( "Date", DateTime.Now.ToShortDateString() );
      parameters.Add( "Name", nameTextBox.Text );
      parameters.Add( "Email", emailTextBox.Text );
      parameters.Add( "MessageText", messageTextBox.Text );

      // execute an insert LINQ statement to add a new entry to the
      // Messages table in the Guestbook data context that contains the
      // current date and the user's name, e-mail address and message
      messagesLinqDataSource.Insert( parameters );

      // clear the TextBoxes
      clearButton_Click( sender, e );
      
      // update the GridView with the new database table contents
      messagesGridView.DataBind();
   } // end method submitButton_Click

   // Clear Button clears the Web Form's TextBoxes
   protected void clearButton_Click( object sender, EventArgs e )
   {
      nameTextBox.Text = string.Empty;
      emailTextBox.Text = string.Empty;
      messageTextBox.Text = string.Empty;
   } //end method clearButton_Click
} // end class Guestbook
