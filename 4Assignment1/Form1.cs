using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _4Assignment1
{
    public partial class Form1 : Form
    {
        // Images for X and O
        public Image XImage = _4Assignment1.Properties.Resources.X;
        public Image OImage = _4Assignment1.Properties.Resources.circle;

        // List to store winners and count of games played in one go
        public List<string> winnersList = new List<string>();
        public int gamesPlayed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetComponents(); // Reset the game components
            UpdatePlayerLabel(); // Update the displayed current player
        }

        // Method to reset game components
        private void ResetComponents()
        {
            // Clear images from all picture boxes
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            GameFunctions.currentPlayer = "O"; // Start with player O
            // Reset the game board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameFunctions.gameBoard[i, j] = ""; // Reset each cell
                }
            }
            // Reset game state flags
            GameFunctions.WinnerFound = false;
            GameFunctions.gameTie = true;
            GameFunctions.gameOver = false;
        }

        // Event handler for when a box is clicked
        private void BoxClicked(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox; // Get access to picture Box using Sender
            if (box != null && box.Tag != null) // Ensure the box is valid and has a tag
            {
                string boxTagTemp = (string)box.Tag; // Get the tag of the clicked box
                int boxTag = int.Parse(boxTagTemp); // Parse the tag to an integer
                string thisUser = GameFunctions.StartGame(boxTag); // Determine the current player

                // Update the box image based on the current player
                if (thisUser != null)
                {
                    if (thisUser == "O")
                    {
                        box.Image = OImage; // Set image for player O
                    }
                    else if (thisUser == "X")
                    {
                        box.Image = XImage; // Set image for player X
                    }

                    UpdatePlayerLabel(); // Update the label to show the current player
                }

                // Check for game over conditions
                if (GameFunctions.gameTie || GameFunctions.WinnerFound)
                {
                    if (GameFunctions.WinnerFound)
                    {
                        MessageBox.Show("Game Over: " + thisUser + " is the Winner!!");
                        gamesPlayed++; // Increment games played
                        UpdateWinnerList(thisUser); // Update the winner list
                    }
                    else if (GameFunctions.gameTie)
                    {
                        MessageBox.Show("Game Over: It's a Tie!!");
                        thisUser = "Tie"; // Set winner to "Tie"
                        gamesPlayed++; // Increment games played
                        UpdateWinnerList(thisUser); // Update the winner list
                    }

                    ResetComponents(); // Reset components for a new game
                    UpdatePlayerLabel(); // Update player label
                                         // Remove this second call to UpdateWinnerList
                                         // UpdateWinnerList(thisUser); 
                }
            }
        }

        // Method to update the current player label
        public void UpdatePlayerLabel()
        {
            playerLabel.Text = "Current Player: " + GameFunctions.currentPlayer; // Display current player
        }

        // Method to update the list of winners
        public void UpdateWinnerList(string winner)
        {
            winnersList.Add(winner); // Add winner to the list
            winnerList.Items.Add(gamesPlayed + ". " + winner); // Display winner in the list box
        }

        // Event handler for reset button
        private void button1_Click(object sender, EventArgs e)
        {
            ResetComponents(); // Reset the game components
            UpdatePlayerLabel(); // Update the displayed current player
        }

        // Event handler for close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
