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
    public partial class Game : Form
    {
        Dictionary<Label, string> easyPhrases = new Dictionary<Label, string>();
        int currentScore = 0;
        int wait = 0;
        User currentUser = null;
        int timesClicked = 0;

 


        public Game(User u)
        {
            InitializeComponent();
            currentUser = u;
            //question dictionary with labels and answers
            easyPhrases.Add(GameEasyQLBL1, "anchorman");
            easyPhrases.Add(GameEasyQLBL2, "applewatch");
            easyPhrases.Add(GameEasyQLBL3, "armchair");
            easyPhrases.Add(GameEasyQLBL4, "bananabread");
            easyPhrases.Add(GameEasyQLBL5, "bananaboat");
            easyPhrases.Add(GameEasyQLBL6, "bedbug");
            easyPhrases.Add(GameEasyQLBL7, "bluemoon");
            easyPhrases.Add(GameEasyQLBL8, "bombshell");
            easyPhrases.Add(GameEasyQLBL9, "bookclub");
            easyPhrases.Add(GameEasyQLBL10, "bookworm");
            easyPhrases.Add(GameEasyQLBL11, "burgerking");
            easyPhrases.Add(GameEasyQLBL12, "captainamerica");
            easyPhrases.Add(GameEasyQLBL13, "catnap");
            easyPhrases.Add(GameEasyQLBL14, "chillpill");
            easyPhrases.Add(GameEasyQLBL15, "couchpotato");
            easyPhrases.Add(GameEasyQLBL16, "crywolf");
            easyPhrases.Add(GameEasyQLBL17, "dancingqueen");
            easyPhrases.Add(GameEasyQLBL18, "dinnerparty");
            easyPhrases.Add(GameEasyQLBL19, "familytree");
            easyPhrases.Add(GameEasyQLBL20, "firetruck");
            easyPhrases.Add(GameEasyQLBL21, "flagship");
            easyPhrases.Add(GameEasyQLBL22, "giftcard");
            easyPhrases.Add(GameEasyQLBL23, "homesick");
            easyPhrases.Add(GameEasyQLBL24, "honeymoon");
            easyPhrases.Add(GameEasyQLBL25, "hotchocolate");
            easyPhrases.Add(GameEasyQLBL26, "hotmeal");
            easyPhrases.Add(GameEasyQLBL27, "iphone");
            easyPhrases.Add(GameEasyQLBL28, "jinglebellrock");
            easyPhrases.Add(GameEasyQLBL29, "kingkong");
            easyPhrases.Add(GameEasyQLBL30, "lighthouse");
            easyPhrases.Add(GameEasyQLBL31, "lockup");
            easyPhrases.Add(GameEasyQLBL32, "lovebirds");
            easyPhrases.Add(GameEasyQLBL33, "meatloaf");
            easyPhrases.Add(GameEasyQLBL34, "moneytalks");
            easyPhrases.Add(GameEasyQLBL35, "moviestar");
            easyPhrases.Add(GameEasyQLBL36, "ninjaturtle");
            easyPhrases.Add(GameEasyQLBL37, "paycheque");
            easyPhrases.Add(GameEasyQLBL38, "pieceofcake");
            easyPhrases.Add(GameEasyQLBL39, "piggybank");
            easyPhrases.Add(GameEasyQLBL40, "punchbag");
            easyPhrases.Add(GameEasyQLBL41, "queenbee");
            easyPhrases.Add(GameEasyQLBL42, "rocktheboat");
            easyPhrases.Add(GameEasyQLBL43, "sleepwalking");
            easyPhrases.Add(GameEasyQLBL44, "smartcookie");
            easyPhrases.Add(GameEasyQLBL45, "starfish");
            easyPhrases.Add(GameEasyQLBL46, "sunglasses");
            easyPhrases.Add(GameEasyQLBL47, "surfsup");
            easyPhrases.Add(GameEasyQLBL48, "timeflies");
            easyPhrases.Add(GameEasyQLBL49, "twobirdsonestone");
            easyPhrases.Add(GameEasyQLBL50, "footballworldcup");

            //hide every label
            for (int i=0; i< easyPhrases.Count; i++)
            {
                easyPhrases.ElementAt(i).Key.Visible = false;
            }
            //randomise first question selection
            Random ra = new Random();
            int randQ = ra.Next(0, 50);
            easyPhrases.ElementAt(randQ).Key.Visible = true; 
            SubmitRightGameEasyLBL.Visible = false;
            SubmitWrongGameEasyLBL.Visible = false;

            //begin game start sequence
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Enabled = true;
            timer3.Start();

            GameEasyTrafficLight1.BringToFront();
            GameEasyTrafficLight2.BringToFront();
            GameEasyTrafficLight3.BringToFront();
            GameEasyTrafficLight4.BringToFront();
        }

        private void timer3_Tick(object sender, EventArgs e)//game starting sequence
        {
            GameEasyTrafficLight1.BringToFront();
            GameEasyTrafficLight2.BringToFront();
            GameEasyTrafficLight3.BringToFront();
            GameEasyTrafficLight4.BringToFront();
            GameEasyScoreDisplayTB.SendToBack();
            label1.Enabled = false;



            wait++;
            if (wait == 1)
            {
                GameEasyScoreDisplayTB.Visible = false;
                GameEasyTrafficLight1.Visible = true;
            }
            else if (wait == 2)
            {
                GameEasyTrafficLight1.Visible = false;
                GameEasyTrafficLight2.Visible = true;
            }
            else if (wait == 3)
            {
                GameEasyTrafficLight1.Visible = false;
                GameEasyTrafficLight2.Visible = false;
                GameEasyTrafficLight3.Visible = true;
            }
            else if (wait == 4)
            {
                GameEasyTrafficLight1.Visible = false;
                GameEasyTrafficLight2.Visible = false;
                GameEasyTrafficLight3.Visible = false;
                GameEasyTrafficLight4.Visible = true;

            }
            else if (wait == 5)
            {
                GameEasyTrafficLight4.Visible = false;
                GameEasyReadyLBL.Visible = false;
                GameEasyScoreDisplayTB.BringToFront();

                GameEasyScoreDisplayTB.Visible = true;

                timer3.Stop();
                label1.Enabled = true;


                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Enabled = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //clock moving across the screen timer sequence
        {

            if (GameInfoLBL.Visible == true)
            {
                timer2.Stop();
            }
            //create an int that continually takes away from the clocks x position
            int step = -1;
            this.GameEasyClockLBL.Location = new Point(this.GameEasyClockLBL.Location.X + step, this.GameEasyClockLBL.Location.Y);
            if(GameEasyClockLBL.Location.X == 130)
            {
                int finalHighScore = 0;
                timer2.Stop();
                GameEasyGameOverLBL.Visible = true;
                GameEasyGameOverScoreLBL.Visible = true;
                GameEasyGameOverMainMenuLBL.Visible = true;
                GameEasyGameOverPlayAgainLBL.Visible = true;
                GameEasyGameOverScoreLBL.BringToFront();
                GameEasyGameOverPlayAgainLBL.BringToFront();
                GameEasyGameOverMainMenuLBL.BringToFront();
                GameEasyScoreDisplayTB.Visible = false;
                string score = GameEasyScoreDisplayTB.Text;
                label1.Enabled = false;
                //display final highscore
                if (score.Equals(""))
                {
                    finalHighScore = 0;
                }
                else
                {
                    finalHighScore = Convert.ToInt32(score);
                }
                GameEasyGameOverScoreLBL.Text =finalHighScore.ToString();  
            }
        }

        //answer checking method
        private void SubmitGameEasyLBL_Click(object sender, EventArgs e)
        {
            this.currentScore = currentScore;
            string answer = "";
            int currentIndex = 0;
            //check witch question is visible 
            for(int i=0; i< easyPhrases.Count; i++)
            {
                if(easyPhrases.ElementAt(i).Key.Visible == true)
                {
                    answer = easyPhrases.ElementAt(i).Value;
                    currentIndex = i;
                }
            }

           string userAnswer = EasyPhraseAnsTB.Text;
            bool correct = false;
            //string handle the users answer to conform it to the dictionary values
            userAnswer = stringHandling(userAnswer);
            //check if answer is correct
            if (userAnswer == answer)
            {
                EasyPhraseAnsTB.Text = "";
                int randNum = Randomiser();
                SelectPhrase(randNum).Visible = true;
                easyPhrases.ElementAt(currentIndex).Key.Visible = false;
                correct = true;
                currentScore++;
            }
            else
            {
                EasyPhraseAnsTB.Text = "";
                int randNum = Randomiser();
                SelectPhrase(randNum).Visible = true;
                easyPhrases.ElementAt(currentIndex).Key.Visible = false;
                correct = false;
            }
            //display right wrong labels
            if (correct)
            {
                SubmitRightGameEasyLBL.Visible = true;
                SubmitWrongGameEasyLBL.Visible = false;

            }
            else
            {
                SubmitRightGameEasyLBL.Visible = false;
                SubmitWrongGameEasyLBL.Visible = true;
            }


            GameEasyScoreDisplayTB.Text = currentScore.ToString();

        }
        //string handling method
        private string stringHandling(string userAnswer)
        {
            userAnswer = userAnswer.ToLower();
            userAnswer = userAnswer.Replace(" ", "");
            userAnswer = userAnswer.Replace("'", "");
            userAnswer = userAnswer.Replace(",", "");
            userAnswer = userAnswer.Replace("'", "");
            userAnswer = userAnswer.Trim();
            return userAnswer;
        }
        //question randomiser method
        private int Randomiser()
        {
            Random r = new Random();
            int genRand = r.Next(0, 50);

            return genRand;
        }
        //select phrase method
        private Label SelectPhrase(int genRand)
        {
            Label lbl = easyPhrases.ElementAt(genRand).Key;
            return lbl;
        }
        //main menu link method
        private void GameEasyGameOverMainMenuLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }
        //play again method that reloads form
        private void GameEasyGameOverPlayAgainLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game gh = new Game(currentUser);
            gh.Show();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //accidental click
        }
        //game exit to main menu method
        private void gamExitlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }
        //game help label displayer needs to pause game
        private void label1_Click(object sender, EventArgs e)
        {
            timesClicked++;
            GameInfoLBL.Visible = true;
            EasyPhraseAnsTB.Enabled = false;
            SubmitGameEasyLBL.Enabled = false;
            if (timesClicked == 2)
            {
                SubmitGameEasyLBL.Enabled = true;
                EasyPhraseAnsTB.Enabled = true;
                GameInfoLBL.Visible = false;
                timesClicked = 0;
                timer2.Start();
            }

        }
        //enter key press to corrolate to submit label click
        private void EasyPhraseAnsTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitGameEasyLBL_Click(sender, e);
            }
        }
    }
}
