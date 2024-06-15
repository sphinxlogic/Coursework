// Fig. 18.15: StaticCharMethods.cs
// Demonstrates static character testing methods 
// from Char struct
using System;
using System.Windows.Forms;

namespace StaticCharMethods
{
   public partial class StaticCharMethodsForm : Form
   {
      // default constructor
      public StaticCharMethodsForm()
      {
         InitializeComponent();
      } // end constructor

      // handle analyzeButton_Click
      private void analyzeButton_Click( object sender, EventArgs e )
      {
         // convert string entered to type char
         char character = Convert.ToChar( inputTextBox.Text );
         string output;

         output = "is digit: " +
            Char.IsDigit( character ) + "\r\n";
         output += "is letter: " +
            Char.IsLetter( character ) + "\r\n";
         output += "is letter or digit: " +
            Char.IsLetterOrDigit( character ) + "\r\n";
         output += "is lower case: " +
            Char.IsLower( character ) + "\r\n";
         output += "is upper case: " +
            Char.IsUpper( character ) + "\r\n";
         output += "to upper case: " +
            Char.ToUpper( character ) + "\r\n";
         output += "to lower case: " +
            Char.ToLower( character ) + "\r\n";
         output += "is punctuation: " +
            Char.IsPunctuation( character ) + "\r\n";
         output += "is symbol: " + Char.IsSymbol( character );
         outputTextBox.Text = output;
      } // end method analyzeButton_Click
   } // end class StaticCharMethodsForm
} // end namespace StaticCharMethods

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