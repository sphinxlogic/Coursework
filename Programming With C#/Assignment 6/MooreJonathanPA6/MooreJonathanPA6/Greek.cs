//The Greek Class which has a constructor an override of the ToString Method
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class Greek : Organizations,IFunding 
    {
        public bool chartered;
        public string houseaddress;

        public Greek()
        {
            name = "Kappasigma";           
            contactperson = "John Doe";
            funding = 100.00M;
            chartered = true;
            houseaddress = "12548 Almond Dr.";
        }


        public override string ToString()
        {
            return string.Format("Greek:{0}\nContact Person:{1}\nFunding:{2}\nChartered:{3}\nHouse Address:{4}\n\n\n", name, contactperson, funding, chartered, houseaddress);
        }


        public void SetFundingAmt()
        {
            decimal amount = 500.00M;

        }

       
            
    }
}
