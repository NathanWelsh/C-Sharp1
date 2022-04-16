using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using static System.Console;
//-------------------------------------------------
// Written By Dr. Roger Webster
// Modified By Nathan Welsh
// For: COP 2360 C# Computer Programming
// Where: FSW Computer Science Program www.fsw.edu
// Professor: Dr. Roger Webster
// When: FALL 2020
//--------------------------------------------------
namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        String[] States = new String[50];
        String[] Capitals = new String[50];
        String answer = "";
        int statenumber = 0;
        Random ranNumberGenerator;
        int TotalQs = 0;// use this to keep track of total qs
        int numcorrect = 0;// use this to keep track of num correct

        public Form1()
        {
            InitializeComponent();
            msglabel.Text = "";
            this.Size = new Size(600, 300);
            ranNumberGenerator = new Random();
            statenumber = ranNumberGenerator.Next(0, 49);
            LoadStates();
            label3.Text = States[statenumber];


            Instructionslabel.Text = "Please type in your answer and press Enter key. Press Button gives you the next question.";
        }

        public void LoadStates()
        {
            States[0] = "Alabama";
            Capitals[0] = "Montgomery";
            States[1] = "Alaska";
            Capitals[1] = "Juneau";
            States[2] = "Arizona";
            Capitals[2] = "Phoenix";
            States[3] = "Arkansas";
            Capitals[3] = "Little Rock";
            States[4] = "California";
            Capitals[4] = "Sacramento";
            States[5] = "Colorado";
            Capitals[5] = "Denver";
            States[6] = "Connecticut";
            Capitals[6] = "Hartford";
            States[7] = "Delaware";
            Capitals[7] = "Dover";
            States[8] = "Florida";
            Capitals[8] = "Tallahassee";
            States[9] = "Georgia";
            Capitals[9] = "Atlanta";
            States[10] = "Hawaii";
            Capitals[10] = "Honolulu";
            States[11] = "Idaho";
            Capitals[11] = "Boise";
            States[12] = "Illinois";
            Capitals[12] = "Springfield";
            States[13] = "Indiana";
            Capitals[13] = "Indianapolis";
            States[14] = "Iowa";
            Capitals[14] = "Des Moines";
            States[15] = "Kansas";
            Capitals[15] = "Topeka";
            States[16] = "Kentucky";
            Capitals[16] = "Frankfort";
            States[17] = "Louisiana";
            Capitals[17] = "Baton Rouge";
            States[18] = "Maine";
            Capitals[18] = "Augusta";
            States[19] = "Maryland";
            Capitals[19] = "Annapolis";
            States[20] = "Massachusetts";
            Capitals[20] = "Boston";
            States[21] = "Michigan";
            Capitals[21] = "Lansing";
            States[22] = "Minnesota";
            Capitals[22] = "St. Paul";
            States[23] = "Mississippi";
            Capitals[23] = "Jackson";
            States[24] = "Missouri";
            Capitals[24] = "Jefferson City";
            States[25] = "Montana";
            Capitals[25] = "Helena";
            States[26] = "Nebraska";
            Capitals[26] = "Lincoln";
            States[27] = "Nevada";
            Capitals[27] = "Carson City";
            States[28] = "New Hampshire";
            Capitals[28] = "Concord";
            States[29] = "New Jersey";
            Capitals[29] = "Trenton";
            States[30] = "New Mexico";
            Capitals[30] = "Santa Fe";
            States[31] = "New York";
            Capitals[31] = "Albany";
            States[32] = "North Carolina";
            Capitals[32] = "Raleigh";
            States[33] = "North Dakota";
            Capitals[33] = "Bismarck";
            States[34] = "Ohio";
            Capitals[34] = "Columbus";
            States[35] = "Oklahoma";
            Capitals[35] = "Oklahoma City";
            States[36] = "Oregon";
            Capitals[36] = "Salem";
            States[37] = "Pennsylvania";
            Capitals[37] = "Harrisburg";
            States[38] = "Rhode Island";
            Capitals[38] = "Providence";
            States[39] = "South Carolina";
            Capitals[39] = "Columbia";
            States[40] = "South Dakota";
            Capitals[40] = "Pierre";
            States[41] = "Tennessee";
            Capitals[41] = "Nashville";
            States[42] = "Texas";
            Capitals[42] = "Austin";
            States[43] = "Utah";
            Capitals[43] = "Salt Lake City";
            States[44] = "Vermont";
            Capitals[44] = "Montpelier";
            States[45] = "Virginia";
            Capitals[45] = "Richmond";
            States[46] = "Washington";
            Capitals[46] = "Olympia";
            States[47] = "West Virginia";
            Capitals[47] = "Charleston";
            States[48] = "Wisconsin";
            Capitals[48] = "Madison";
            States[49] = "Wyoming";
            Capitals[49] = "Cheyenne";
        }
        //----------------------------------------------
        // this is the get next Q button
        //----------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            statenumber = ranNumberGenerator.Next(0, 49);
            label3.Text = States[statenumber];
            TotalQs += 1;
            msglabel.Text = "";
        }

        //--------------------------------------------------------------------
        // this is the cheat button, please put correct answer in the label
        //--------------------------------------------------------------------
        private void Button2_Click(object sender, EventArgs e)
        {
            CapitalAnswertextBox.Text = ("") + Capitals[statenumber];

        }
        //-----------------------------------------------------------------------
        // this is the text event handler, when the user presses enter this runs
        //-----------------------------------------------------------------------
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //here is where you put your code
                //MessageBox.Show("The answer is: " + CapitalAnswertextBox.Text);
                answer = CapitalAnswertextBox.Text;

                if (CapitalAnswertextBox.Text.ToLower() == Capitals[statenumber].ToLower())
                {
                    numcorrect++;
                    TotalQs++;
                    msglabel.Text = ("You are Correct! ") + Capitals[statenumber];
                }
                else
                {
                    msglabel.Text = ("You are not Correct! ") + Capitals[statenumber] + " Is the capital of " + States[statenumber];
                }
                setScore();
                CapitalAnswertextBox.Text = "";
            }
        }
        public void setScore()
        {
            numcorrectlabel.Text = ("Number Correct: ") + numcorrect.ToString() + (" Out of ") + TotalQs.ToString() + " Total Questions";

        }
    }
}

