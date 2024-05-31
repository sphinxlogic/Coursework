// Fig. 17.7: UsingGradients.xaml.cs
// Customizing gradients.
using System;
using System.Windows;
using System.Windows.Media;

namespace UsingGradients
{
   public partial class UsingGradientsWindow : Window
   {
      // constructor
      public UsingGradientsWindow()
      {
         InitializeComponent();
      } // end constructor

      // change the starting color of the gradient when the user clicks
      private void fromButton_Click( object sender, RoutedEventArgs e )
      {
         // change the color to use the ARGB values specified by user
         startGradient.Color = Color.FromArgb(
            Convert.ToByte( fromAlpha.Text ),
            Convert.ToByte( fromRed.Text ),
            Convert.ToByte( fromGreen.Text ),
            Convert.ToByte( fromBlue.Text ) );
      } // end method fromButton_Click

      // change the ending color of the gradient when the user clicks
      private void toButton_Click( object sender, RoutedEventArgs e )
      {
         // change the color to use the ARGB values specified by user
         stopGradient.Color = Color.FromArgb(
            Convert.ToByte( toAlpha.Text ),
            Convert.ToByte( toRed.Text ),
            Convert.ToByte( toGreen.Text ),
            Convert.ToByte( toBlue.Text ) );
      } // end method toButton_Click
   } // end class UsingGradientsWindow
} // end namespace UsingGradients