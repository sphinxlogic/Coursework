//Main entry point for the 
//RobotTest Application
//Written By Jonathan Moore

using System;
using System.Collections.Generic;
using System.Text;


namespace RobotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot rb = new Robot();
            
            Console.Write("****** Intilizing Robot Default Vaules ******\n");
            Console.Write("The Robot has: " + rb.NumberofLives + " Lives\n");
            Console.Write("The Robot has: " + rb.NumberofHitPoints + " Hit points\n");
            Console.Write("The Robots XValue is: " + rb.XValue + "\n");
            Console.Write("The Robots YValue is: " + rb.YValue + "\n");
            Console.Write("The Robots Orientation is: " + rb.Orientation + "\n");
            Console.Write("****** Calling Methods ******\n");
            Console.Write("The Robot Just Lost a Life and now has " + rb.ModNumLives(-1) + " Lives\n");
            Console.Write("The Robot Just Earned a Life and now has " + rb.ModNumLives(1) + " Lives\n");
            Console.Write(rb.ModNumLives(0) + "\n");
            Console.Write("The Robot Was Just Hit and Lost Some Points " + rb.ModHitPoints(-4) + "\n");
            Console.Write("The Robot Just Earned Some Health and Earned Some Hit Points " + rb.ModHitPoints(3) + "\n");
            Console.Write(rb.ModHitPoints(0) + "\n");

            Console.ReadLine();

          
        }
    }
}
