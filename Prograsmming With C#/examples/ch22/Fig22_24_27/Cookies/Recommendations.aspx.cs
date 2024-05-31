// Fig. 22.27: Recommendations.aspx.cs
// Creates book recommendations based on cookies.
using System;
using System.Web;

public partial class Recommendations : System.Web.UI.Page
{
   // read cookies and populate ListBox with any book recommendations
   protected void Page_Init(object sender, EventArgs e)
   {
      // retrieve client's cookies
      HttpCookieCollection cookies = Request.Cookies;

      // if there are cookies, list the appropriate books and ISBNs
      if ( cookies.Count > 0 )
      {
         for ( int i = 0; i < cookies.Count; i++ )
            booksListBox.Items.Add( cookies[ i ].Name +
               " How to Program. ISBN: " + cookies[ i ].Value );
      } // end if
      else
      {
         // if there are no cookies, then no language was chosen, so
         // display appropariate message and clear and hide booksListBox
         recommendationsLabel.Text = "No Recommendations";
         booksListBox.Visible = false;

         // modify languageLink because no language was selected
         languageLink.Text = "Click here to choose a language.";
      } // end else
   } // end method Page_Init
} // end class Recommendations
