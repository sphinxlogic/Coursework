// Fig. 17.20: Application3D.xaml.cs
// Changing the axis of rotation for a 3-D animation.
using System.Windows;
using System.Windows.Media.Media3D;

namespace Application3D
{
   public partial class Application3DWindow : Window
   {
      // constructor
      public Application3DWindow()
      {
         InitializeComponent();
      } // end constructor

      // when user selects xRadio, set axis of rotation
      private void xRadio_Checked( object sender, RoutedEventArgs e )
      {
         rotation.Axis = new Vector3D( 1, 0, 0 ); // set rotation axis
         camera.Position = new Point3D( 6, 0, 0 ); // set camera position
      } // end method xRadio_Checked

      // when user selects yRadio, set axis of rotation
      private void yRadio_Checked( object sender, RoutedEventArgs e )
      {
         rotation.Axis = new Vector3D( 0, 1, 0 ); // set rotation axis
         camera.Position = new Point3D( 6, 0, 0 ); // set camera position
      } // end method yRadio_Checked

      // when user selects zRadio, set axis of rotation
      private void zRadio_Checked( object sender, RoutedEventArgs e )
      {
         rotation.Axis = new Vector3D( 0, 0, 1 ); // set rotation axis
         camera.Position = new Point3D( 6, 0, 1 ); // set camera position
      } // end method zRadio_Checked
   } // end class Application3DWindow
} // end namespace Application3D