using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Final
{
    public partial class playerScoreForm : Form
    {
        //for sound if batman or joker wins
        SoundPlayer batmanWins = new SoundPlayer("ACBatmanWins.wav");
        SoundPlayer jokerWins = new SoundPlayer("JokerWins2.wav");
        //make a bool variable in case the exit button is hit
        bool exitApp = false;

        public playerScoreForm()
        {
            InitializeComponent();
        }

        private void playerScoreForm_Load(object sender, EventArgs e)
        {
            player1Lab.Text = "Batman:";
            player2Lab.Text = "Joker:";
            //variables to count wins and losses of player 1
            int winCount = 0;
            int lossCount = 0;
            //declare a streamReader variable
            StreamReader inputFile;
            inputFile = File.OpenText("Player1WinLossRecord.txt");
            //declare a list that will hold the file data
            List<string> player1Record = new List<string>();
            //read the file
            while (!inputFile.EndOfStream)
            {
                //add file's contents to list
                player1Record.Add(inputFile.ReadLine());
            }
            //iterate over the list's contents
            foreach(string s in player1Record)
            {
                //if the string reads win
                if(s == "Win")
                {
                    //add ACBatmanWins sound
                    
                    //add 1 to win count
                    winCount++;
                }
                else if(s == "Loss")
                {
                    
                    //add 1 to loss count
                    lossCount++;
                }
            }
            //close file
            inputFile.Close();

            //display correct score once the form loads

            //player 1 score will be winCount
            player1ScoreLabel.Text = winCount.ToString();
            //player 2 score will be lossCount
            player2ScoreLabel.Text = lossCount.ToString();
        }


        private void newGameButton_Click(object sender, EventArgs e)
        {
            //go back to second form to play another game
            this.Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            jokerWins.PlaySync();
            MessageBox.Show("lkadhlkafs");
        }
    }
}
