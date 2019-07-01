/*****************************
* Team Members: Kiranmayi Manukonda-(Z1827988), Gopala Sai Uppalapati-(Z1840615),Sai Kiran Vunnam-(Z1840993)
* Professor: Daniel Rogness
* Course: CSCI 504
******************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public partial class Funny2 : Form
    {
        //variable flag to check whether the form is open
        bool Open = false;
        public Funny2()
        {
            InitializeComponent();
            //InitializeComponent();
            using (StreamReader sr = new StreamReader("netflix.txt"))
            {
                //storing the line in line variable
                string line = sr.ReadLine();
                //reads the file till it is null
                while (line != null)
                {
                    //splits the string when - is found
                    string[] data = line.Split('-');
                    //adds the data to the chart
                    funnychart2.Series["netflix"].Points.AddXY(Convert.ToString(data[0]), Convert.ToString(data[1]));
                    //again reads another line
                    line = sr.ReadLine();
                }
            }
        }

        private void funny2_Load(object sender, EventArgs e)
        {

        }
        //this event is called when back button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Open = true;
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
        //this is called when the form is closed
        private void funny2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Open == false)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }
    }
}
