using System.Media;

namespace Final
{
    public partial class NameForm : Form
    {
        //create an instance of the second form and jump to it
        GameForm gameForm = new GameForm();
        //variables to hold names
        string player1 = "Batman";
        string player2 = "Joker";
        //soundtrack
        SoundPlayer sound = new SoundPlayer("batmanSTTrim.wav");
        //bool variables that will be useful if the user chooses to play against a computer
        bool easyDifficulty, hardDifficulty = false;
        public NameForm()
        {
            InitializeComponent();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {

        }
        private void pvpCB_CheckedChanged(object sender, EventArgs e)
        {
            //create a file and write which checkbox was chosen to that file
            StreamWriter inputFile = File.CreateText("PlayerCBDecision.txt");
            inputFile.WriteLine("pvp.Checked");
            //close the file
            inputFile.Close();
            //open GameForm and hide this form
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }

        private void pvcCB_CheckedChanged(object sender, EventArgs e)
        {
            //let the user choose difficulty
            easyDifficultyRB.Visible = true;
            hardDifficultyRB.Visible = true;

        }
        private void difficultyDecisionFollowThrough()
        {
            //create a file and write which checkbox was chosen to that file
            StreamWriter inputFile = File.CreateText("PlayerCBDecision.txt");
            inputFile.WriteLine("pvc.Checked");
            //close the file
            inputFile.Close();
            //open GameForm and hide this form
            this.Hide();
            gameForm.ShowDialog();
        }
        private void player1pvcTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void easyDifficultyRB_CheckedChanged(object sender, EventArgs e)
        {
            difficultyDecisionFollowThrough();
        }

        private void hardDifficultyRB_CheckedChanged(object sender, EventArgs e)
        {
            difficultyDecisionFollowThrough();
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            //play batman soundtrack when the program opens
            sound.Play();
        }
    }
}