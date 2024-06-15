using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Date
{    

    public partial class Main : Form
    {
        public SaveEvent saveevent = new SaveEvent();
        
        public Main()
        {
            InitializeComponent();
            
        }

        ~Main()
        {

        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader Sr = new StreamReader("date.txt");
                String input;
                while ((input = Sr.ReadLine()) != null)
                {
                    eventBox.Items.Add(input);
                    saveevent.mylist.AddFirst(input);
                }
                Sr.Close();

                daylabel.Text = "11000";
                Monthlabel.Text = "11";
                Yearlabel.Text = "11111011001";
            }

            catch
            {


            }


        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DatePicker.Value = DateTime.Now;
            }

            catch
            {

            }
            
        }        

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DatePicker.MaxDate = new DateTime(2014, 3, 22);

                daylabel.Text = DatePicker.Value.ToString();
                Monthlabel.Text = DatePicker.Value.ToString();
                Yearlabel.Text = DatePicker.Value.ToString();

                #region Month Values

                if (DatePicker.Value.Month == 1)
                {
                    Monthlabel.Text = "1";

                }

                else if (DatePicker.Value.Month == 2)
                {
                    Monthlabel.Text = "10";

                }

                else if (DatePicker.Value.Month == 3)
                {
                    Monthlabel.Text = "11";

                }

                else if (DatePicker.Value.Month == 4)
                {
                    Monthlabel.Text = "100";

                }

                else if (DatePicker.Value.Month == 5)
                {
                    Monthlabel.Text = "101";

                }

                else if (DatePicker.Value.Month == 6)
                {
                    Monthlabel.Text = "110";

                }

                else if (DatePicker.Value.Month == 7)
                {
                    Monthlabel.Text = "111";

                }

                else if (DatePicker.Value.Month == 8)
                {
                    Monthlabel.Text = "1000";

                }

                else if (DatePicker.Value.Month == 9)
                {
                    Monthlabel.Text = "1001";

                }

                else if (DatePicker.Value.Month == 10)
                {
                    Monthlabel.Text = "1010";

                }

                else if (DatePicker.Value.Month == 11)
                {
                    Monthlabel.Text = "1011";

                }

                else if (DatePicker.Value.Month == 12)
                {
                    Monthlabel.Text = "1100";

                }

                #endregion

                #region Day Values

                if (DatePicker.Value.Day == 1)
                {
                    daylabel.Text = "1";
                }
                else if (DatePicker.Value.Day == 2)
                {
                    daylabel.Text = "10";

                }
                else if (DatePicker.Value.Day == 3)
                {
                    daylabel.Text = "11";

                }
                else if (DatePicker.Value.Day == 4)
                {
                    daylabel.Text = "100";

                }
                else if (DatePicker.Value.Day == 5)
                {
                    daylabel.Text = "101";

                }
                else if (DatePicker.Value.Day == 6)
                {
                    daylabel.Text = "110";

                }
                else if (DatePicker.Value.Day == 7)
                {
                    daylabel.Text = "111";

                }
                else if (DatePicker.Value.Day == 8)
                {
                    daylabel.Text = "1000";

                }
                else if (DatePicker.Value.Day == 9)
                {
                    daylabel.Text = "1001";

                }
                else if (DatePicker.Value.Day == 10)
                {
                    daylabel.Text = "1010";

                }
                else if (DatePicker.Value.Day == 11)
                {
                    daylabel.Text = "1011";

                }
                else if (DatePicker.Value.Day == 12)
                {
                    daylabel.Text = "1100";

                }
                else if (DatePicker.Value.Day == 13)
                {
                    daylabel.Text = "1101";

                }
                else if (DatePicker.Value.Day == 14)
                {
                    daylabel.Text = "1110";

                }
                else if (DatePicker.Value.Day == 15)
                {
                    daylabel.Text = "1111";

                }
                else if (DatePicker.Value.Day == 16)
                {
                    daylabel.Text = "10000";

                }
                else if (DatePicker.Value.Day == 17)
                {
                    daylabel.Text = "10001";

                }
                else if (DatePicker.Value.Day == 18)
                {
                    daylabel.Text = "10010";

                }
                else if (DatePicker.Value.Day == 19)
                {
                    daylabel.Text = "10011";

                }
                else if (DatePicker.Value.Day == 20)
                {
                    daylabel.Text = "10100";

                }
                else if (DatePicker.Value.Day == 21)
                {
                    daylabel.Text = "10101";

                }
                else if (DatePicker.Value.Day == 22)
                {
                    daylabel.Text = "10110";

                }
                else if (DatePicker.Value.Day == 23)
                {
                    daylabel.Text = "10111";

                }
                else if (DatePicker.Value.Day == 24)
                {
                    daylabel.Text = "11000";

                }
                else if (DatePicker.Value.Day == 25)
                {
                    daylabel.Text = "11001";

                }
                else if (DatePicker.Value.Day == 26)
                {
                    daylabel.Text = "11010";

                }
                else if (DatePicker.Value.Day == 27)
                {
                    daylabel.Text = "11011";

                }
                else if (DatePicker.Value.Day == 28)
                {
                    daylabel.Text = "11100";

                }
                else if (DatePicker.Value.Day == 29)
                {
                    daylabel.Text = "11101";

                }
                else if (DatePicker.Value.Day == 30)
                {
                    daylabel.Text = "11110";

                }
                else if (DatePicker.Value.Day == 31)
                {
                    daylabel.Text = "11111";

                }



                #endregion

                #region Year Values

                if (DatePicker.Value.Year == 2009)
                {
                    Yearlabel.Text = "11111011001";

                }

                else if(DatePicker.Value.Year == 2008)
                {
                    Yearlabel.Text = "11111011000";

                }

                else if(DatePicker.Value.Year == 2007)
                {
                    Yearlabel.Text = "11111011001";

                }

                else if(DatePicker.Value.Year == 2006)
                {
                    Yearlabel.Text = "111110110111";

                }

                else if(DatePicker.Value.Year == 2005)
                {

                    Yearlabel.Text = "11111010101";
                }

                else if (DatePicker.Value.Year == 2010)
                {

                    Yearlabel.Text = "11111011010";
                }

                else if (DatePicker.Value.Year == 2011)
                {

                    Yearlabel.Text = "11111011011";
                }

                else if (DatePicker.Value.Year == 2012)
                {

                    Yearlabel.Text = "11111011100";
                }

                else if (DatePicker.Value.Year == 2013)
                {

                    Yearlabel.Text = "11111011101";
                }

                else if (DatePicker.Value.Year == 2014)
                {

                    Yearlabel.Text = "11111011011";
                }
                #endregion 

                if (DatePicker.Value >= DatePicker.MaxDate)
                {
                    MessageBox.Show("You Cannot Select This Date");
                }

                saveevent.ShowDialog();
            }

            catch
            {

            }
           

        }

        private void eventBox_Click(object sender, EventArgs e)
        {
            try
            {
                LinkedListNode<string> search_it = saveevent.mylist.Find(eventBox.SelectedItem.ToString());
                if (search_it != null)
                {
                    
                    saveevent.descript.Text = search_it.Value;
                    saveevent.ShowDialog();
                }
            }

            catch
            {


            }
            
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string[] sArray = new string[saveevent.mylist.Count];
                saveevent.mylist.CopyTo(sArray, 0);

                StreamWriter sw = new StreamWriter("date.txt");

                foreach (string s in sArray)
                {

                    sw.Write(s + "\r\n");

                }

                sw.Close();
            }

            catch
            {

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                About about = new About();
                about.ShowDialog();
            }

            catch
            {

            }
        }

        
                
    }
}
