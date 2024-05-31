using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboRampage
{
    public partial class Form1 : Form
    {
        private ArrayList gridTiles = new ArrayList(); // for tile images (useful for multiple images)
        private ArrayList robotImages = new ArrayList();  // for robot images (useful for multiple images)
        private int[,] board = new int[12, 12]; // board array
        private const int TILESIZE = 55;  //the size of the square tile image in pixels 
        private const int RBIMAGESIZE = 48; //the size of the square robot images in pixels

        robot rb1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add images to the appropriate ArrayLists.  Images are located at the top level of the project directory 
            //tree.  Note: this is 3 layers up from the executable that is created when the solution is compiled
            //(RoboRampage\bin\Debug)

            gridTiles.Add(Bitmap.FromFile(@"..\..\..\images\robotile.png"));  
            robotImages.Add(Bitmap.FromFile(@"..\..\..\images\robotpic1.png"));
            
            rb1 = new robot(5, 12, (Bitmap)robotImages[0]);  //create a new robot instance
            //NOTE:  You may want to design a more straightforward way to handle multiple robots

            Invalidate(); // Every time Invalidate is called the form's Paint event is called, thus refreshing the form
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObject = e.Graphics; // obtain graphics object
            graphicsObject.TranslateTransform(24, 24); // adjust origin
            
            //Use a loop structure to create the 12x12 grid
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    graphicsObject.DrawImage((Image)gridTiles[0], TILESIZE * column, TILESIZE * row, TILESIZE, TILESIZE);
                } // end for loop for columns
            }

            //Create a temporary bitmap so that we can rotate the robot image
            Bitmap returnBitmap = new Bitmap(RBIMAGESIZE, RBIMAGESIZE);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)RBIMAGESIZE / 2, (float)RBIMAGESIZE / 2);
            Bitmap rotatedbmp = returnBitmap;

            //Rotate the image for the robot based on the orientation of the robot
            switch (rb1.Orientation)
            {
                case 0:
                    g.RotateTransform(0);
                    g.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    g.DrawImage(rb1.roboImage, new Point(0, 0));
                    rotatedbmp = returnBitmap;
                    break;
                case 1:
                    g.RotateTransform(90);
                    g.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    g.DrawImage(rb1.roboImage, new Point(0, 0));
                    rotatedbmp = returnBitmap;
                    break;
                case 2:
                    g.RotateTransform(180);
                    g.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    g.DrawImage(rb1.roboImage, new Point(0, 0));
                    rotatedbmp = returnBitmap;
                    break;
                case 3:
                    g.RotateTransform(-90);
                    g.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    g.DrawImage(rb1.roboImage, new Point(0, 0));
                    rotatedbmp = returnBitmap;
                    break;
            }

            graphicsObject.DrawImage((Image)rotatedbmp, TILESIZE * (rb1.XValue-1) + 4, TILESIZE * (rb1.YValue-1) + 4, RBIMAGESIZE, RBIMAGESIZE);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            //Update the orientation of the robot, rotate left
            rb1.Orientation = rb1.Orientation - 1;
            if (rb1.Orientation == -1)
            {
                rb1.Orientation = 3;
            }
            
            // Every time Invalidate is called the form's Paint event is called, thus refreshing the form
            this.Invalidate();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            //Update the orientation of the robot, rotate right
            rb1.Orientation = rb1.Orientation + 1;
            if (rb1.Orientation == 4)
            {
                rb1.Orientation = 0;
            }
            
            // Every time Invalidate is called the form's Paint event is called, thus refreshing the form
            this.Invalidate();
        }

        private void btn_uturn_Click(object sender, EventArgs e)
        {
            //Update the orientation of the robot, turn 180 degrees
            if (rb1.Orientation == 0) { rb1.Orientation = 2; }
            else if (rb1.Orientation == 1) { rb1.Orientation = 3; }
            else if (rb1.Orientation == 2) { rb1.Orientation = 0; }
            else { rb1.Orientation = 1; }

            // Every time Invalidate is called the form's Paint event is called, thus refreshing the form
            this.Invalidate();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            //Update the xvalue or yvalue of the robot based on move distance and orientation
            int mvvalue = Convert.ToInt32(nmr_numMoves.Value);
            if (rb1.Orientation == 0) { rb1.YValue += -mvvalue; }
            else if (rb1.Orientation == 1) { rb1.XValue += mvvalue; }
            else if (rb1.Orientation == 2) { rb1.YValue += mvvalue; }
            else { rb1.XValue += -mvvalue; }
            
            // Every time Invalidate is called the form's Paint event is called, thus refreshing the form
            this.Invalidate();
        }
    }
}
