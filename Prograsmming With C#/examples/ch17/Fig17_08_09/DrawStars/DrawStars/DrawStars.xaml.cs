// Fig. 17.9: DrawStars.xaml.cs
// Applying transforms to a Polygon.
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawStars
{
   public partial class DrawStarsWindow : Window
   {
      // constructor
      public DrawStarsWindow()
      {
         InitializeComponent();

         Random random = new Random(); // get random values for colors

         // create 18 more stars
         for ( int count = 0; count < 18; count++ )
         {
            Polygon newStar = new Polygon(); // create a polygon object
            newStar.Points = star.Points; // copy the points collection

            byte[] colorValues = new byte[ 4 ]; // create a Byte array
            random.NextBytes( colorValues ); // create four random values
            newStar.Fill = new SolidColorBrush( Color.FromArgb(
               colorValues[ 0 ], colorValues[ 1 ], colorValues[ 2 ],
               colorValues[ 3 ] ) ); // creates a random color brush

            // apply a rotation to the shape
            RotateTransform rotate =
               new RotateTransform( count * 20, 150, 150 );
            newStar.RenderTransform = rotate;
            mainCanvas.Children.Add( newStar );
         } // end for
      } // end constructor
   } // end class DrawStarsWindow
} // end namespace DrawStars