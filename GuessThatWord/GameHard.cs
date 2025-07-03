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
    public partial class GameHard : Form
    {
        Dictionary<Label, string> hardPhrases = new Dictionary<Label, string>();
        int currentScore = 0;
        int wait = 0;
        bool correct;
        User currentUser = null;
        int timesClicked = 0;

        public GameHard(User u)
        {
            InitializeComponent();
            currentUser = u;
            //load the question dictionary with label questions that corespond to string answers
            hardPhrases.Add(GameHardQLBL1, "badapple");
            hardPhrases.Add(GameHardQLBL2, "barkupthewrongtree");
            hardPhrases.Add(GameHardQLBL3, "beataroundthebush");
            hardPhrases.Add(GameHardQLBL4, "breakaleg");
            hardPhrases.Add(GameHardQLBL5, "breakfastclub");
            hardPhrases.Add(GameHardQLBL6, "breaktheice");
            hardPhrases.Add(GameHardQLBL7, "butterflysinstomach");
            hardPhrases.Add(GameHardQLBL8, "captainhook");
            hardPhrases.Add(GameHardQLBL9, "castleintheclouds");
            hardPhrases.Add(GameHardQLBL10, "coldfeet");
            hardPhrases.Add(GameHardQLBL11, "comparingapplestooranges");
            hardPhrases.Add(GameHardQLBL12, "curveball");
            hardPhrases.Add(GameHardQLBL13, "deathstare");
            hardPhrases.Add(GameHardQLBL14, "dogeatdog");
            hardPhrases.Add(GameHardQLBL15, "dontcountyourchickensbeforetheyhatch");
            hardPhrases.Add(GameHardQLBL16, "dontjudgeabookbyitscover");
            hardPhrases.Add(GameHardQLBL17, "dontputallyoureggsinonebasket");
            hardPhrases.Add(GameHardQLBL18, "dontworrybehappy");
            hardPhrases.Add(GameHardQLBL19, "earlybirdgetstheworm");
            hardPhrases.Add(GameHardQLBL20, "shootingfishinabarrel");
            hardPhrases.Add(GameHardQLBL21, "fortunecookie");
            hardPhrases.Add(GameHardQLBL22, "goodcopbadcop");
            hardPhrases.Add(GameHardQLBL23, "hitthenailonthehead");
            hardPhrases.Add(GameHardQLBL24, "inanutshell");
            hardPhrases.Add(GameHardQLBL25, "ladyluck");
            hardPhrases.Add(GameHardQLBL26, "liarpantsonfire");
            hardPhrases.Add(GameHardQLBL27, "thelionthewitchandthewardrobe");
            hardPhrases.Add(GameHardQLBL28, "loveletter");
            hardPhrases.Add(GameHardQLBL29, "lowkey");
            hardPhrases.Add(GameHardQLBL30, "madcowdisease");
            hardPhrases.Add(GameHardQLBL31, "moneydoesntgrowontrees");
            hardPhrases.Add(GameHardQLBL32, "needleinahaystack");
            hardPhrases.Add(GameHardQLBL33, "nosmokewithoutfire");
            hardPhrases.Add(GameHardQLBL34, "perfectstorm");
            hardPhrases.Add(GameHardQLBL35, "pinsandneedles");
            hardPhrases.Add(GameHardQLBL36, "radiosilence");
            hardPhrases.Add(GameHardQLBL37, "riseandshine");
            hardPhrases.Add(GameHardQLBL38, "rocketscience");
            hardPhrases.Add(GameHardQLBL39, "saveforarainyday");
            hardPhrases.Add(GameHardQLBL40, "seeyoulateraligator");
            hardPhrases.Add(GameHardQLBL41, "shootingstar");
            hardPhrases.Add(GameHardQLBL42, "sickasadog");
            hardPhrases.Add(GameHardQLBL43, "sickleave");
            hardPhrases.Add(GameHardQLBL44, "strikewhiletheironishot");
            hardPhrases.Add(GameHardQLBL45, "thinkoutsidethebox");
            hardPhrases.Add(GameHardQLBL46, "timessquare");
            hardPhrases.Add(GameHardQLBL47, "toolbox");
            hardPhrases.Add(GameHardQLBL48, "wakeupandsmelltheroses");
            hardPhrases.Add(GameHardQLBL49, "walkingdead");
            hardPhrases.Add(GameHardQLBL50, "whatsupdog");

            //set all question labels visible to false
            for (int i = 0; i < hardPhrases.Count; i++)
            {
                hardPhrases.ElementAt(i).Key.Visible = false;
            }
            //randomise first question
            Random ra = new Random();
            int randQ = ra.Next(0, 50);
            hardPhrases.ElementAt(randQ).Key.Visible = true; //TODO randomise this so it doesnt always start on same one DONE
            SubmitRightGameHardLBL.Visible = false;
            SubmitWrongGameHardLBL.Visible = false;
            //begin start sequence
            timer5.Tick += new EventHandler(timer5_Tick_1);
            timer5.Enabled = true;
            timer5.Start();

            GameHardTrafficLight1.BringToFront();
            GameHardTrafficLight2.BringToFront();
            GameHardTrafficLight3.BringToFront();
            GameHardTrafficLight4.BringToFront();
        }



        //format the users answer to be validated
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
        //randomiser for random questions
        private int Randomiser()
        {
            Random r = new Random();
            int genRand = r.Next(0, 50);

            return genRand;
        }
        //randomise questions 
        private Label SelectPhrase(int genRand)
        {
            Label lbl = hardPhrases.ElementAt(genRand).Key;
            return lbl;
        }

        private void SubmitRightGameHardLBL_Click(object sender, EventArgs e)
        {
            //tick lbl needs no code acciental click
        }
                    
        //Move clock for timer method
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            int step = -1;
            int xMax = 790;
            this.GameHardClockLBL.Location = new Point(this.GameHardClockLBL.Location.X + step, this.GameHardClockLBL.Location.Y);

            GameHardScoreDisplayTB.Visible = true;

            //Pause game
            if (GameHardInfoLBL.Visible == true)
            {
                GameHardScoreDisplayTB.Visible = false;
                timer4.Stop();
            }
            //timer method that increments timer and decrements timer 
            if (correct == true && GameHardClockLBL.Location.X + 100 <= xMax)//xmx stops clock from moving off screen
            {
                //x max is 790
                this.GameHardClockLBL.Location = new Point(this.GameHardClockLBL.Location.X + 100, this.GameHardClockLBL.Location.Y);
                correct = false;
            }           
            //game over sequence
            if (GameHardClockLBL.Location.X == 130)
            {
                int finalHighScore = 0;
                timer4.Stop();
                GameHardGameOverLBL.Visible = true;
                GameHardGameOverScoreLBL.Visible = true;
                GameHardGameOverMainMenuLBL.Visible = true;
                GameHardGameOverPlayAgainLBL.Visible = true;
                GameHardGameOverPlayAgainLBL.BringToFront();
                GameHardGameOverMainMenuLBL.BringToFront();
                GameHardGameOverScoreLBL.BringToFront();
                gameHardqMarklbl.Enabled = false;
                GameHardGameOverScoreLBL.Text = GameHardScoreDisplayTB.Text;
                string score = GameHardScoreDisplayTB.Text;
                //final score written to database 
                //validation to ensure high score is higher than current score
                if (score.Equals(""))
                {
                    finalHighScore = 0;
                }
                else
                {
                    finalHighScore = Convert.ToInt32(score);
                }
                GameHardGameOverScoreLBL.Text = finalHighScore.ToString();
                currentUser.setHighScore(finalHighScore);
                DataBase db = new DataBase(currentUser.getUsername(), currentUser.getPassword(), currentUser.getEmail(), currentUser.getAvatar(), currentUser.getHighScore());
                db.updateHighScore(currentUser.getUsername(), 0, finalHighScore);
            }
        }

        private void timer5_Tick_1(object sender, EventArgs e)//game starting sequence
        {
            GameHardTrafficLight1.BringToFront();
            GameHardTrafficLight2.BringToFront();
            GameHardTrafficLight3.BringToFront();
            GameHardTrafficLight4.BringToFront();
            GameHardScoreDisplayTB.SendToBack();
            gameHardqMarklbl.Enabled = false;

            wait++;
            if (wait == 2)
            {
                GameHardTrafficLight1.BringToFront();
                GameHardTrafficLight2.BringToFront();
                GameHardTrafficLight3.BringToFront();
                GameHardTrafficLight4.BringToFront();
                GameHardScoreDisplayTB.Visible = false;
                GameHardTrafficLight1.Visible = true;
            }
            else if (wait == 3)
            {
                GameHardTrafficLight1.BringToFront();
                GameHardTrafficLight2.BringToFront();
                GameHardTrafficLight3.BringToFront();
                GameHardTrafficLight4.BringToFront();
                GameHardTrafficLight1.Visible = false;
                GameHardTrafficLight2.Visible = true;
            }
            else if (wait == 4)
            {
                GameHardTrafficLight1.BringToFront();
                GameHardTrafficLight2.BringToFront();
                GameHardTrafficLight3.BringToFront();
                GameHardTrafficLight4.BringToFront();
                GameHardTrafficLight1.Visible = false;
                GameHardTrafficLight2.Visible = false;
                GameHardTrafficLight3.Visible = true;
            }
            else if (wait == 5)
            {
                GameHardTrafficLight1.Visible = false;
                GameHardTrafficLight2.Visible = false;
                GameHardTrafficLight3.Visible = false;
                GameHardTrafficLight4.Visible = true;

            }
            else if (wait == 6)
            {
                GameHardTrafficLight4.Visible = false;
                GameHardReadyLBL.Visible = false;
                GameHardScoreDisplayTB.BringToFront();

                GameHardScoreDisplayTB.Visible = true;

                timer5.Stop();
                gameHardqMarklbl.Enabled = true;

                timer4.Tick += new EventHandler(timer4_Tick_1);
                timer4.Enabled = true;
                timer4.Start();
            }
        }
        //answer validation on submit click
        private void GameHardSubmitLBL_Click(object sender, EventArgs e)
        {
            this.currentScore = currentScore;
            string answer = "";
            int currentIndex = 0;
            //for loop to check what question was asked
            for (int i = 0; i < hardPhrases.Count; i++)
            {
                if (hardPhrases.ElementAt(i).Key.Visible == true)
                {
                    answer = hardPhrases.ElementAt(i).Value;
                    currentIndex = i;
                }
            }
            //answer formatting with string handling
            string userAnswer = HardPhraseAnsTB.Text;
            userAnswer = stringHandling(userAnswer);
            //asnwer validation
            if (userAnswer == answer)
            {
                HardPhraseAnsTB.Text = "";
                int randNum = Randomiser();
                SelectPhrase(randNum).Visible = true;
                hardPhrases.ElementAt(currentIndex).Key.Visible = false;
                correct = true;
                currentScore++;
            }
            else
            {
                HardPhraseAnsTB.Text = "";
                int randNum = Randomiser();
                SelectPhrase(randNum).Visible = true;
                hardPhrases.ElementAt(currentIndex).Key.Visible = false;
            }
            //show right wrong label answer
            if (correct)
            {
                SubmitRightGameHardLBL.Visible = true;
                SubmitWrongGameHardLBL.Visible = false;

            }
            else
            {
                SubmitRightGameHardLBL.Visible = false;
                SubmitWrongGameHardLBL.Visible = true;
            }

            GameHardScoreDisplayTB.Text = currentScore.ToString();
        }


        private void GameHardSubmitLBL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //control test no code needed
        }
        //reload form method 
        private void GameHardGameOverPlayAgainLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHard gh = new GameHard(currentUser);
            gh.Show();
        }
        //bring user to main menu method
        private void GameHardGameOverMainMenuLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }
        //pause game and show help label method
        private void gameHardqMarklbl_Click(object sender, EventArgs e)
        {
            timesClicked++;
            GameHardInfoLBL.Visible = true;
            HardPhraseAnsTB.Enabled = false;
            GameHardSubmitLBL.Enabled = false;
            if (timesClicked == 2)
            {
                HardPhraseAnsTB.Enabled = true;
                GameHardSubmitLBL.Enabled = true;
                GameHardInfoLBL.Visible = false;
                timesClicked = 0;
                timer4.Start();
            }
        }
        //bring user to main menu method
        private void gameHardExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }
        //allow enter key to be tyed to submit label click
        private void HardPhraseAnsTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GameHardSubmitLBL_Click(sender, e);              
            }
        }
    }
}
