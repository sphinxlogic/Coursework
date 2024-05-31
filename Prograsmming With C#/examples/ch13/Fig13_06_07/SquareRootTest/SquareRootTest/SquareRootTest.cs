// Fig. 13.7: SquareRootTest.cs
// Demonstrating a user-defined exception class.
using System;
using System.Windows.Forms;

namespace SquareRootTest
{
   public partial class SquareRootForm : Form
   {
      public SquareRootForm()
      {
         InitializeComponent();
      } // end constructor

      // computes square root of parameter; throws 
      // NegativeNumberException if parameter is negative
      public double SquareRoot( double value )
      {
         // if negative operand, throw NegativeNumberException
         if ( value < 0 )
            throw new NegativeNumberException(                  
               "Square root of negative number not permitted" );
         else
            return Math.Sqrt( value ); // compute square root
      } // end method SquareRoot

      // obtain user input, convert to double, calculate square root
      private void squareRootButton_Click( object sender, EventArgs e )
      {
         outputLabel.Text = ""; // clear OutputLabel

         // catch any NegativeNumberException thrown
         try
         {
            double result =
               SquareRoot( Convert.ToDouble( inputTextBox.Text ) );

            outputLabel.Text = result.ToString();
         } // end try
         catch ( FormatException formatExceptionParameter )
         {
            MessageBox.Show( formatExceptionParameter.Message,
               "Invalid Number Format", MessageBoxButtons.OK,
               MessageBoxIcon.Error );
         } // end catch
         catch ( NegativeNumberException                              
            negativeNumberExceptionParameter )                        
         {                                                            
            MessageBox.Show( negativeNumberExceptionParameter.Message,
               "Invalid Operation", MessageBoxButtons.OK,             
               MessageBoxIcon.Error );                                
         } // end catch                                               
      } // end method squareRootButton_Click
   } // end class SquareRootForm
} // end namespace SquareRootTest

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