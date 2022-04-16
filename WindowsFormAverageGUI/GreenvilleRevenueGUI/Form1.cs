using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    //----------------------------------------
    // Written By Dr. Roger Webster
    // Written By Nathan Welsh
    // COP2360 C# Programming I
    // www.fsw.edu
    // FALL 2020
    //----------------------------------------
    public partial class Form1 : Form
    {
        const int maxint = (int.MaxValue);
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        int high = -maxint;
        int low = maxint;
        int sum = 0;
        double average = 0;
      
        public Form1()
        {
            InitializeComponent();
            
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "3";
            textBox4.Text = "4";
            textBox5.Text = "5";


            getNewData();
        }

        private void clearform()
        {
            label3.Text = "The Average here";
            label4.Text = "The Sum here";
            label6.Text = "The Highest Number here";
            label9.Text = "The Lowest Number here";


        }
        private void getNewData()
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);
            num4 = Convert.ToInt32(textBox4.Text);
            num5 = Convert.ToInt32(textBox5.Text);
            sum = num1 + num2 + num3 + num4 + num5;
            average = (sum) / 5.0;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clearform();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clearform();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            clearform();
        }

        private void DisplayHigh_Click(object sender, EventArgs e)
        {
            getNewData();

            high = num1;
            if (num2 > high)
                high = num2;
            if (num3 > high)
                high = num3;
            if (num4 > high)
                high = num4;
            if (num5 > high)
                high = num5;
            label6.Text = String.Format("The Highest Number is {0}", high);
        }

        private void DisplayLow_Click(object sender, EventArgs e)
        {
            getNewData();

            low = num1;
            if (num2 < low)
                low = num2;
            if (num3 < low)
                low = num3;
            if (num4 < low)
                low = num4;
            if (num5 < low)
                low = num5;
            label9.Text = String.Format("The Lowest Number is {0}", low);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            clearform();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            clearform();
        }

        private void DisplayAverage_Click(object sender, EventArgs e)
        {
            getNewData();
            label3.Text = String.Format("The Average is {0}", average);
        }

        private void DisplaySum_Click(object sender, EventArgs e)
        {
            getNewData();
            label4.Text = String.Format("The Sum is {0}", sum);
        }
    }
}
