using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Boolean DoGraphics = true;

        int[] num = new int[6];
        int[] lottonum = new int[6];

        int[] totalmatchwinnings = new int[6];
        int[] totalnummatches = new int[6];

        int totalwinnings = 0;
        int totalcosts = 0;


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
            checkBox1.Checked = true;
            DoGraphics = true;
            check_randomnums();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Flamingo Button

            Boolean NumbersOK = CheckUserLottoNumbers();
            if (!NumbersOK)
            {
                return;
            }

            doitall(DoGraphics, false);

            getNewData();
        }

        private void getNewData()
        {
            num[0] = Convert.ToInt32(textBox1.Text);
            num[1] = Convert.ToInt32(textBox2.Text);
            num[2] = Convert.ToInt32(textBox3.Text);
            num[3] = Convert.ToInt32(textBox4.Text);
            num[4] = Convert.ToInt32(textBox5.Text);
            num[5] = Convert.ToInt32(textBox6.Text);

        }

        private void setUpLotteryNumbers(Boolean Graphics)
        {

            for (int i = 0; i < 6; ++i)
            {
                lottonum[i] = 0;
            }

            for (int i = 0; i < 6; ++i)
            {
                lottonum[i] = check_forDuplicates();
            }

            if (Graphics)
            {
                sortallLottoNumbers();
            }
            totalcosts = totalcosts + 2;
        }



        private int check_forDuplicates()
        {
            int randomNumber = 0;

            Boolean duplicates = true;

            while (duplicates)
            {
                duplicates = false;
                randomNumber = ranNumberGenerator.Next(1, 54);

                for (int i = 0; i < lottonum.Length; ++i)
                {
                    if (randomNumber == lottonum[i])
                        duplicates = true;
                }

            }
            return randomNumber;
        }

        private int check_for_Winnings()
        {
            int nummatches = 0;

            for (int i = 0; i < lottonum.Length; ++i)
            {
                for (int numi = 0; numi < num.Length; ++numi)
                {

                    if (num[numi] == lottonum[i])
                    {
                        if (DoGraphics)
                        {
                            PaintMatches(numi, i);
                        }
                        nummatches++;
                    }
                }
            }
            return nummatches;
        }

        public void PaintMatches(int numi, int i)
        {
            PaintLottoNumbersYellow(i);
            PaintUserNumbersYellow(numi);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DoGraphics = true;
                checkBox1.Text = "Graphics ON";
            }
            else
            {
                DoGraphics = false;
                checkBox1.Text = "Graphics OFF";

            }
        }
        private void check_randomnums()
        {
            int[] allrannums = new int[55];
            for (int i = 0; i < 5300; i++)
            {
                int randomNumber = ranNumberGenerator.Next(1, 54);
                allrannums[randomNumber]++;
            }
            for (int i = 0; i < 25; i++) ;


        }

        public void displayGUInumbers(int totalwinnigs, double totalcosts, int matches, double count)
        {
            String mycount = count.ToString("N0", CultureInfo.InvariantCulture);
            label3.Text = "Count is:  " + mycount;
            label3.Refresh();

            label5.Text = String.Format("The Number of Matches is {0}", matches);
            label5.Refresh();

            double costmoney = totalcosts;
            String totalcost = costmoney.ToString("C0", CultureInfo.CurrentCulture);

            label4.Text = "Cost is:  " + totalcost;
            label4.Refresh();
            
            double money = totalwinnings;
            String totalwin = money.ToString("C0", CultureInfo.CurrentCulture);

            label7.Text = "Winnings is:  " + totalwin;
            label7.Refresh();

            switch (matches)
            {
                case 0:
                    label6.Text = "You did not win!";

                    break;

                case 1:
                    label6.Text = "You did not win!";

                    break;

                case 2:
                    label6.Text = "You Win a Free Ticket!  ";

                    break;

                case 3:
                    label6.Text = "You Win $25!";
                    break;

                case 4:
                    label6.Text = "You Win $300!";
                    break;

                case 5:
                    label6.Text = "You Win $13,000!";
                    break;

                case 6:

                    label6.Text = "You Win 5,000,000!";
                    break;
                default:
                    break;
            }
            label6.Refresh();

            double totalmatchwinningsdouble3 = totalmatchwinnings[3];
            String match3win = totalmatchwinningsdouble3.ToString("C0", CultureInfo.CurrentCulture);
            String mymatchcount3 = totalnummatches[3].ToString("N0", CultureInfo.InvariantCulture);
            label8.Text = "Matching 3 Tix  " + mymatchcount3 + " times -> Winnings: " + match3win;
            label8.Refresh();

            double totalmatchwinningsdouble4 = totalmatchwinnings[4];
            String mymatchcount4 = totalnummatches[4].ToString("N0", CultureInfo.InvariantCulture);

            String match4win = totalmatchwinningsdouble4.ToString("C0", CultureInfo.CurrentCulture);
            label9.Text = "Matching 4 Tix " + mymatchcount4 + " times -> Winnings: " + match4win;
            label9.Refresh();

            double totalmatchwinningsdouble5 = totalmatchwinnings[5];
            String mymatchcount5 = totalnummatches[5].ToString("N0", CultureInfo.InvariantCulture);

            String match5win = totalmatchwinningsdouble5.ToString("C0", CultureInfo.CurrentCulture);
            label10.Text = "Matching 5 Tix " + mymatchcount5 + " times -> Winnings: " + match5win;
            label10.Refresh();

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


        public void PaintUserNumbersYellow(int numi)
        {
            switch (numi)
            {
                case 0:
                    textBox1.BackColor = Color.Yellow;
                    break;
                case 1:
                    textBox2.BackColor = Color.Yellow;
                    break;
                case 2:
                    textBox3.BackColor = Color.Yellow;
                    break;
                case 3:
                    textBox4.BackColor = Color.Yellow;
                    break;
                case 4:
                    textBox5.BackColor = Color.Yellow;
                    break;
                case 5:
                    textBox6.BackColor = Color.Yellow;
                    break;
            }
        }

        public void PaintLottoNumbersYellow(int numi)
        {
            switch (numi)
            {
                case 0:
                    outputLabel1.BackColor = Color.Yellow;
                    break;
                case 1:
                    outputLabel2.BackColor = Color.Yellow;
                    break;
                case 2:
                    outputLabel3.BackColor = Color.Yellow;
                    break;
                case 3:
                    outputLabel4.BackColor = Color.Yellow;
                    break;
                case 4:
                    outputlabel5.BackColor = Color.Yellow;
                    break;
                case 5:
                    outputlabel6.BackColor = Color.Yellow;
                    break;
            }
        }

        public Boolean CheckUserLottoNumbers()
        {
            Boolean AllNumbersFlag = true;
            try
            {
                num[0] = Convert.ToInt32(textBox1.Text);
                num[1] = Convert.ToInt32(textBox2.Text);
                num[2] = Convert.ToInt32(textBox3.Text);
                num[3] = Convert.ToInt32(textBox4.Text);
                num[4] = Convert.ToInt32(textBox5.Text);
                num[5] = Convert.ToInt32(textBox6.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please type in a valid number between 1-53: ", "Error in User Lotto Numbers");
                AllNumbersFlag = false;
                return (AllNumbersFlag);
            }
            //-----------------------------------------
            //check for valid User Ticket numbers
            //-----------------------------------------
            for (int i = 0; i < 6; ++i)
            {
                if (num[i] > 53 || num[i] <= 0)
                {
                    MessageBox.Show("Please type in a valid number between 1-53:", "Error in User Lotto Numbers");
                    AllNumbersFlag = false;
                    return (AllNumbersFlag);
                }

            }
            //-----------------------------------------
            //check for duplicates User Ticket numbers
            //-----------------------------------------
            for (int i = 0; i < 6; ++i)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (num[i] == num[j])
                    {
                        MessageBox.Show("Duplicate Numbers - Please type in a valid number 1-53:", "Error in User Lotto Numbers");
                        AllNumbersFlag = false;
                        return (AllNumbersFlag);
                    }
                }
            }

            if (AllNumbersFlag)
            {
                sortallUserNumbers();
            }
            return (AllNumbersFlag);
        }

        private void ResetAllYellow()
        {
            for (int i = 0; i < 6; ++i)
            {
                switch (i)
                {
                    case 0:
                        textBox1.BackColor = Color.White;
                        outputLabel1.BackColor = Color.White;
                        break;
                    case 1:
                        textBox2.BackColor = Color.White;
                        outputLabel2.BackColor = Color.White;
                        break;
                    case 2:
                        textBox3.BackColor = Color.White;
                        outputLabel3.BackColor = Color.White;
                        break;
                    case 3:
                        textBox4.BackColor = Color.White;
                        outputLabel4.BackColor = Color.White;
                        break;
                    case 4:
                        textBox5.BackColor = Color.White;
                        outputlabel5.BackColor = Color.White;
                        break;
                    case 5:
                        textBox6.BackColor = Color.White;
                        outputlabel6.BackColor = Color.White;
                        break;
                }

            }
        }

        public void UpdateLottoGraphics()
        {
          try
            {
                ResetAllYellow();

                outputLabel1.Text = String.Format("{0}", lottonum[0]);
                outputLabel1.Refresh();

                outputLabel2.Text = String.Format("{0}", lottonum[1]);
                outputLabel2.Refresh();

                outputLabel3.Text = String.Format("{0}", lottonum[2]);
                outputLabel3.Refresh();

                outputLabel4.Text = String.Format("{0}", lottonum[3]);
                outputLabel4.Refresh();

                outputlabel5.Text = String.Format("{0}", lottonum[4]);
                outputlabel5.Refresh();

                outputlabel6.Text = String.Format("{0}", lottonum[5]);
                outputlabel6.Refresh();

                label6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in UpdateLottoGraphics " + ex.ToString());
            }
        }


        public void sortallUserNumbers()
        {
            Array.Sort(num);
            textBox1.Text = num[0].ToString();
            textBox1.Refresh();
            textBox2.Text = num[1].ToString();
            textBox2.Refresh();
            textBox3.Text = num[2].ToString();
            textBox3.Refresh();
            textBox4.Text = num[3].ToString();
            textBox4.Refresh();
            textBox5.Text = num[4].ToString();
            textBox5.Refresh();
            textBox6.Text = num[5].ToString();
            textBox6.Refresh();
        }

        public void sortallLottoNumbers()
        {
            Array.Sort(lottonum);
            if (DoGraphics)
            {
                UpdateLottoGraphics();
            }
        }

        public async void doitall(Boolean Graphics, Boolean lottonumnot6flag)
        {
            int matches = 0;
            double count = 0;

            for (int i = 0; i > 6; ++i)
            {
                totalmatchwinnings[i] = 0;
                totalnummatches[i] = 0;
            }
            totalwinnings = 0;
            totalcosts = 0;

            do
            {
                count++;
                setUpLotteryNumbers(Graphics);
                matches = check_for_Winnings();

                switch (matches)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        totalcosts = totalcosts - 2;
                        break;
                    case 3:
                        totalwinnings = totalwinnings + 25;
                        totalnummatches[matches]++;
                        totalmatchwinnings[matches] = totalmatchwinnings[matches] + 25;
                        break;
                    case 4:
                        totalwinnings = totalwinnings + 300;
                        totalnummatches[matches]++;
                        totalmatchwinnings[matches] = totalmatchwinnings[matches] + 300;
                        break;
                    case 5:
                        totalwinnings = totalwinnings + 13000;
                        totalnummatches[matches]++;
                        totalmatchwinnings[matches] = totalmatchwinnings[matches] + 13000;
                        break;
                    case 6:
                        lottonumnot6flag = false;
                        totalwinnings = totalwinnings + 5000000;
                        DoGraphics = true;
                        checkBox1.Checked = true;
                        sortallUserNumbers();
                        check_for_Winnings();
                        displayGUInumbers(totalwinnings, totalcosts, matches, count);

                        break;
                    default:
                        break;

                }

                if (Graphics)
                {
                    displayGUInumbers(totalwinnings, totalcosts, matches, count);
                    await Task.Delay(0);
                }
                else
                {
                    if (count % 400000 == 0)
                    {
                        displayGUInumbers(totalwinnings, totalcosts, matches, count);
                        label6.Text = "Runnning Loop...";
                        label6.Refresh();

                    }
                    await Task.Delay(0);
                }
            } while (lottonumnot6flag);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FL Lotto Button

            Boolean NumbersOK = CheckUserLottoNumbers();
            if (!NumbersOK)
            {
                return;
            }

            doitall(DoGraphics, true);
        }
    }
}

