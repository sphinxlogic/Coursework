// Fig. 17.4: DrawPolygons.xaml.cs
// Drawing Polylines and Polygons.
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DrawPolygons
{
   public partial class DrawPolygonsWindow : Window
   {
      // stores the collection of points for the multi-sided shapes
      private PointCollection points = new PointCollection();

      // initialize the points of the shapes
      public DrawPolygonsWindow()
      {
         InitializeComponent();

         polyLine.Points = points; // assign Polyline points
         polygon.Points = points; // assign Polygon points
         filledPolygon.Points = points; // assign filled Polygon points
      } // end constructor

      // adds a new point when the user clicks on the canvas
      private void drawCanvas_MouseDown( object sender, 
         MouseButtonEventArgs e )
      {
         // add point to collection
         points.Add( e.GetPosition( drawCanvas ) );
      } // end method drawCanvas_MouseDown

      // when the clear Button is clicked
      private void clearButton_Click( object sender, RoutedEventArgs e )
      {
         points.Clear(); // clear the points from the collection
      } // end method clearButton_Click

      // when the user selects the Polyline
      private void lineRadio_Checked( object sender, RoutedEventArgs e )
      {
         // Polyline is visible, the other two are not
         polyLine.Visibility = Visibility.Visible;
         polygon.Visibility = Visibility.Collapsed;
         filledPolygon.Visibility = Visibility.Collapsed;
      } // end method lineRadio_Checked

      //  when the user selects the Polygon
      private void polygonRadio_Checked( object sender, 
         RoutedEventArgs e )
      {
         // Polygon is visible, the other two are not
         polyLine.Visibility = Visibility.Collapsed;
         polygon.Visibility = Visibility.Visible;
         filledPolygon.Visibility = Visibility.Collapsed;
      } // end method polygonRadio_Checked

      // when the user selects the filled Polygon
      private void filledPolygonRadio_Checked( object sender, 
         RoutedEventArgs e )
      {
         // filled Polygon is visible, the other two are not
         polyLine.Visibility = Visibility.Collapsed;
         polygon.Visibility = Visibility.Collapsed;
         filledPolygon.Visibility = Visibility.Visible;
      } // end method filledPolygonRadio_Checked
   } // end class DrawPolygonsWindow
} // end namespace DrawPolygons