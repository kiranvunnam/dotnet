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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Button click function which redirects to chart 1(Area chart)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chart1 ch1 = new Chart1();
            ch1.ShowDialog();
            this.Close();
        }
        //Button click function which redirects to chart 2(Pyramid chart)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chart2 ch2 = new Chart2();
            ch2.ShowDialog();
            this.Close();
        }
        //Button click function which redirects to chart 3(column chart)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            chart3 ch3 = new chart3();
            ch3.ShowDialog();
            this.Close();
        }
        //Button click function which redirects to chart 4(Doughnut chart)
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            chart4 ch4 = new chart4();
            ch4.ShowDialog();
        //    this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        //    this.Close();
        }
        //Button click function which redirects to funnychart 1
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funny f5 = new Funny();
            f5.ShowDialog();
        //    this.Close();
        }
        //Button click function which redirects to funnychart 2
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funny2 f6 = new Funny2();
            f6.ShowDialog();
        //    this.Close();
        }
    }
}
