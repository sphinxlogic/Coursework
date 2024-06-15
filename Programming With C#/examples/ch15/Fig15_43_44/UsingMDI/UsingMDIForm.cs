// Fig. 15.43: UsingMDIForm.cs
// Demonstrating use of MDI parent and child windows.
using System;
using System.Windows.Forms;

namespace UsingMDI
{
   // Form demonstrates the use of MDI parent and child windows
   public partial class UsingMDIForm : Form
   {
      // constructor
      public UsingMDIForm()
      {
         InitializeComponent();
      } // end constructor

      // create Visual C# image window
      private void csToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm( 
            "Visual C# 2008 How to Program",  @"vcs2008htp" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method child1ToolStripMenuItem_Click

      // create Visual C++ image window
      private void cppToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm( 
            "Visual C++ 2008 How to Program", @"vcpp2008htp" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method child2ToolStripMenuItem_Click

      // create Visual Basic image window
      private void child3ToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm(
            "Visual Basic 2008 How to Program", @"vb2008htp" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method child3MenuItem_Click

      // exit application
      private void exitToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         Application.Exit();
      } // end method exitToolStripMenuItem_Click

      // set Cascade layout
      private void cascadeToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.Cascade );
      } // end method cascadeToolStripMenuItem_Click

      // set TileHorizontal layout
      private void tileHorizontalToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileHorizontal );
      } // end method tileHorizontalToolStripMenuItem

      // set TileVertical layout
      private void tileVerticalToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileVertical );
      } // end method tileVerticalToolStripMenuItem_Click
   } // end class UsingMDIForm
} // end namespace UsingMDI

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
