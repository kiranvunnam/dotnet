﻿/*****************************
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
using System.Windows.Forms.DataVisualization.Charting;


namespace Charts
{
    public partial class Chart1 : Form
    {
        //variable flag to check whether the form is open
        bool Open = false;
        public Chart1()
        {
            InitializeComponent();
           //reading the data file
              using (StreamReader sr = new StreamReader("WasteDivision.txt"))
              {
                //storing the line in line variable
                  string line = sr.ReadLine();
                //reads the file till it is null
                  while (line != null)
                  {
                    //splits the string when - is found
                      string[] data = line.Split('-');
                    areachart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    //adds the data to the chart
                    areachart.Series["waste"].Points.AddXY(Convert.ToString(data[0]), Convert.ToString(data[1]));
                    //again reads another line
                      line = sr.ReadLine();
                  }
              }
        }

        //this event is called when back button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Open = true;
            this.Hide(); //hides the form
            Form1 f = new Form1(); //opens the main form
            f.ShowDialog();
        }

        //this is called when the form is closed
        private void Chart1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Open == false)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}