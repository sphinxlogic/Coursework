// Fig. 19.12: CreditInquiryForm.cs
// Read a file sequentially and display contents based on
// account type specified by user ( credit, debit or zero balances ).
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CreditInquiry
{
   public partial class CreditInquiryForm : Form
   {
      private FileStream input; // maintains the connection to the file
      private StreamReader fileReader; // reads data from text file

      // name of file that stores credit, debit and zero balances
      private string fileName;

      // parameterless constructor
      public CreditInquiryForm()
      {
         InitializeComponent();
      } // end constructor

      // invoked when user clicks Open File button
      private void openButton_Click( object sender, EventArgs e )
      {
         // create dialog box enabling user to open file         
         DialogResult result;

         using ( OpenFileDialog fileChooser = new OpenFileDialog() )
         {
            result = fileChooser.ShowDialog();
            fileName = fileChooser.FileName;
         } // end using

         // exit event handler if user clicked Cancel
         if ( result == DialogResult.OK )
         {
            // show error if user specified invalid file
            if ( fileName == string.Empty )
               MessageBox.Show( "Invalid File Name", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            else
            {
               // create FileStream to obtain read access to file
               input = new FileStream( fileName,
                  FileMode.Open, FileAccess.Read );

               // set file from where data is read
               fileReader = new StreamReader( input );

               // enable all GUI buttons, except for Open File button
               openButton.Enabled = false;
               creditButton.Enabled = true;
               debitButton.Enabled = true;
               zeroButton.Enabled = true;
            } // end else
         } // end if
      } // end method openButton_Click

      // invoked when user clicks credit balances,
      // debit balances or zero balances button
      private void getBalances_Click( object sender, System.EventArgs e )
      {
         // delegate used to check a balance against a certain condition
         Func<decimal, bool> balanceChooser;

         // convert sender explicitly to object of type button
         Button senderButton = ( Button ) sender;

         // determine the condition the account balances must satisfy
         switch ( senderButton.Text )
         {
            case "Credit Balances":  // positive balances
               balanceChooser = balance => balance > 0M;
               break;
            case "Debit Balances": // negative balances
               balanceChooser = balance => balance < 0M;
               break;
            default: // zero balances
               balanceChooser = balance => balance == 0;
               break;
         } // end switch

         // read and display file information
         try
         {
            displayTextBox.Text = "The accounts are:\n";

            // select records that match account type
            var balanceQuery =
               from line in fileReader.Lines()
               let record = line.Split( ',' ) as string[]
               where balanceChooser( Convert.ToDecimal( record[ 3 ] ) )
               select new Record
               {
                  Account = Convert.ToInt32( record[ 0 ] ),
                  FirstName = record[ 1 ],
                  LastName = record[ 2 ],
                  Balance = Convert.ToDecimal( record[ 3 ] )
               };

            // display each selected Record 
            foreach ( var creditRecord in balanceQuery )
            {
               // display the Record's information in the RichTextBox
               displayTextBox.AppendText(
                  String.Format( "{0}\t{1}\t{2}\n", creditRecord.Account,
                  creditRecord.FirstName, creditRecord.LastName ) );
            } // end foreach
         } // end try
         // handle exception when file cannot be read
         catch ( IOException )
         {
            MessageBox.Show( "Cannot Read File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         } // end catch
      } // end method getBalances_Click

      // invoked when user clicks Done button
      private void doneButton_Click( object sender, EventArgs e )
      {
         if ( input != null )
         {
            // close file and StreamReader
            try
            {
               // close StreamReader and underlying file
               fileReader.Close();
            } // end try
            // handle exception if FileStream does not exist
            catch ( IOException )
            {
               // notify user of error closing file
               MessageBox.Show( "Cannot close file", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error );
            } // end catch
         } // end if

         Application.Exit();
      } // end method doneButton_Click
   } // end class CreditInquiryForm

   // static class containing extension methods for class StreamReader
   public static class StreamReaderExtensions
   {
      // iterate over each line in a file
      public static IEnumerable<string> Lines( this StreamReader source )
      {
         // check for null reference
         if ( source == null )
            throw new ArgumentNullException( "StreamReader is null" );

         // start at the beginning of the file
         source.BaseStream.Seek( 0, SeekOrigin.Begin );

         string line; // a line of text

         // while there are lines left in the file
         while ( ( line = source.ReadLine() ) != null )
         {
            yield return line; // return one line of the file as a string
         } // end while
      } // end extension method Lines
   } // end static class StreamReaderExtensions
} // end namespace CreditInquiry

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