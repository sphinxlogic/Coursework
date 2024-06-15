// Fig. 22.5: WebTime.aspx.cs
// Code-behind file for a page that displays the current time.
using System;

public partial class WebTime : System.Web.UI.Page
{
   // initializes the contents of the page
   protected void Page_Init( object sender, EventArgs e )
   {
      // display the server's current time in timeLabel
      timeLabel.Text = DateTime.Now.ToString( "hh:mm:ss" );
   } // end method Page_Init
} // end class WebTime