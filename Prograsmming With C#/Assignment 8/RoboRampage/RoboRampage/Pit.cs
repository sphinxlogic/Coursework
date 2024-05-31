using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RoboRampage
{
    class Pit
    {
        public int XValue { get; set; }
        public int YValue { get; set; }

        public Bitmap pitImage;


        public Pit(int x, int y, Bitmap image)
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

            pitImage = image;
        }
    }
}
