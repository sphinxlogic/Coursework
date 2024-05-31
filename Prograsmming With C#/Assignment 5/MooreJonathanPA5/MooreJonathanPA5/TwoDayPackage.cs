//Class For the Two Day Package. Contans two Methods CalculateCost and an override of the ToString Method.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class TwoDayPackage : Package
    {
        int flatfee;    
       

        public TwoDayPackage()
        {
            flatfee = 15;
        }

        public decimal CalculateCost()
        {
            TwoDayPackage two = new TwoDayPackage();
            Package pack = new Package();
            decimal total = pack.CalculateCost();
            
            return( total += two.flatfee);
            
        }

        public override string ToString()
        {
            return string.Format("The Total Price to ship the package in 2 Days is {0} dollars.", CalculateCost());
            
        }
             


    }
}
