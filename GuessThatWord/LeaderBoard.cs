using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessThatWord
{
    public partial class LeaderBoard : Form
    {

        User currentUser = null;
        int timesClicked = 0;

        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            //create a new database object  to bring leaderboard info back username and score
            DataBase db = new DataBase();
            List<User> highestScoringUsers = db.getLeaderboardInfo();

            //put the names and higscores in descending order if they exist
            if (highestScoringUsers.Count() ==0)
            {

            }
            else if(highestScoringUsers.Count() ==1){
                FirstPlaceLblName.Text = highestScoringUsers.ElementAt(0).getUsername();
                FirstPlaceLblScore.Text = highestScoringUsers.ElementAt(0).getHighScore().ToString();
            }
            else if(highestScoringUsers.Count() == 2){
                FirstPlaceLblName.Text = highestScoringUsers.ElementAt(0).getUsername();
                FirstPlaceLblScore.Text = highestScoringUsers.ElementAt(0).getHighScore().ToString();
                SecondPlaceLblName.Text = highestScoringUsers.ElementAt(1).getUsername();
                SecondPlaceLblScore.Text = highestScoringUsers.ElementAt(1).getHighScore().ToString();
            }
            else if (highestScoringUsers.Count() == 3)
            {
                FirstPlaceLblName.Text = highestScoringUsers.ElementAt(0).getUsername();
                FirstPlaceLblScore.Text = highestScoringUsers.ElementAt(0).getHighScore().ToString();
                SecondPlaceLblName.Text = highestScoringUsers.ElementAt(1).getUsername();
                SecondPlaceLblScore.Text = highestScoringUsers.ElementAt(1).getHighScore().ToString();
                ThirdPlaceLblName.Text = highestScoringUsers.ElementAt(2).getUsername();
                ThirdPlaceLblScore.Text = highestScoringUsers.ElementAt(2).getHighScore().ToString();
            }



        }
        //bring the user back to the main menu method
        private void LeaderBoardExitlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }
        //leaderboard info label display
        private void LeaderBoardHelplbl_Click(object sender, EventArgs e)
        {
            timesClicked++;
            LeaderBoardInfoLBL.Visible = true;
            if (timesClicked == 2)
            {
                LeaderBoardInfoLBL.Visible = false;
                timesClicked = 0;
            }
        }
    }
}
