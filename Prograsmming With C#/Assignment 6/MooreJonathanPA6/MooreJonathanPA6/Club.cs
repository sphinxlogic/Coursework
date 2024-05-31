//The Club Class which has a constructor an override of the ToString Method
//and the IFunding interface implementation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
    public class Club : Organizations,IFunding 
    {
        public string meetingplace;
        public string dayoftheweek;
        public string meetingtime;

        public Club()
        {
            name = "ACM";
            contactperson = "Dr. Ray";
            funding = 300.00M;
            meetingplace = "Darden 220";
            dayoftheweek = "Friday";
            meetingtime = "1:00pm";
        }


        public override string ToString()
        {
            return string.Format("Club:{0}\nContact Person:{1}\nFunding:{2}\nMeeting Place:{3}\nDay of the Week:{4}\nMeeting Time:{5}\n\n\n", name,contactperson,funding,meetingplace,dayoftheweek,meetingtime);
            
        }

        public void SetFundingAmt()
        {
            decimal amount = 300.00M;           
           
        }

            


       
    }
}
