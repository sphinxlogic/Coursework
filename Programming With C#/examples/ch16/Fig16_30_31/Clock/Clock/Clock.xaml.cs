﻿// Fig. 16.31: Clock.xaml.cs
// Using control templates (code-behind).
using System;
using System.Windows;
using System.Windows.Input;

namespace Clock
{
   public partial class ClockWindow : Window
   {
      // creates a timer to control clock
      private System.Windows.Threading.DispatcherTimer timer =
         new System.Windows.Threading.DispatcherTimer();

      // constructor 
      public ClockWindow()
      {
         InitializeComponent();

         timer.Interval = TimeSpan.FromSeconds( 1 ); // tick every second
         timer.IsEnabled = true; // enable timer

         timer.Tick += timer_Tick;
      } // end constructor

      // update the time when the timer ticks
      private void timer_Tick( object sender, EventArgs e )
      {
         DateTime currentTime = DateTime.Now; // get the current time

         // display the time as hh:mm:ss
         timeTextBox.Text = currentTime.ToLongTimeString();
      } // end method timer_Tick

      // drag Window when the left mouse button is held down
      private void clockWindow_MouseLeftButtonDown( object sender, 
         MouseButtonEventArgs e )
      {
         this.DragMove();
      } // end method clockWindow_MouseLeftButtonDown

      // minimize the application
      private void minimizeButton_Click( object sender, 
         RoutedEventArgs e )
      {
         this.WindowState = WindowState.Minimized; // minimize window
      } // end method minimizeButton_Click

      // close the application
      private void closeButton_Click( object sender, RoutedEventArgs e )
      {
         Application.Current.Shutdown(); // shut down application
      } // end method closeButton_Click
   } // end class ClockWindow
} // end namespace Clock

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