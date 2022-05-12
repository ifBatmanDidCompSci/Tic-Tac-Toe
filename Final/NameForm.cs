namespace Final
{
    public partial class NameForm : Form
    {
        //create an instance of the second form and jump to it
        GameForm gameForm = new GameForm();
        //variables to hold names
        string player1, player2;
        public NameForm()
        {
            InitializeComponent();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            //if the player vs player checkbox is checked
            if (pvpCB.Checked)
            {
                //if player 1 was not given a name
                if (player1pvpTB.Text == "")
                {
                    //throw up an error message
                    MessageBox.Show("Names must be entered for both players");
                    //redirect focus back to the player 1 TB
                    player1pvpTB.Focus();

                }
                else if (player2TB.Text == "")
                {
                    //throw up an error message
                    MessageBox.Show("Names must be entered for both players");
                    //redirect focus back to the player 2 TB
                    player2TB.Focus();
                }
                //if both player names match
                else if (player1pvpTB.Text == player2TB.Text)
                {
                    //throw up an error message
                    MessageBox.Show("Names for both players cannot match");
                    //redirect focus back to the player 1 TB
                    player1pvpTB.Focus();
                    //if names were entered in for both players
                }
                else
                {
                    //set the player 1 name property
                    player1 = player1pvpTB.Text;
                    //set player 2 name property
                    player2 = player2TB.Text;
                    //create a file and write the names and which checkbox was chosen to that file
                    StreamWriter inputFile = File.CreateText("PlayerNames.txt");
                    inputFile.WriteLine(player1);
                    inputFile.WriteLine(player2);
                    inputFile.WriteLine("pvp.Checked");
                    //close the file
                    inputFile.Close();
                    //open GameForm
                    gameForm.ShowDialog();
                }
            }
            //extract the names entered in by the user and connect it to the variable
            //if nothing is entered in, name will be 'player 1'
            else if (pvcCB.Checked)
            {
                if (player1pvcTB.Text != "")
                {
                    //set the player 1 name property
                    player1 = player1pvcTB.Text;
                    //set the player 2 name property
                    player2 = "Computer";
                    //create a file and write the names and which checkbox was chosen to that file
                    StreamWriter inputFile = File.CreateText("PlayerNames.txt");
                    inputFile.WriteLine(player1);
                    inputFile.WriteLine(player2);
                    inputFile.WriteLine("pvc.Checked");
                    //close the file
                    inputFile.Close();
                    //open GameForm
                    gameForm.ShowDialog();
                }
                else
                {
                    //throw up an error message
                    MessageBox.Show("Name must be entered for player");
                    //redirect focus back to the player 2 TB
                    player1pvcTB.Focus();
                }
            }
        }
        private void pvpCB_CheckedChanged(object sender, EventArgs e)
        {
            pvpCB.Visible = false;
            pvcCB.Visible = false;
            nameLab.Visible = true;
            player1pvpLab.Visible = true;
            player1pvpTB.Visible = true;
            player2Lab.Visible = true;
            player2TB.Visible = true;
            enterButton.Visible = true;
            //direct focus to player 1 TB
            player1pvpTB.Focus();

        }

        private void pvcCB_CheckedChanged(object sender, EventArgs e)
        {
            pvpCB.Visible = false;
            pvcCB.Visible = false;
            nameLab.Visible = true;
            player1pvcLab.Visible = true;
            player1pvcTB.Visible = true;
            enterButton.Visible = true;
            //direct focus to player 1 TB
            player1pvcTB.Focus();
        }

        private void player1pvcTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The simple yet amazing game of Tic-Tac-Toe is up ahead! There are both single player and multiplayer modes available, but the single player mode is considered to be a beginner difficulty. Good luck, and have fun!");
        }
    }
}