using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RoboRampage
{
    //Robot class, effectively as described in assignment2
    class robot
    {
        public int NumberofHitPoints { get; set; }
        public int NumberofLives { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public int Orientation { get; set; }

        public Bitmap roboImage;

        
        //implement robot registers

        public robot(int x, int y, Bitmap image)
        {
            if ((x < 1 || x > 12) || (y < 1 || y > 12))
            {
                XValue = 0;
                YValue = 0;
            }
            else
            {
                XValue = x;
                YValue = y;
            }
            NumberofLives = 3;
            NumberofHitPoints = 9;
            roboImage = image;
            Orientation = 0;
        }
        
        // this function modifies our hitpoints value by the amount passed to it
        public void ModHitPoints(int amount)
        {
            NumberofHitPoints += amount;
        }

        // this function modifies our life value by the amount passed to it
        public void ModNumLives(int amount)
        {
            NumberofLives += amount;
        }
    }

}
