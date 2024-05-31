// Fig. 15.7: MenuTest.cs
// Using Menus to change font colors and styles.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuTest
{
   // our Form contains a Menu that changes the font color
   // and style of the text displayed in Label
   public partial class MenuTestForm : Form
   {
      // constructor
      public MenuTestForm()
      {
         InitializeComponent();
      } // end constructor

      // display MessageBox when About MenuItem is selected
      private void aboutToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         MessageBox.Show( "This is an example\nof using menus.", "About",
            MessageBoxButtons.OK, MessageBoxIcon.Information );
      } // end method aboutMenuItem_Click

      // exit program when Exit MenuItem is selected
      private void exitToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         Application.Exit();
      } // end method exitMenuItem_Click

      // reset checkmarks for Color MenuItems
      private void ClearColor()
      {
         // clear all checkmarks
         blackToolStripMenuItem.Checked = false;
         blueToolStripMenuItem.Checked = false;
         redToolStripMenuItem.Checked = false;
         greenToolStripMenuItem.Checked = false;
      } // end method ClearColor

      // update Menu state and color display black
      private void blackToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // reset checkmarks for Color MenuItems
         ClearColor();

         // set Color to Black
         displayLabel.ForeColor = Color.Black;
         blackToolStripMenuItem.Checked = true;
      } // end method blackMenuItem_Click

      // update Menu state and color display blue
      private void blueToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         // reset checkmarks for Color MenuItems
         ClearColor();

         // set Color to Blue
         displayLabel.ForeColor = Color.Blue;
         blueToolStripMenuItem.Checked = true;
      } // end method blueMenuItem_Click

      // update Menu state and color display red
      private void redToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         // reset checkmarks for Color MenuItems
         ClearColor();

         // set Color to Red
         displayLabel.ForeColor = Color.Red;
         redToolStripMenuItem.Checked = true;
      } // end method redMenuItem_Click

      // update Menu state and color display green
      private void greenToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // reset checkmarks for Color MenuItems
         ClearColor();

         // set Color to Green
         displayLabel.ForeColor = Color.Green;
         greenToolStripMenuItem.Checked = true;
      } // end method greenMenuItem_Click

      // reset checkmarks for Font MenuItems
      private void ClearFont()
      {
         // clear all checkmarks
         timesToolStripMenuItem.Checked = false;
         courierToolStripMenuItem.Checked = false;
         comicToolStripMenuItem.Checked = false;
      } // end method ClearFont

      // update Menu state and set Font to Times New Roman
      private void timesToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // reset checkmarks for Font MenuItems
         ClearFont();

         // set Times New Roman font
         timesToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font( "Times New Roman", 14,
            displayLabel.Font.Style );
      } // end method timesMenuItem_Click

      // update Menu state and set Font to Courier
      private void courierToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // reset checkmarks for Font MenuItems
         ClearFont();

         // set Courier font
         courierToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font( "Courier", 14,
            displayLabel.Font.Style );
      } // end method courierMenuItem_Click

      // update Menu state and set Font to Comic Sans MS
      private void comicToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // reset checkmarks for Font MenuItems
         ClearFont();

         // set Comic Sans font
         comicToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font( "Comic Sans MS", 14,
            displayLabel.Font.Style );
      } // end method comicMenuItem_Click

      // toggle checkmark and toggle bold style
      private void boldToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         // toggle checkmark
         boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;

         // use Xor to toggle bold, keep all other styles
         displayLabel.Font = new Font( displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Bold );
      } // end method boldMenuItem_Click

      // toggle checkmark and toggle italic style
      private void italicToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // toggle checkmark
         italicToolStripMenuItem.Checked = 
            !italicToolStripMenuItem.Checked;

         // use Xor to toggle italic, keep all other styles
         displayLabel.Font = new Font( displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Italic );
      } // end method italicMenuItem_Click
   } // end class MenuTestForm
} // end namespace MenuTest

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
