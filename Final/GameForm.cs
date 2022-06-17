using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class GameForm : Form
    {
        //variable to determine x or o's turn
        int counter = 0;
        //variable to count slots/choices that are taken up
        int slotCount = 0;
        //instance of the playerScoreForm form
        playerScoreForm scoreForm = new playerScoreForm();
        //variable to determine if it's the computers turn or not
        bool computerTurn = false;
        //variable to determine if player vs player or player vs computer was chosen on the previous form
        bool playerVsPlayer;
        public GameForm()
        {
            InitializeComponent();
        }
        //method that requires 2 PictureBox's as parameters, one that has an x as the 
        //background image and the other that has an o
        private void showXorO(PictureBox x, PictureBox o)
        {
            //if the playerVsPlayer bool variable is true, make the changes necessary to eliminate the ai
            if (playerVsPlayer)
            {
                // if the counter variable is an even number and the spot has not been clicked yet, and x will appear
                if (counter % 2 == 0 && !x.Visible)
                {
                    x.Visible = true;
                    //add one to counter variable, so the computer's turn is next
                    counter++;
                    //add 1 to slotCount
                    slotCount++;

                }
                // if the counter variable is an odd number and the spot has not been clicked yet, and o will appear
                else if (counter % 2 != 0 && !o.Visible)
                {
                    o.Visible = true;
                    //add one to counter variable, so the players's turn is next
                    counter++;
                    //add 1 to slotCount
                    slotCount++;
                }
            }
            //if the playerVsPlayer bool variable is false, make the changes necessary to turn on the ai
            else if (!playerVsPlayer)
            {
                // if the counter variable is an even number and the spot has not been clicked yet, and x will appear
                if (counter % 2 == 0 && !x.Visible)
                {
                    x.Visible = true;
                    //add one to counter variable, so the computer's turn is next
                    counter++;
                    //add 1 to slotCount
                    slotCount++;
                    computerTurn = true;

                }
                // if the counter variable is an odd number and the spot has not been clicked yet, and o will appear
                else if (counter % 2 != 0 && !o.Visible)
                {
                    o.Visible = true;
                    //add one to counter variable, so the players's turn is next
                    counter++;
                    //add 1 to slotCount
                    slotCount++;
                    computerTurn = false;
                }
            }
        }
        private void decideActionFromComputerPick(PictureBox o, PictureBox x)
        {
            if (!playerVsPlayer && counter % 2 != 0 && slotCount != 9)
            {
                //generate a random number
                Random rand = new Random();
                int slot = rand.Next(1, 10);
                //if slot is 1
                if (slot == 1)
                {
                    // o and x = PB1X and PB1O
                    o = PB1O;
                    x = PB1X;
                }
                else if (slot == 2)
                {
                    o = PB2O;
                    x = PB2X;
                }
                else if (slot == 3)
                {
                    o = PB3O;
                    x = PB3X;
                }
                else if (slot == 4)
                {
                    o = PB4O;
                    x = PB4X;
                }
                else if (slot == 5)
                {
                    o = PB5O;
                    x = PB5X;
                }
                else if (slot == 6)
                {
                    o = PB6O;
                    x = PB6X;
                }
                else if (slot == 7)
                {
                    o = PB7O;
                    x = PB7X;
                }
                else if (slot == 8)
                {
                    o = PB8O;
                    x = PB8X;
                }
                else if(slot == 9)
                {
                    o = PB9O;
                    x = PB9X;
                }
                if (computerTurn)
                {
                    //if Picture Box corresponding to slot number are not visible
                    if (!o.Visible && !x.Visible)
                    {
                        //make o visible
                        o.Visible = true;
                        //add 1 to counter variable, so the player's turn is next
                        counter++;
                        //add 1 to slotCount if it is less than 9
                        if(slotCount < 9)
                        {
                            slotCount++;
                        }
                        //make computerTurn false
                        computerTurn = false;
                        //IF THE COMPUTER IS THE OPPONENT, ALL DETECTOWIN OPTIONS MUST BE PRESENT SINCE THE COMPUTER DOES NOT CLICK PICTUREBOX ITSELF
                        //if the first row has all o's, declare the winner
                        detectOWin(PB1O, PB2O, PB3O);
                        //if the second row has all o's, declare the winner
                        detectOWin(PB4O, PB5O, PB6O);
                        //if the third row has all o's, declare  the winner
                        detectOWin(PB7O, PB8O, PB9O);
                        //if the first column has all o's, declare the winner
                        detectOWin(PB1O, PB4O, PB7O);
                        //if the second column has all o's, declare the winner
                        detectOWin(PB2O, PB5O, PB8O);
                        //if the thrid column has all o's, declare the winner
                        detectOWin(PB3O, PB6O, PB9O);
                        //if the diagnol starting from the top left and ending in the bottom right has all o's declare
                        //the winner
                        detectOWin(PB1O, PB5O, PB9O);
                        //if the diagnol starting from the top right and ending in the bottom left has all o's,
                        //declare the winner
                        detectOWin(PB3O, PB5O, PB7O);
                    }
                    else
                    {
                        //if the slot is taken up, generate another number
                        decideActionFromComputerPick(PB4O, PB4X);
                    }
                }
            }
            
        }
        private void refreshGame()
        {
            //to replicate a new game starting, make all X and O picturebox's invisible
            PB1O.Visible = false;
            PB2O.Visible = false;
            PB3O.Visible = false;
            PB4O.Visible = false;
            PB5O.Visible = false;
            PB6O.Visible = false;
            PB7O.Visible = false;
            PB8O.Visible = false;
            PB9O.Visible = false;
            PB1X.Visible = false;
            PB2X.Visible = false;
            PB3X.Visible = false;
            PB4X.Visible = false;
            PB5X.Visible = false;
            PB6X.Visible = false;
            PB7X.Visible = false;
            PB8X.Visible = false;
            PB9X.Visible = false;
            //make all the showWin labels invisible
            column1Win.Visible = false;
            column2Win.Visible = false;
            column3Win.Visible = false;
            row1Win.Visible = false;
            row2Win.Visible = false;
            row3Win.Visible = false;
            pb1Win.Visible = false;
            pb3Win.Visible=false;
            pb5Win.Visible = false;
            pb7Win.Visible = false;
            pb9Win.Visible = false;
            //turn slotCount back to zero;
            slotCount = 0;
        }
        private void showWin(PictureBox pb1, PictureBox pb2, PictureBox pb3, Label label)
        {
            if (pb1.Visible && pb2.Visible && pb3.Visible)
            {
                label.Visible = true;
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
            }
        }
        private void showWinDiagonally(PictureBox pb1, PictureBox pb2, PictureBox pb3, Label label, Label label2, Label label3)
        {
            if (pb1.Visible && pb2.Visible && pb3.Visible)
            {
                label.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
            }
        }
        private void detectXWin(PictureBox p1x, PictureBox p2x, PictureBox p3x)
        {
            //if three x's line up horizontally, vertically, or diaganolly, declare the winner
            if (p1x.Visible && p2x.Visible && p3x.Visible)
            {
                showWin(PB1X, PB2X, PB3X, column1Win);
                showWin(PB4X, PB5X, PB6X, column2Win);
                showWin(PB7X, PB8X, PB9X, column3Win);
                showWin(PB1X, PB4X, PB7X, row1Win);
                showWin(PB2X, PB5X, PB8X, row2Win);
                showWin(PB3X, PB6X, PB9X, row3Win);
                showWinDiagonally(PB1X, PB5X, PB9X, pb1Win, pb5Win, pb9Win);
                showWinDiagonally(PB3X, PB5X, PB7X, pb3Win, pb5Win, pb7Win);
                //create a StreamWrite variable
                StreamWriter outputFile;
                //create file
                outputFile = File.AppendText("Player1WinLossRecord.txt");
                //display the winner
                MessageBox.Show("Batman is the winner!");
                //write 'win' to txt file
                outputFile.WriteLine("Win");
                //close file
                outputFile.Close();
                //refresh game in case users want to play again
                refreshGame();
                //open the next form and hide the current form
                this.Hide();
                scoreForm.ShowDialog();
                this.Show();
            } 
        }
        private void detectOWin(PictureBox p1o, PictureBox p2o, PictureBox p3o)
        {
            //if three o's line up horizontally, vertically, or diaganolly, declare the winner
            if (p1o.Visible && p2o.Visible && p3o.Visible)
            {
                showWin(PB1O, PB2O, PB3O, column1Win);
                showWin(PB4O, PB5O, PB6O, column2Win);
                showWin(PB7O, PB8O, PB9O, column3Win);
                showWin(PB1O, PB4O, PB7O, row1Win);
                showWin(PB2O, PB5O, PB8O, row2Win);
                showWin(PB3O, PB6O, PB9O, row3Win);
                showWinDiagonally(PB1O, PB5O, PB9O, pb1Win, pb5Win, pb9Win);
                showWinDiagonally(PB3O, PB5O, PB7O, pb3Win, pb5Win, pb7Win);
                //create a StreamWrite variable
                StreamWriter outputFile;
                //create file
                outputFile = File.AppendText("Player1WinLossRecord.txt");
                //display the winner
                MessageBox.Show("Joker is the winner!");
                //write 'loss' to txt file
                outputFile.WriteLine("Loss");
                //close file
                outputFile.Close();
                //refresh game in case users want to play again
                refreshGame();
                //open the next form and hide the current form
                this.Hide();
                scoreForm.ShowDialog();
                this.Show();
            }
        }
        private void detectTie()
        {
            if(slotCount == 9)
            {
                //create a StreamWrite variable
                StreamWriter outputFile;
                //create file
                outputFile = File.AppendText("Player1WinLossRecord.txt");
                MessageBox.Show("It's a tie!");
                //write 'tie' to txt file
                outputFile.WriteLine("Tie");
                //close the file
                outputFile.Close();
                //refresh game in case users want to play again
                refreshGame();
                //open the next form and hide the current form
                this.Hide();
                scoreForm.ShowDialog();
                this.Show();
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            showXorO(PB7X, PB7O);
            //if the third row has all x's, declare  the winner
            detectXWin(PB7X, PB8X, PB9X);
            //if the first column has all x's, declare the winner
            detectXWin(PB1X, PB4X, PB7X);
            //if the diagnol starting from the top right and ending in the bottom left has all x's,
            //declare the winner
            detectXWin(PB3X, PB5X, PB7X);


            //if the third row has all o's, declare  the winner
            detectOWin(PB7O, PB8O, PB9O);
            //if the first column has all o's, declare the winner
            detectOWin(PB1O, PB4O, PB7O);
            //if the diagnol starting from the top right and ending in the bottom left has all o's,
            //declare the winner
            detectOWin(PB3O, PB5O, PB7O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PB2_Click(object sender, EventArgs e)
        {
            showXorO(PB2X, PB2O);
            //if the first row has all x's, declare the winner
            detectXWin(PB1X, PB2X, PB3X);
            //if the second column has all x's, declare the winner
            detectXWin(PB2X, PB5X, PB8X);


            //if the first row has all o's, declare the winner
            detectOWin(PB1O, PB2O, PB3O);
            //if the second column has all o's, declare the winner
            detectOWin(PB2O, PB5O, PB8O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();

        }

        private void PB1Test_Click(object sender, EventArgs e)
        {
            showXorO(PB1X, PB1O);
            //if the first row has all x's, declare the winner
            detectXWin(PB1X, PB2X, PB3X);
            //if the first column has all x's, declare the winner
            detectXWin(PB1X, PB4X, PB7X);
            //if the diagnol starting from the top left and ending in the bottom right has all x's declare
            //the winner
            detectXWin(PB1X, PB5X, PB9X);

            //if the first row has all o's, declare the winner
            detectOWin(PB1O, PB2O, PB3O);
            //if the first column has all o's, declare the winner
            detectOWin(PB1O, PB4O, PB7O);
            //if the diagnol starting from the top left and ending in the bottom right has all o's declare
            //the winner
            detectOWin(PB1O, PB5O, PB9O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB3Test_Click(object sender, EventArgs e)
        {
            showXorO(PB3X, PB3O);
            //if the first row has all x's, declare the winner
            detectXWin(PB1X, PB2X, PB3X);
            //if the thrid column has all x's, declare the winner
            detectXWin(PB3X, PB6X, PB9X);
            //if the diagnol starting from the top right and ending in the bottom left has all x's,
            //declare the winner
            detectXWin(PB3X, PB5X, PB7X);

            //if the first row has all o's, declare the winner
            detectOWin(PB1O, PB2O, PB3O);
            //if the thrid column has all o's, declare the winner
            detectOWin(PB3O, PB6O, PB9O);
            //if the diagnol starting from the top right and ending in the bottom left has all o's,
            //declare the winner
            detectOWin(PB3O, PB5O, PB7O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB4Test_Click(object sender, EventArgs e)
        {
            showXorO(PB4X, PB4O);
            //if the second row has all x's, declare the winner
            detectXWin(PB4X, PB5X, PB6X);
            //if the first column has all x's, declare the winner
            detectXWin(PB1X, PB4X, PB7X);


            //if the second row has all o's, declare the winner
            detectOWin(PB4O, PB5O, PB6O);
            //if the first column has all o's, declare the winner
            detectOWin(PB1O, PB4O, PB7O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB6Test_Click(object sender, EventArgs e)
        {
            showXorO(PB6X, PB6O);
            //if the second row has all x's, declare the winner
            detectXWin(PB4X, PB5X, PB6X);
            //if the thrid column has all x's, declare the winner
            detectXWin(PB3X, PB6X, PB9X);


            //if the second row has all o's, declare the winner
            detectOWin(PB4O, PB5O, PB6O);
            //if the thrid column has all o's, declare the winner
            detectOWin(PB3O, PB6O, PB9O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB5Test_Click(object sender, EventArgs e)
        {
            showXorO(PB5X, PB5O);
            //if the second row has all x's, declare the winner
            detectXWin(PB4X, PB5X, PB6X);
            //if the second column has all x's, declare the winner
            detectXWin(PB2X, PB5X, PB8X);
            //if the diagnol starting from the top left and ending in the bottom right has all x's declare
            //the winner
            detectXWin(PB1X, PB5X, PB9X);
            //if the diagnol starting from the top right and ending in the bottom left has all x's,
            //declare the winner
            detectXWin(PB3X, PB5X, PB7X);

            //if the second row has all o's, declare the winner
            detectOWin(PB4O, PB5O, PB6O);
            //if the second column has all o's, declare the winner
            detectOWin(PB2O, PB5O, PB8O);
            //if the diagnol starting from the top left and ending in the bottom right has all o's declare
            //the winner
            detectOWin(PB1O, PB5O, PB9O);
            //if the diagnol starting from the top right and ending in the bottom left has all o's,
            //declare the winner
            detectOWin(PB3O, PB5O, PB7O);


            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB8Test_Click(object sender, EventArgs e)
        {
            showXorO(PB8X, PB8O);
            //if the third row has all x's, declare the winner
            detectXWin(PB7X, PB8X, PB9X);
            //if the second column has all x's, declare the winner
            detectXWin(PB2X, PB5X, PB8X);


            //if the third row has all o's, declare  the winner
            detectOWin(PB7O, PB8O, PB9O);
            //if the second column has all o's, declare the winner
            detectOWin(PB2O, PB5O, PB8O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();
        }

        private void PB9Test_Click(object sender, EventArgs e)
        {
            showXorO(PB9X, PB9O);
            //if the third row has all x's, declare the winner
            detectXWin(PB7X, PB8X, PB9X);
            //if the thrid column has all x's, declare the winner
            detectXWin(PB3X, PB6X, PB9X);
            //if the diagnol starting from the top left and ending in the bottom right has all x's declare
            //the winner
            detectXWin(PB1X, PB5X, PB9X);


            //if the third row has all o's, declare  the winner
            detectOWin(PB7O, PB8O, PB9O);
            //if the thrid column has all o's, declare the winner
            detectOWin(PB3O, PB6O, PB9O);
            //if the diagnol starting from the top left and ending in the bottom right has all o's declare
            //the winner
            detectOWin(PB1O, PB5O, PB9O);

            decideActionFromComputerPick(PB3O, PB3X);
            detectTie();

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //create a StreamWrite variable
            StreamWriter outputFile;
            //create file so that every time the programs opens, previous data from the file is erased.
            outputFile = File.CreateText("Player1WinLossRecord.txt");
            //close the file
            outputFile.Close();
            //open player1winlossrecord.txt file
            StreamReader reader = File.OpenText("PlayerCBDecision.txt");
            //scan whether pvp or pvc is written
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine() == "pvp.Checked")
                {
                    playerVsPlayer = true;
                }
                else if(reader.ReadLine() == "pvc.Checked")
                {
                    playerVsPlayer = false;
                }
            }
            reader.Close();
        }
    }
}
