// Fig. 24.4: WeatherViewer.xaml.cs
// WeatherViewer displays day-by-day weather data (code-behind).
using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace WeatherViewer
{
   public partial class WeatherViewerPage : UserControl
   {
      // object to invoke the web service
      private WebClient weatherService = new WebClient();

      // constructor
      public WeatherViewerPage()
      {
         InitializeComponent();

         weatherService.DownloadStringCompleted += 
            new DownloadStringCompletedEventHandler( 
            weatherService_DownloadStringCompleted );
      } // end constructor

      // when user clicks submit button, invoke web service
      private void submitButton_Click( object sender, RoutedEventArgs e )
      {
         string zipcode = inputTextBox.Text; // get zipcode
         this.Cursor = Cursors.Wait; // wait cursor

         // webserviceX.net's WeatherForcast web service URL 
         string forecastURL = "http://www.webservicex.net/" + 
            "WeatherForecast.asmx/GetWeatherByZipCode?ZipCode=" + 
            zipcode;

         // asynchronously invoke the web service
         weatherService.DownloadStringAsync( new Uri( forecastURL ) );
      } // end method submitButton_Click

      // when download is complete for web service result
      private void weatherService_DownloadStringCompleted( object sender, 
         DownloadStringCompletedEventArgs e )
      {
         if ( e.Error == null && e.Result.Contains( "Day" ) )
            DisplayWeatherForecast( e.Result );

         this.Cursor = Cursors.Arrow; // arrow cursor
      } // end method weatherService_DownloadStringCompleted

      // display the received weather data
      private void DisplayWeatherForecast( string xmlData )
      {
         // parse the XML data for use with LINQ
         XDocument weatherXML = XDocument.Parse( xmlData );

         XNamespace weatherNamespace = 
            XNamespace.Get( "http://www.webservicex.net" );

         // convert XML into WeatherData objects using XML literals
         var weatherInformation =
             from item in weatherXML.Descendants( 
                weatherNamespace + "WeatherData" )
             where !item.IsEmpty
             select new WeatherData()
             {
                DayOfWeek = item.Element( 
                   weatherNamespace + "Day" ).Value,
                WeatherImage = item.Element( 
                   weatherNamespace + "WeatherImage" ).Value,
                HighFahrenheit = item.Element( 
                   weatherNamespace + "MaxTemperatureF" ).Value,
                LowFahrenheit = item.Element( 
                   weatherNamespace + "MinTemperatureF" ).Value,
                HighCelsius = item.Element( 
                   weatherNamespace + "MaxTemperatureC" ).Value,
                LowCelsius = item.Element( 
                   weatherNamespace + "MinTemperatureC" ).Value
             };

         // bind forecastList.ItemSource to the weatherInformation
         forecastList.ItemsSource = weatherInformation;
      } // end method DisplayWeatherForecast

      // displays the custom control
      private void forecastList_SelectionChanged( object sender, 
         SelectionChangedEventArgs e )
      {
         // specify the WeatherData object containing the details
         if ( forecastList.SelectedItem != null )
            completeDetails.DataContext = forecastList.SelectedItem;

         // show the complete weather details
         completeDetails.Visibility = Visibility.Visible;
      } // end method forecastList_SelectionChanged

      // remove displayed weather information when input zip code changes
      private void inputTextBox_TextChanged( object sender, 
         TextChangedEventArgs e )
      {
         forecastList.ItemsSource = null;
      } // end method inputTextBox_TextChanged
   } // end class WeatherViewerPage
} // end namespace WeatherViewer

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