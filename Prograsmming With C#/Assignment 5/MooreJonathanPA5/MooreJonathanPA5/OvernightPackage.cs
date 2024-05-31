//Class for the Overnight Package Contains two Methods CalulateCost and An Override of the ToString Method.
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class OvernightPackage : Package 
    {
        decimal overnight;
        

        public OvernightPackage()
        {
            overnight = 25;
           
        }

        public decimal CalculateCost()
        {
            Package pack = new Package();
            decimal total = pack.CalculateCost();           
            OvernightPackage over = new OvernightPackage();            
            return(over.overnight += total);

        }

        public override string ToString()
        {
            return string.Format("The Total Price to ship the package overnight is {0} dollars.", CalculateCost());
            
        }
            
       
    }
}
