// Fig. 13.2: DivideByZeroTest.cs
// FormatException and DivideByZeroException handlers.
using System;
using System.Windows.Forms;

namespace DivideByZeroTest
{
   public partial class DivideByZeroTestForm : Form
   {
      public DivideByZeroTestForm()
      {
         InitializeComponent();
      } // end constructor

      // obtain 2 integers from the user 
      // and divide numerator by denominator
      private void divideButton_Click( object sender, EventArgs e )
      {
         outputLabel.Text = ""; // clear Label OutputLabel

         // retrieve user input and calculate quotient                   
         try
         {
            // Convert.ToInt32 generates FormatException                 
            // if argument cannot be converted to an integer
            int numerator = Convert.ToInt32( numeratorTextBox.Text );
            int denominator = Convert.ToInt32( denominatorTextBox.Text );

            // division generates DivideByZeroException                  
            // if denominator is 0                                       
            int result = numerator / denominator;

            // display result in OutputLabel                             
            outputLabel.Text = result.ToString();
         } // end try  
         catch ( FormatException )
         {
            MessageBox.Show( "You must enter two integers.",
               "Invalid Number Format", MessageBoxButtons.OK,
               MessageBoxIcon.Error );
         } // end catch                                                  
         catch ( DivideByZeroException divideByZeroExceptionParameter )
         {
            MessageBox.Show( divideByZeroExceptionParameter.Message,
               "Attempted to Divide by Zero", MessageBoxButtons.OK,
                MessageBoxIcon.Error );
         } // end catch
      } // end method DivideButton_Click
   } // end class DivideByZeroTestForm
} // end namespace DivideByZeroTest

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
 **************************************************************************/