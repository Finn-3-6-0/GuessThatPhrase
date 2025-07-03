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
    public partial class MainMenu : Form
    {

        User currentUser = null;
        public MainMenu(User u)
        {
            InitializeComponent();
            currentUser = u;
            gif1.Visible = false;
            gif2.Visible = false;
            optionsLbl.Visible = false;
            optionsCheckbox.Visible = false;
            label1.Visible = false;
        }
        //exit the Main Menu to the login
        private void MainMenuExitLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome ww = new Welcome();
            ww.Show();
        }
        //bring up the play label
        private void MainMenuPlayLBL_Click(object sender, EventArgs e)
        {
            MainMenuGameInfoLBL.Visible = true;
            MainMenuGameInfoCloseLBL.Visible = true;
            MainMenuGameInfoCloseLBL.BringToFront();
            MainMenuGameInfoEasyLBL.Visible = true;
            MainMenuGameInfoEasyLBL.BringToFront();
            MainMenuGameInfoHardLBL.Visible = true;
            MainMenuGameInfoHardLBL.BringToFront();
            BonusGamesLBL.Visible = true;
            BonusGamesLBL.BringToFront();

        }
        //close the play label
        private void MainMenuGameInfoCloseLBL_Click(object sender, EventArgs e)
        {
            MainMenuGameInfoLBL.Visible = false;
            MainMenuGameInfoCloseLBL.Visible = false;
            MainMenuGameInfoEasyLBL.Visible = false;
            MainMenuGameInfoHardLBL.Visible = false;
            BonusGamesLBL.Visible = false;
        }
        //bring user to game easy
        private void MainMenuGameInfoEasyLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game g = new Game(currentUser);
            g.Show();
        }
        //bring user to game hard
        private void MainMenuGameInfoHardLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHard gh = new GameHard(currentUser);
            gh.Show();
        }
        //bring up Main Menu info label
        private void MainMenuHelpLBLQMark_Click(object sender, EventArgs e)
        {
            MainMenuGameInfoLBL.Visible = true;
            MainMenuGameInfoCloseLBL.Visible = true;
            MainMenuGameInfoCloseLBL.BringToFront();
        }

        //bring user to bonus games
        private void BonusGamesLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            BonusGames bg = new BonusGames(currentUser);
            bg.Show();
        }
        //bring user to leader board page
        private void MainMenuLeaderboardsLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoard lb = new LeaderBoard();
            lb.Show();
        }

        private void MainMenuOptionsLBL_Click(object sender, EventArgs e)
        {
            optionsCheckbox.Visible = true;
            label1.Visible = true;
            optionsLbl.Visible = true;
        }

        private void optionsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(gif1.Visible == true)
            {
                gif1.Visible = false;
                gif2.Visible = false;
            }
            else
            {
                gif1.Visible = true;
                gif2.Visible = true;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            optionsLbl.Visible = false;
            optionsCheckbox.Visible = false;
            label1.Visible = false;
        }
    }
}
