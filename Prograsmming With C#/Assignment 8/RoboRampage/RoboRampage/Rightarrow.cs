using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RoboRampage
{
    class Rightarrow
    {
        public int XValue { get; set; }
        public int YValue { get; set; }

        public Bitmap rArrowImage;


        public Rightarrow(int x, int y, Bitmap image)
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

            rArrowImage = image;
        }
    }
}
