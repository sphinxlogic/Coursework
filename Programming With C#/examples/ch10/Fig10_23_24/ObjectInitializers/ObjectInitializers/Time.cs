// Fig. 10.23: Time.cs
// Time class declaration maintains the time in 24-hour format.
public class Time
{
   private int hour; // 0 - 23
   private int minute; // 0 - 59
   private int second; // 0 - 59

   // set a new time value using universal time; ensure that 
   // the data remains consistent by setting invalid values to zero
   public void SetTime( int h, int m, int s )
   {
      Hour = h; // validate hour
      Minute = m; // validate minute
      Second = s; // validate second
   } // end method SetTime

   // convert to string in universal-time format (HH:MM:SS)
   public string ToUniversalString()
   {
      return string.Format( "{0:D2}:{1:D2}:{2:D2}",
         hour, minute, second );
   } // end method ToUniversalString

   // convert to string in standard-time format (H:MM:SS AM or PM)
   public override string ToString()
   {
      return string.Format( "{0}:{1:D2}:{2:D2} {3}",
         ( ( hour == 0 || hour == 12 ) ? 12 : hour % 12 ),
         minute, second, ( hour < 12 ? "AM" : "PM" ) );
   } // end method ToString

   // Properties for getting and setting
   // property that gets and sets the hour
   public int Hour
   {
      get
      {
         return hour;
      } // end get
      set
      {
         hour = ( ( value >= 0 && value < 24 ) ? value : 0 );
      } // end set
   } // end property Hour

   // property that gets and sets the minute
   public int Minute
   {
      get
      {
         return minute;
      } // end get
      set
      {
         minute = ( ( value >= 0 && value < 60 ) ? value : 0 );
      } // end set
   } // end property Minute

   // property that gets and sets the second
   public int Second
   {
      get
      {
         return second;
      } // end get
      set
      {
         second = ( ( value >= 0 && value < 60 ) ? value : 0 );
      } // end set
   } // end property Second
} // end class Time

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