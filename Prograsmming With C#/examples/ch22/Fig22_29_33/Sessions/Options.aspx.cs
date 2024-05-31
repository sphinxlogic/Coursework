// Fig. 22.30: Options.aspx.cs
// Processes user's selection of a programming language by displaying
// links and writing information in a Session object.
using System;
using System.Collections.Generic;

public partial class Options : System.Web.UI.Page
{
   // stores values to represent books
   private Dictionary<string, string> books =
      new Dictionary<string, string>();

   // initializes the Dictionary when the Page initializes
   protected void Page_Init( object sender, EventArgs e )
   {
      books.Add( "Visual Basic 2008", "0-13-606305-X" );
      books.Add( "Visual C# 2008", "0-13-605322-X" );
      books.Add( "C", "0-13-240416-8" );
      books.Add( "C++", "0-13-615250-3" );
      books.Add( "Java", "0-13-222220-5" );
   } // end method Page_Init

   // hide and display links to make additional selections or view
   // recommendations, and record the user's selection in the Session
   // when the form is submitted
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // display appropriate message and hyperlinks
      responseLabel.Visible = true;
      idLabel.Visible = true;
      timeoutLabel.Visible = true;
      languageLink.Visible = true;
      recommendationsLink.Visible = true;

      // hide controls for selecting a language
      promptLabel.Visible = false;
      languageList.Visible = false;
      submitButton.Visible = false;

      // if the user made a selection
      if ( languageList.SelectedItem != null )
      {
         // get value of user's selection
         string language = languageList.SelectedItem.Value;

         string ISBN = books[ language ]; // get ISBN for given language

         Session.Add( language, ISBN ); // add name/value pair to Session

         // display user's selection in responseLabel
         responseLabel.Text += " You selected " + language + ".";
      } // end if
      else
      {
         // inform user that no selection was made
         responseLabel.Text += " You didn't make a selection.";
      } // end else

      idLabel.Text = "Your unique session ID is: " + Session.SessionID
         + "."; // display session ID

      // display amount of time before session times out
      timeoutLabel.Text = "Timeout: " + Session.Timeout + " minutes.";
   } // end method submitButton_Click
} // end class Options