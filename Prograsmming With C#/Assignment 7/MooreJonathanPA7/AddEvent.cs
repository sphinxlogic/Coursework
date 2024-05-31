using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;


namespace Date
{   

    public partial class SaveEvent : Form
    {
        public LinkedList<string> mylist = new LinkedList<string>();

        public SaveEvent()
        {
            InitializeComponent();
        }

         ~SaveEvent()
        {

        }

       public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Main main = new Main();
                main = (Main)Application.OpenForms["Main"];
                main.eventBox.Items.Add(descript.Text + " " + main.daylabel.Text + " " + main.Monthlabel.Text + " " + main.Yearlabel.Text);
                mylist.AddFirst(descript.Text + " " + main.daylabel.Text + " " + main.Monthlabel.Text + " " + main.Yearlabel.Text);


                

            }

            catch
            {

            }                           
            
        }

       private void SaveEvent_FormClosed(object sender, FormClosedEventArgs e)
       {
           try
           {
               descript.Clear();
           }

           catch
           {

           }

       }

   }
}
