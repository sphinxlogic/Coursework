using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Package pack = new Package();
            Console.WriteLine(pack.ToString());            

            TwoDayPackage pack2 = new TwoDayPackage();
            Console.WriteLine(pack2.ToString());

            OvernightPackage pack3 = new OvernightPackage();
            Console.WriteLine(pack3.ToString());

            Console.ReadLine();

        }
    }
}
