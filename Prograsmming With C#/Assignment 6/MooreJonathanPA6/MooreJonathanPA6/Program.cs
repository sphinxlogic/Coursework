//The main entry point for the Program

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Club acm = new Club();
            Greek kappasigma = new Greek();
            Intramural flagfootball = new Intramural();
            object[] array = { acm, kappasigma, flagfootball };

            foreach (object org in array)
            {
                Console.WriteLine(org.ToString());
            }
            Console.ReadLine();
        }
    }
}
