using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoboRampage
{
    public partial class Board : Form
    {
        private ArrayList gridTiles = new ArrayList();
        private int[,] board = new int[12, 12]; // board array
        private const int TILESIZE = 55;
        private const int PTIMAGESIZE = 48;
        private const int ARIMAGESIZE = 48;
        private const int RBIMAGESIZE = 48;

        #region Robots

        robot rb1;
        robot rb2;
        robot rb3;
        robot rb4;

        #endregion


        #region Pits
        Pit pit1;
        Pit pit2;
        Pit pit3;
        Pit pit4;
        Pit pit5;
        Pit pit6;
        Pit pit7;
        Pit pit8;
        Pit pit9;
        Pit pit10;
        Pit pit11;
        Pit pit12;
        #endregion

        #region Arrows
        Rightarrow rarrow1;
        Rightarrow rarrow2;
        Rightarrow rarrow3;
        Rightarrow rarrow4;
        Rightarrow rarrow5;
        Rightarrow rarrow6;

        #endregion

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            gridTiles.Add(Bitmap.FromFile(@"..\..\..\images\robotile.png"));
            gridTiles.Add(Bitmap.FromFile(@"..\..\..\images\pit.png"));
            gridTiles.Add(Bitmap.FromFile(@"..\..\..\images\right_arrow.png"));
            gridTiles.Add(Bitmap.FromFile(@"..\..\..\images\robotpic1.png"));

            rb1 = new robot(5, 12, (Bitmap)gridTiles[3]);
            rb2 = new robot(6, 12, (Bitmap)gridTiles[3]);
            rb3 = new robot(7, 12, (Bitmap)gridTiles[3]);
            rb4 = new robot(8, 12, (Bitmap)gridTiles[3]);

            pit1 = new Pit(3, 10, (Bitmap)gridTiles[1]);
            pit2 = new Pit(4, 10, (Bitmap)gridTiles[1]);
            pit3 = new Pit(3, 9, (Bitmap)gridTiles[1]);
            pit4 = new Pit(11, 9, (Bitmap)gridTiles[1]);
            pit5 = new Pit(10, 10, (Bitmap)gridTiles[1]);
            pit6 = new Pit(11, 10, (Bitmap)gridTiles[1]);
            pit7 = new Pit(3, 2, (Bitmap)gridTiles[1]);
            pit8 = new Pit(3, 3, (Bitmap)gridTiles[1]);
            pit9 = new Pit(4, 2, (Bitmap)gridTiles[1]);
            pit10 = new Pit(11, 2, (Bitmap)gridTiles[1]);
            pit11 = new Pit(10, 2, (Bitmap)gridTiles[1]);
            pit12 = new Pit(11, 3, (Bitmap)gridTiles[1]);


            rarrow1 = new Rightarrow(5, 3, (Bitmap)gridTiles[2]);
            rarrow2 = new Rightarrow(6, 3, (Bitmap)gridTiles[2]);
            rarrow3 = new Rightarrow(7, 3, (Bitmap)gridTiles[2]);

            
            Invalidate();

        }

        private void Board_Paint(object sender, PaintEventArgs e)
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

            Bitmap returnBitmap2 = new Bitmap(RBIMAGESIZE, RBIMAGESIZE);
            Graphics h = Graphics.FromImage(returnBitmap2);
            h.TranslateTransform((float)RBIMAGESIZE / 2, (float)RBIMAGESIZE / 2);
            Bitmap rotatedbmp2 = returnBitmap2;

            //Rotate the image for the robot based on the orientation of the robot
            switch (rb2.Orientation)
            {
                case 0:
                    h.RotateTransform(0);
                    h.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    h.DrawImage(rb2.roboImage, new Point(0, 0));
                    rotatedbmp2 = returnBitmap2;
                    break;
                case 1:
                    h.RotateTransform(90);
                    h.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    h.DrawImage(rb2.roboImage, new Point(0, 0));
                    rotatedbmp2 = returnBitmap2;
                    break;
                case 2:
                    h.RotateTransform(180);
                    h.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    h.DrawImage(rb2.roboImage, new Point(0, 0));
                    rotatedbmp2 = returnBitmap2;
                    break;
                case 3:
                    h.RotateTransform(-90);
                    h.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    h.DrawImage(rb2.roboImage, new Point(0, 0));
                    rotatedbmp2 = returnBitmap2;
                    break;
            }


            Bitmap returnBitmap3 = new Bitmap(RBIMAGESIZE, RBIMAGESIZE);
            Graphics i = Graphics.FromImage(returnBitmap3);
            i.TranslateTransform((float)RBIMAGESIZE / 2, (float)RBIMAGESIZE / 2);
            Bitmap rotatedbmp3 = returnBitmap3;
            //Rotate the image for the robot based on the orientation of the robot
            switch (rb3.Orientation)
            {
                case 0:
                    i.RotateTransform(0);
                    i.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    i.DrawImage(rb3.roboImage, new Point(0, 0));
                    rotatedbmp3 = returnBitmap3;
                    break;
                case 1:
                    i.RotateTransform(90);
                    i.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    i.DrawImage(rb3.roboImage, new Point(0, 0));
                    rotatedbmp3 = returnBitmap3;
                    break;
                case 2:
                    i.RotateTransform(180);
                    i.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    i.DrawImage(rb3.roboImage, new Point(0, 0));
                    rotatedbmp3 = returnBitmap3;
                    break;
                case 3:
                    i.RotateTransform(-90);
                    i.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    i.DrawImage(rb3.roboImage, new Point(0, 0));
                    rotatedbmp3 = returnBitmap3;
                    break;
            }

            Bitmap returnBitmap4 = new Bitmap(RBIMAGESIZE, RBIMAGESIZE);
            Graphics j = Graphics.FromImage(returnBitmap4);
            j.TranslateTransform((float)RBIMAGESIZE / 2, (float)RBIMAGESIZE / 2);
            Bitmap rotatedbmp4 = returnBitmap4;
            //Rotate the image for the robot based on the orientation of the robot
            switch (rb4.Orientation)
            {
                case 0:
                    j.RotateTransform(0);
                    j.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    j.DrawImage(rb4.roboImage, new Point(0, 0));
                    rotatedbmp4 = returnBitmap4;
                    break;
                case 1:
                    j.RotateTransform(90);
                    j.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    j.DrawImage(rb4.roboImage, new Point(0, 0));
                    rotatedbmp4 = returnBitmap4;
                    break;
                case 2:
                    j.RotateTransform(180);
                    j.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    j.DrawImage(rb4.roboImage, new Point(0, 0));
                    rotatedbmp4 = returnBitmap4;
                    break;
                case 3:
                    j.RotateTransform(-90);
                    j.TranslateTransform(-(float)RBIMAGESIZE / 2, -(float)RBIMAGESIZE / 2);
                    j.DrawImage(rb4.roboImage, new Point(0, 0));
                    rotatedbmp4 = returnBitmap4;
                    break;
            }

            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit1.XValue - 1) + 4, TILESIZE * (pit1.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit2.XValue - 1) + 4, TILESIZE * (pit2.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit3.XValue - 1) + 4, TILESIZE * (pit3.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit4.XValue - 1) + 4, TILESIZE * (pit4.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit5.XValue - 1) + 4, TILESIZE * (pit5.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit6.XValue - 1) + 4, TILESIZE * (pit6.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit7.XValue - 1) + 4, TILESIZE * (pit7.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit8.XValue - 1) + 4, TILESIZE * (pit8.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit9.XValue - 1) + 4, TILESIZE * (pit9.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit10.XValue - 1) + 4, TILESIZE * (pit10.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit11.XValue - 1) + 4, TILESIZE * (pit11.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[1], TILESIZE * (pit12.XValue - 1) + 4, TILESIZE * (pit12.YValue - 1) + 4, PTIMAGESIZE, PTIMAGESIZE);

            graphicsObject.DrawImage((Image)gridTiles[2], TILESIZE * (rarrow1.XValue - 1) + 4, TILESIZE * (rarrow1.YValue - 1) + 4, ARIMAGESIZE, ARIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[2], TILESIZE * (rarrow2.XValue - 1) + 4, TILESIZE * (rarrow2.YValue - 1) + 4, ARIMAGESIZE, ARIMAGESIZE);
            graphicsObject.DrawImage((Image)gridTiles[2], TILESIZE * (rarrow3.XValue - 1) + 4, TILESIZE * (rarrow3.YValue - 1) + 4, ARIMAGESIZE, ARIMAGESIZE);
            graphicsObject.DrawImage((Image)rotatedbmp, TILESIZE * (rb1.XValue - 1) + 4, TILESIZE * (rb1.YValue - 1) + 4, RBIMAGESIZE, RBIMAGESIZE);
            graphicsObject.DrawImage((Image)rotatedbmp2, TILESIZE * (rb2.XValue - 1) + 4, TILESIZE * (rb1.YValue - 1) + 4, RBIMAGESIZE, RBIMAGESIZE);
            graphicsObject.DrawImage((Image)rotatedbmp3, TILESIZE * (rb3.XValue - 1) + 4, TILESIZE * (rb1.YValue - 1) + 4, RBIMAGESIZE, RBIMAGESIZE);
            graphicsObject.DrawImage((Image)rotatedbmp4, TILESIZE * (rb4.XValue - 1) + 4, TILESIZE * (rb1.YValue - 1) + 4, RBIMAGESIZE, RBIMAGESIZE);



        }

        private void Send1_Click(object sender, EventArgs e)
        {
            if (rb1.XValue == 3 && rb1.YValue == 10)
            {
                rb1.NumberofLives = rb1.NumberofLives -1;
            }
            if (rb1.XValue == 4 && rb1.YValue == 10)
            {
                rb1.NumberofLives = rb1.NumberofLives - 1;
            }
            if (rb1.XValue == 3 && rb1.YValue == 9)
            {
                rb1.NumberofLives = rb1.NumberofLives - 1;
            }
            if (rb1.XValue == 11 && rb1.YValue == 9)
            {
                rb1.NumberofLives = rb1.NumberofLives - 1;
            }
            if (rb1.XValue == 11 && rb1.YValue == 9)
            {
                rb1.NumberofLives = rb1.NumberofLives - 1;
            }
            if (rb1.XValue == 10 && rb1.YValue == 10)
            {
                rb1.NumberofLives = rb1.NumberofLives - 1;
            }




        }

       

        
    }

        
        
    }

