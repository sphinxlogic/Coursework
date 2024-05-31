//Class for the Overnight Package Contains two Methods CalulateCost and An Override of the ToString Method.
//It also contains several Properties.
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Package
    {
        private string name;
        private string address;
        private string city;
        private string state;
        private int zip;
        private int weight;
        private int cost;

        private string sname;
        private string saddress;
        private string scity;
        private string sstate;
        private int szip;
        

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public int Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string SName
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }

        public string SAddress
        {
            get
            {
                return saddress;
            }
            set
            {
                saddress = value;
            }
        }

        public string SCity
        {
            get
            {
                return scity;
            }
            set
            {
                scity = value;
            }
        }
        public string SState
        {
            get
            {
                return sstate;
            }
            set
            {
                sstate = value;
            }
        }

        public int SZip
        {
            get
            {
                return szip;
            }
            set
            {
                szip = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

       

        public Package()
        {
            Name = "Jonathan Moore";
            Address = "21573 Old Dominion Rd";
            City = "Bristol";
            State = "VA";
            Zip = 24202;

            SName = "John Doe";
            SAddress = "1 College Ave";
            SCity = "Wise";
            SState = "VA";
            SZip = 24293;

            Weight = 96;
            Cost = 1;

       
        }

        public decimal CalculateCost()
        {
           
            Package pack = new Package();
            return(pack.Weight *= pack.Cost);           
          
        }

        public override string ToString()
        {
            return string.Format("Sender Information:\n{0}\n{1}\n{2}\n{3}\n{4}\n\nRecipient Information:\n{5}\n{6}\n{7}\n{8}\n{9}\n\nThe Total Price to ship the package via ground is {10} dollars.",
                Name, Address, City, State, Zip, SName, SAddress, SCity, SState, SZip,CalculateCost());
        }
            
    }
            
    }






    


