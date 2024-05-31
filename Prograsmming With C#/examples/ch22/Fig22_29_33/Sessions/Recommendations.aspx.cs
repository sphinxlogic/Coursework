// Fig. 22.33: Recommendations.aspx.cs
// Creates book recommendations based on a Session object.
using System;

public partial class Recommendations : System.Web.UI.Page
{
   // read Session items and populate ListBox with recommendations
   protected void Page_Init( object sender, EventArgs e )
   {
      // if there are Session items, list the appropriate books and ISBNs
      if ( Session.Count > 0 )
      {
         foreach ( string keyName in Session.Keys )
         {
            // use current key to display one of the session's 
            // name-value pairs
            booksListBox.Items.Add( keyName + " How to Program. ISBN: " +
               Session[ keyName ] );
         } // end foreach
      } // end if
      else
      {
         // if there are no items, then no language was chosen, so
         // display appropriate message and clear and hide booksListBox
         recommendationsLabel.Text = "No Recommendations";
         booksListBox.Visible = false;

         // modify languageLink because no language was selected
         languageLink.Text = "Click here to choose a language.";
      } // end else
   } // end method Page_Init
} // end class Recommendations