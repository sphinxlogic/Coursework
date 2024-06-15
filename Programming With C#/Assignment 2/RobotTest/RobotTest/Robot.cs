//Robot Class 
//Written by Jonathan Moore
//Creates six automatic properties
//and two methods


using System;
using System.Collections.Generic;
using System.Text;


    public class Robot
    {
        public int NumberofLives { get; set; }
        public int NumberofHitPoints { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public string Orientation { get; set; }
        public string CommandRegister { get; set; }

        public Robot()
        {
            int X = 5;
            int Y = 5;
            XValue = 6;
            YValue = 8;
            NumberofLives = 3;
            NumberofHitPoints = 10;
            Orientation = "up";

        }

        public int ModHitPoints(int a)
        {
            if (a < 0)
            {
                Robot robot = new Robot();
                return a + robot.NumberofHitPoints;
                
            }
            else if (a >= 1)
            {
                Robot robot = new Robot();
                return a + robot.NumberofHitPoints;
            }

            else if (a == 0)
            {
                Robot robot = new Robot();
                Console.Write("The Robot Was Not Hit ");
                return a + robot.NumberofHitPoints;
            }

            return 0;

        }

        public int ModNumLives(int b)
        {
            if (b < 0)
            {

                Robot robot = new Robot();
                return b + robot.NumberofLives;

            }   
            
            else if (b >= 1)
            {
                Robot robot = new Robot();
                return b + robot.NumberofLives;
                
            }

            else if (b == 0)
            {
                Robot robot = new Robot();
                Console.Write("The Robot Did Not Lose a Life ");
                return b + robot.NumberofLives;
            }
           
            
            
            return 0;            

        }

    }

