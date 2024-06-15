// Fig. 17.14: TV.xaml.cs
// TV GUI showing the versatility of WPF customization (code-behind).
using System.Windows;

namespace TV
{
   public partial class TVWindow : Window
   {
      // constructor
      public TVWindow()
      {
         InitializeComponent();
      } // end constructor

      // turns "on" the TV
      private void powerCheckBox_Checked( object sender, 
         RoutedEventArgs e )
      {
         // render the reflection visible
         reflectionRectangle.Visibility = Visibility.Visible;

         // enable play, pause, and stop buttons
         playRadioButton.IsEnabled = true;
         pauseRadioButton.IsEnabled = true;
         stopRadioButton.IsEnabled = true;
      } // end method powerCheckBox_Checked

      // turns "off" the TV
      private void powerCheckBox_Unchecked( object sender, 
         RoutedEventArgs e )
      {
         // shut down the screen
         videoMediaElement.Close();         

         // hide the reflection
         reflectionRectangle.Visibility = Visibility.Hidden;

         // disable the play, pause, and stop buttons
         playRadioButton.IsChecked = false;
         pauseRadioButton.IsChecked = false;
         stopRadioButton.IsChecked = false;
         playRadioButton.IsEnabled = false;
         pauseRadioButton.IsEnabled = false;
         stopRadioButton.IsEnabled = false;
      } // end method powerCheckBox_Unchecked

      // plays the video
      private void playRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Play();
      } // end method playRadioButton_Checked

      // pauses the video
      private void pauseRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Pause();
      } // end method pauseRadioButton_Checked

      // stops the video
      private void stopRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Stop();
      } // end method stopRadioButton_Checked
   } // end class TVWindow
} // end namespace TV