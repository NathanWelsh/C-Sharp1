using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------------
// Written By Nathan Welsh
// COP2360 C# Programming I
// www.fsw.edu
// Dr. Roger Webster - Professor
//----------------------------------------
namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        Random ranNumberGenerator;

        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;

        int lottonum1 = 0;
        int lottonum2 = 0;
        int lottonum3 = 0;
        int lottonum4 = 0;
        int lottonum5 = 0;
        int lottonum6 = 0;

        int totalwinnings = 0;

        public Form1()
        {
            InitializeComponent();
            //preset the numbers!!!
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "3";
            textBox4.Text = "4";
            textBox5.Text = "5";
            textBox6.Text = "6";
            ranNumberGenerator = new Random();
            label6.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this is the main button


            getNewData();

            setUpLotteryNumbers();

            check_forDuplicates();

            int nummatches = check_for_Winnings();

            NumberOfMatches();

            NumberOfWinnings();

        }

        private void setUpLotteryNumbers()
        {

            lottonum1 = check_forDuplicates();
            outputLabel1.Text = Convert.ToString(lottonum1);

            lottonum2 = check_forDuplicates();
            outputLabel2.Text = Convert.ToString(lottonum2);

            lottonum3 = check_forDuplicates();
            outputLabel3.Text = Convert.ToString(lottonum3);

            lottonum4 = check_forDuplicates();
            outputLabel4.Text = Convert.ToString(lottonum4);

            lottonum5 = check_forDuplicates();
            outputlabel5.Text = Convert.ToString(lottonum5);

            lottonum6 = check_forDuplicates();
            outputlabel6.Text = Convert.ToString(lottonum6);


        }


        private void getNewData()
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);
            num4 = Convert.ToInt32(textBox4.Text);
            num5 = Convert.ToInt32(textBox5.Text);
            num6 = Convert.ToInt32(textBox6.Text);


        }

        private int check_forDuplicates()
        {
            int randomNumber = 0;

            Boolean duplicates = true;

            while (duplicates)
            {
                duplicates = false;
                randomNumber = ranNumberGenerator.Next(1, 54);
                if (randomNumber == lottonum1)
                    duplicates = true;
                if (randomNumber == lottonum2)
                    duplicates = true;
                if (randomNumber == lottonum3)
                    duplicates = true;
                if (randomNumber == lottonum4)
                    duplicates = true;
                if (randomNumber == lottonum5)
                    duplicates = true;
                if (randomNumber == lottonum6)
                    duplicates = true;
            }
            return randomNumber;
        }

        private int check_for_Winnings()
        {
            int nummatches = 0;

            if (lottonum1 == num1 || lottonum1 == num2 || lottonum1 == num3 || lottonum1 == num4 || lottonum1 == num5 || lottonum1 == num6)
                nummatches++;
            if (lottonum2 == num1 || lottonum2 == num2 || lottonum2 == num3 || lottonum2 == num4 || lottonum2 == num5 || lottonum2 == num6)
                nummatches++;
            if (lottonum3 == num1 || lottonum3 == num2 || lottonum3 == num3 || lottonum3 == num4 || lottonum3 == num5 || lottonum3 == num6)
                nummatches++;
            if (lottonum4 == num1 || lottonum4 == num2 || lottonum4 == num3 || lottonum4 == num4 || lottonum4 == num5 || lottonum4 == num6)
                nummatches++;
            if (lottonum5 == num1 || lottonum5 == num2 || lottonum5 == num3 || lottonum5 == num4 || lottonum5 == num5 || lottonum5 == num6)
                nummatches++;
            if (lottonum6 == num1 || lottonum6 == num2 || lottonum6 == num3 || lottonum6 == num4 || lottonum6 == num5 || lottonum6 == num6)
                nummatches++;




            return nummatches;
        }

        private void NumberOfMatches()
        {
            int nummatches = check_for_Winnings();


            if (nummatches == 0)
                label5.Text = ("The Number of Matches is 0");

            if (nummatches == 1)
                label5.Text = ("The Number of Matches is 1");

            if (nummatches == 2)
                label5.Text = ("The Number of Matches is 2");

            if (nummatches == 3)
                label5.Text = ("The Number of Matches is 3");

            if (nummatches == 4)
                label5.Text = ("The Number of Matches is 4");

            if (nummatches == 5)
                label5.Text = ("The Number of Matches is 5");

            if (nummatches == 6)
                label5.Text = ("The Number of Matches is 6");

        }

        private void NumberOfWinnings()
        {

            int nummatches = check_for_Winnings();

            if (nummatches == 0)
                label6.Text = ("You Lost!");

            if (nummatches == 1)
                label6.Text = ("You Lost!");

            if (nummatches == 2)
                label6.Text = ("You Win a Free Ticket!");

            if (nummatches == 3)
                label6.Text = ("You Win $25!");

            if (nummatches == 4)
                label6.Text = ("You Win $300");

            if (nummatches == 5)
                label6.Text = ("You Win $13,000");

            if (nummatches == 6)
                label6.Text = ("You Win $5,000,000");
        }
    }
}

