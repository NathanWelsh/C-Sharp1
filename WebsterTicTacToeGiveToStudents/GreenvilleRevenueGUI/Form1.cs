using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    //************************************************
    // Written by: Nathan Welsh
    // For: COP 2360 C# Programming I
    // Where: FSW Computer Science Program www.fsw.edu
    // Original Author and Professor: Dr. Roger Webster
    // TIC TAC TOE Game
    // GiveToStudents
    // ***********************************************
    public partial class Form1 : Form
    {

        Boolean GameOver = false;
        String filenameback = "";
        Image tictactoebackground = null;
        String filenameXO = "";
        Image tictactoeX = null;
        Image tictactoeO = null;
        Image tictactoeblurbackground = null;

        const int SIZE = 9;
        const int ROW_SIZE = 3;
        const int COL_SIZE = 3;
        char[,] gameGrid = new char[ROW_SIZE, COL_SIZE];

        Boolean playersTurn = true;
        Boolean isDone = false;
        Boolean PlayerWon = true;
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(800, 600);//keep this size window

            filenameback = Directory.GetCurrentDirectory() + "\\cards\\wwwtictactoe.png";
            tictactoebackground = Image.FromFile(filenameback);
            filenameXO = Directory.GetCurrentDirectory() + "\\cards\\tictactoeX.png";
            tictactoeX = Image.FromFile(filenameXO);
            filenameXO = Directory.GetCurrentDirectory() + "\\cards\\tictactoeO.png";
            tictactoeO = Image.FromFile(filenameXO);
            filenameXO = Directory.GetCurrentDirectory() + "\\cards\\tictactoeopenblur.png";
            tictactoeblurbackground = Image.FromFile(filenameXO);

            BigPurpleBucsButton();

        }

        private void Button1_Click(object sender, EventArgs e)
        {  
            BigPurpleBucsButton();
        }

        private void BigPurpleBucsButton()
        {
            InitGameGrid();
            InitGameGraphics();
            row0col0button.Enabled = true;
            row0col1button.Enabled = true;
            row0col2button.Enabled = true;
            row1col0button.Enabled = true;
            row1col1button.Enabled = true;
            row1col2button.Enabled = true;
            row2col0button.Enabled = true;
            row2col1button.Enabled = true;
            row2col2button.Enabled = true;
            playersTurn = true;
            PlayrsTurnlabel.Text = ("Players Turn");
            Msglabel.Text = ("Welcome to COP2360 Tic Tac Toe Game");
        }

        //--------------------------------------------
        // TIC TAC TOE CODE
        //--------------------------------------------




        //--------------------------------------------------
        // ALL THE BUTTON CLICKS CODE you modify this code
        //--------------------------------------------------

        private void button4_Click_1(object sender, EventArgs e)
        {
            int row = 0;
            int col = 0;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row0col0button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row0col0button.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            int col = 1;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row0col1button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row0col1button.Enabled = false;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int row = 0;
            int col = 2;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row0col2button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row0col2button.Enabled = false;
            }

        }

      

        private void button14_Click(object sender, EventArgs e)
        {
            int row = 1;
            int col = 0;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row1col0button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row1col0button.Enabled = false;
            }
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            int row = 1;
            int col = 1;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row1col1button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row1col1button.Enabled = false;
            }

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            int row = 1;
            int col = 2;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row1col2button.Enabled = false;
            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row1col2button.Enabled = false;
            }

        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            int row = 2;
            int col = 0;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row2col0button.Enabled = false;            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row2col0button.Enabled = false;            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int row = 2;
            int col = 1;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row2col1button.Enabled = false;            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row2col1button.Enabled = false;            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int row = 2;
            int col = 2;

            if (playersTurn)
            {
                SetGridGraphicsToX(row, col);
                PlayrsTurnlabel.Text = ("Opponents Turn");
                playersTurn = false;
                row2col2button.Enabled = false;            }
            else
            {
                SetGridGraphicsToO(row, col);
                PlayrsTurnlabel.Text = ("Players Turn");
                playersTurn = true;
                row2col2button.Enabled = false;            }

        }



        //--------------------------------------------
        // HELPER CODE HERE
        //--------------------------------------------

        //-------------------------------------------------------------
        // THIS RESETS ALL GRID CHARS TO START A NEW GAME
        //-------------------------------------------------------------
        public void InitGameGrid()
        {
            for (int row = 0; row < ROW_SIZE; row++)
            {
                for (int col = 0; col < COL_SIZE; col++)
                {
                    gameGrid[row, col] = 'N';
                }
            }

        }

        public void InitGameGraphics()
        {
            for (int row = 0; row < ROW_SIZE; row++)
            {
                for (int col = 0; col < COL_SIZE; col++)
                {
                    ResetGridGraphics(row, col);
                }
            }

        }

        public Boolean CheckForWinner()
        {
            Boolean isDone = false;
            int x;
            PlayerWon = true; // Assume it's true

            for (x = 0; x < 3; ++x) // Rows
            {
                if (!gameGrid[x, 0].Equals('N'))
                {
                    if (gameGrid[x, 0] == gameGrid[x, 1] && gameGrid[x, 0] == gameGrid[x, 2])
                    {
                        
                        if (playersTurn)
                        {
                            isDone = true;
                            Msglabel.Text = ("Congratulations You Win!");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                        else
                        {
                            isDone = true;
                            Msglabel.Text = ("Opponent Wins");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                    }
                }
            }
            for (x = 0; x < 3; ++x) // Columns
            {
                if (!gameGrid[0, x].Equals('N'))
                {
                    if (gameGrid[0, x] == gameGrid[1, x] && gameGrid[0, x] == gameGrid[2, x])
                    {
                        
                        if (playersTurn)
                        {
                            isDone = true;
                            Msglabel.Text = ("Congratulations You Win!");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                        else
                        {
                            isDone = true;
                            Msglabel.Text = ("Opponent Wins");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                    }

                }
            }
            for (x = 0; x < 3; ++ x) // Left to Right Hand Side Diagonal
            {
                if (!gameGrid[0, x].Equals('N'))
                {
                    if (gameGrid[0, x] == gameGrid[1, 1] && gameGrid[0, x] == gameGrid[2, 2] && gameGrid[0,0] != 'N')
                    {
                        
                        if (playersTurn)
                        {
                            isDone = true;
                            Msglabel.Text = ("Congratulations You Win!");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                        else
                        {
                            isDone = true;
                            Msglabel.Text = ("Opponent Wins");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                    }

                }
            }
            for (x = 0; x < 3; ++ x) // Right to Left Hand Side Diagonal
            {
                if (!gameGrid[0, x].Equals('N'))
                {
                    if (gameGrid[0, 2] == gameGrid[1, 1] && gameGrid[1, 1] == gameGrid[2, 0] && gameGrid[0, 2] != 'N')
                    {

                        if (playersTurn)
                        {
                            isDone = true;
                            Msglabel.Text = ("Congratulations You Win!");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                        else
                        {
                            isDone = true;
                            Msglabel.Text = ("Opponent Wins");
                            PlayrsTurnlabel.Text = ("Game Over");
                            StopTheGame();
                        }
                    }
                }
                
            }
            return true;
        }

        private void TieGame()
        {
            if (GameOver)
            {
                row0col0button.Enabled = true;
                row0col1button.Enabled = true;
                row0col2button.Enabled = true;
                row1col0button.Enabled = true;
                row1col1button.Enabled = true;
                row1col2button.Enabled = true;
                row2col0button.Enabled = true;
                row2col1button.Enabled = true;
                row2col2button.Enabled = true;
                Msglabel.Text = ("Welcome to COP2360 Tic Tac Toe Game");
            }
            else
            {
                row0col0button.Enabled = false;
                row0col1button.Enabled = false;
                row0col2button.Enabled = false;
                row1col0button.Enabled = false;
                row1col1button.Enabled = false;
                row1col2button.Enabled = false;
                row2col0button.Enabled = false;
                row2col1button.Enabled = false;
                row2col2button.Enabled = false;
                Msglabel.Text = ("Tie Game!");
                PlayrsTurnlabel.Text = ("Game Over");
            }
        }

        private void StopTheGame()
        {
            row0col0button.Enabled = false;
            row0col1button.Enabled = false;
            row0col2button.Enabled = false;
            row1col0button.Enabled = false;
            row1col1button.Enabled = false;
            row1col2button.Enabled = false;
            row2col0button.Enabled = false;
            row2col1button.Enabled = false;
            row2col2button.Enabled = false;
        }

        //-------------------------------------------------------------
        // THIS SETS ANY SPOT TO X WHEN THE USER CLICKS THE BUTTON
        //-------------------------------------------------------------
        private void SetGridGraphicsToX(int row, int col)
        {
            AddXorO(row, col, 'X');// this sets the data structure in gameGrid[,]
            switch (row)
            {
                //row is 0
                case 0:

                    switch (col)
                    {
                        case 0:
                            row0col0button.BackgroundImage = tictactoeX;
                            row0col0button.Refresh();
                            break;
                        case 1:
                            row0col1button.BackgroundImage = tictactoeX;
                            row0col1button.Refresh();
                            break;
                        case 2:
                            row0col2button.BackgroundImage = tictactoeX;
                            row0col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;
                //row is 1
                case 1:

                    switch (col)
                    {
                        case 0:
                            row1col0button.BackgroundImage = tictactoeX;
                            row1col0button.Refresh();
                            break;
                        case 1:
                            row1col1button.BackgroundImage = tictactoeX;
                            row1col1button.Refresh();
                            break;
                        case 2:
                            row1col2button.BackgroundImage = tictactoeX;
                            row1col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;

                //row is 2
                case 2:
                    switch (col)
                    {
                        case 0:
                            row2col0button.BackgroundImage = tictactoeX;
                            row2col0button.Refresh();
                            break;
                        case 1:
                            row2col1button.BackgroundImage = tictactoeX;
                            row2col1button.Refresh();
                            break;
                        case 2:
                            row2col2button.BackgroundImage = tictactoeX;
                            row2col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;
            }
        }

        //-------------------------------------------------------------
        // THIS SETS ANY SPOT TO O WHEN THE USER CLICKS THE BUTTON
        //-------------------------------------------------------------
        private void SetGridGraphicsToO(int row, int col)
        {
            AddXorO(row, col, 'O');// this sets the data structure in gameGrid[,]
            switch (row)
            {
                //row is 0
                case 0:

                    switch (col)
                    {
                        case 0:
                            row0col0button.BackgroundImage = tictactoeO;
                            row0col0button.Refresh();
                            break;
                        case 1:
                            row0col1button.BackgroundImage = tictactoeO;
                            row0col1button.Refresh();
                            break;
                        case 2:
                            row0col2button.BackgroundImage = tictactoeO;
                            row0col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;
                //row is 1
                case 1:

                    switch (col)
                    {
                        case 0:
                            row1col0button.BackgroundImage = tictactoeO;
                            row1col0button.Refresh();
                            break;
                        case 1:
                            row1col1button.BackgroundImage = tictactoeO;
                            row1col1button.Refresh();
                            break;
                        case 2:
                            row1col2button.BackgroundImage = tictactoeO;
                            row1col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;
                //row is 2
                case 2:
                    switch (col)
                    {
                        case 0:
                            row2col0button.BackgroundImage = tictactoeO;
                            row2col0button.Refresh();
                            break;
                        case 1:
                            row2col1button.BackgroundImage = tictactoeO;
                            row2col1button.Refresh();
                            break;
                        case 2:
                            row2col2button.BackgroundImage = tictactoeO;
                            row2col2button.Refresh();
                            break;
                    }
                    CheckForWinner();
                    break;
            }

        }

        //-------------------------------------------------------------
        // THIS SETS ALL SPOTS TO BLUR TO RESET THE GAME
        //-------------------------------------------------------------
        private void ResetGridGraphics(int row, int col)
        {
            switch (row)
            {
                //row is 0
                case 0:
                    switch (col)
                    {
                        case 0:
                            row0col0button.BackgroundImage = tictactoeblurbackground;
                            row0col0button.Refresh();
                            break;
                        case 1:
                            row0col1button.BackgroundImage = tictactoeblurbackground;
                            row0col1button.Refresh();
                            break;
                        case 2:
                            row0col2button.BackgroundImage = tictactoeblurbackground;
                            row0col2button.Refresh();
                            break;
                    }
                    break;
                //row is 1
                case 1:

                    switch (col)
                    {
                        case 0:
                            row1col0button.BackgroundImage = tictactoeblurbackground;
                            row1col0button.Refresh();
                            break;
                        case 1:
                            row1col1button.BackgroundImage = tictactoeblurbackground;
                            row1col1button.Refresh();
                            break;
                        case 2:
                            row1col2button.BackgroundImage = tictactoeblurbackground;
                            row1col2button.Refresh();
                            break;
                    }
                    break;
                    //row is 2
                case 2:
                    switch (col)
                    {
                        case 0:
                            row2col0button.BackgroundImage = tictactoeblurbackground;
                            row2col0button.Refresh();
                            break;
                        case 1:
                            row2col1button.BackgroundImage = tictactoeblurbackground;
                            row2col1button.Refresh();
                            break;
                        case 2:
                            row2col2button.BackgroundImage = tictactoeblurbackground;
                            row2col2button.Refresh();
                            break;
                    }
                    break;
            }
        }

        public void AddXorO(int row, int col, char isXorO)
        {
            gameGrid[row, col] = isXorO;// this sets the data grid for X O or N
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}



