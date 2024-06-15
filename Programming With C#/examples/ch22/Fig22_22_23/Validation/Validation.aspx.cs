// Fig. 22.23: Validation.aspx.cs
// Code-behind file for the form demonstrating validation controls.
using System;

public partial class Validation : System.Web.UI.Page
{
   // Page_Load event handler executes when the page is loaded
   protected void Page_Load( object sender, EventArgs e )
   {
      // if this is not the first time the page is loading
      // (i.e., the user has already submitted form data)
      if ( IsPostBack )
      {
         Validate(); // validate the form

         // if the form is valid
         if ( IsValid )
         {
            // retrieve the values submitted by the user
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            // create a table indicating the submitted values
            outputLabel.Text +=
               "<br />We received the following information:" +
               "<table style=\"background-color: yellow\">" +
               "<tr><td>Name:</td><td>" + name + "</td></tr>" +
               "<tr><td>E-mail address:</td><td>" + email + 
               "</td></tr>" +
               "<tr><td>Phone number:</td><td>" + phone + "</td></tr>" +
               "</table>";

            outputLabel.Visible = true; // display the output message
         } // end if
      } // end if
   } // end method Page_Load
} // end class Validation