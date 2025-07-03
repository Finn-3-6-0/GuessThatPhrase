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
    public partial class BonusGames : Form
    {
        string imageDetails = "";
        static bool picBox1ImageChanged = false;
        static bool picBox2ImageChanged = false;
        static bool picBox3ImageChanged = false;
        static int imageDragged = 0;
        Random rand = new Random();
        int num = 0;
        User currentUser = null;


        Dictionary<string, string> myQuestionDICT = new Dictionary<string, string>();
        Dictionary<Label, string> imageLBLDICT = new Dictionary<Label, string>();
        int timesClicked = 0;


        public BonusGames(User u)
        {
            InitializeComponent();
            currentUser = u;

            myQuestionDICT.Add("Enfermo como un perro (Sick as a dog)", "sick,point,dog,");
            myQuestionDICT.Add("Que hay perro? (What's up dog?)", "what,up,dog,");
            myQuestionDICT.Add("Mariposas en el estomago (butterflies in your stomach)", "butterfly,point,woman,");
            myQuestionDICT.Add("En una palabra (in a nutshell)", "point,nut,shell,");
            myQuestionDICT.Add("Que es ese olor? (what's that smell?)", "what,point,nose,");
            myQuestionDICT.Add("Despierta y huele las rosas (wake up and smell the roses)", "bed,nose,rose,");
            myQuestionDICT.Add("Nariz como un perro (nose like a dog)", "nose,point,dog,");
            myQuestionDICT.Add("Nauseas matutinas (Morning sickness)", "bed,woman,sick,");

            imageLBLDICT.Add(DragLbl1, "woman,");
            imageLBLDICT.Add(DragLbl2, "point,");
            imageLBLDICT.Add(DragLbl3, "butterfly,");
            imageLBLDICT.Add(DragLbl4, "dog,");
            imageLBLDICT.Add(DragLbl5, "nose,");
            imageLBLDICT.Add(DragLbl6, "bed,");
            imageLBLDICT.Add(DragLbl7, "up,");
            imageLBLDICT.Add(DragLbl8, "sick,");
            imageLBLDICT.Add(DragLbl9, "nut,");
            imageLBLDICT.Add(DragLbl10, "what,");
            imageLBLDICT.Add(DragLbl11, "rose,");
            imageLBLDICT.Add(DragLbl12, "shell,");

            num = rand.Next(0, myQuestionDICT.Count());
            QuestionLbl.Text = myQuestionDICT.Keys.ElementAt(num);

        }

        private void BonusGamesExitLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(currentUser);
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbAnswer1_Click(object sender, EventArgs e)
        {

        }

        private void BonusGames_Load(object sender, EventArgs e)
        {
            pbAnswer1.AllowDrop = true;
            pbAnswer2.AllowDrop = true;
            pbAnswer3.AllowDrop = true;
        }

        private void DragLbl1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl1.Width, DragLbl1.Height);
            DragLbl1.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 1;
        }

        private void DragLbl2_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl2.Width, DragLbl2.Height);
            DragLbl2.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 2;
        }

        private void DragLbl3_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl3.Width, DragLbl3.Height);
            DragLbl3.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 3;
        }

        private void DragLbl4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl4.Width, DragLbl4.Height);
            DragLbl4.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 4;
        }

        private void DragLbl5_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl5.Width, DragLbl5.Height);
            DragLbl5.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 5;
        }

        private void DragLbl6_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl6.Width, DragLbl6.Height);
            DragLbl6.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 6;
        }

        private void DragLbl7_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl7.Width, DragLbl7.Height);
            DragLbl7.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 7;
        }

        private void DragLbl8_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl8.Width, DragLbl8.Height);
            DragLbl8.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 8;
        }

        private void DragLbl9_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl9.Width, DragLbl9.Height);
            DragLbl9.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 9;
        }

        private void DragLbl10_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl10.Width, DragLbl10.Height);
            DragLbl10.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 10;
        }

        private void DragLbl11_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl11.Width, DragLbl11.Height);
            DragLbl11.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 11;
        }

        private void DragLbl12_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(DragLbl12.Width, DragLbl12.Height);
            DragLbl12.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(Color.White);

            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;

            imageDragged = 12;
        }

        private void pbAnswer1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            picBox1ImageChanged = true;
        }

        private void pbAnswer1_DragDrop(object sender, DragEventArgs e)
        {
            pbAnswer1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pbAnswer2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            picBox2ImageChanged = true;
        }

        private void pbAnswer2_DragDrop(object sender, DragEventArgs e)
        {
            pbAnswer2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pbAnswer3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            picBox3ImageChanged = true;
        }

        private void pbAnswer3_DragDrop(object sender, DragEventArgs e)
        {
            pbAnswer3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pbAnswer1_MouseEnter(object sender, EventArgs e)
        {
            if (imageDragged == 1)
            {
                DragLbl1.DoDragDrop(DragLbl1.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl1";
                imageDragged = 0;

            }
            if (imageDragged == 2)
            {
                DragLbl2.DoDragDrop(DragLbl2.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl2";
                imageDragged = 0;


            }
            if (imageDragged == 3)
            {
                DragLbl3.DoDragDrop(DragLbl3.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl3";
                imageDragged = 0;

            }
            if(imageDragged == 4)
            {
                DragLbl4.DoDragDrop(DragLbl4.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl4";
                imageDragged = 0;

            }
            if (imageDragged == 5)
            {
                DragLbl5.DoDragDrop(DragLbl5.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl5";
                imageDragged = 0;


            }
            if (imageDragged == 6)
            {
                DragLbl6.DoDragDrop(DragLbl6.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl6";
                imageDragged = 0;

            }
            if (imageDragged == 7)
            {
                DragLbl7.DoDragDrop(DragLbl7.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl7";
                imageDragged = 0;

            }
            if (imageDragged == 8)
            {
                DragLbl8.DoDragDrop(DragLbl8.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl8";
                imageDragged = 0;


            }
            if (imageDragged == 9)
            {
                DragLbl9.DoDragDrop(DragLbl9.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl9";
                imageDragged = 0;

            }
            if (imageDragged == 10)
            {
                DragLbl10.DoDragDrop(DragLbl10.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl10";
                imageDragged = 0;

            }
            if (imageDragged == 11)
            {
                DragLbl11.DoDragDrop(DragLbl11.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl11";
                imageDragged = 0;


            }
            if (imageDragged == 12)
            {
                DragLbl12.DoDragDrop(DragLbl12.Image, DragDropEffects.Copy);
                pbAnswer1.Tag = "DragLbl12";
                imageDragged = 0;

            }
        }

        private void pbAnswer2_MouseEnter(object sender, EventArgs e)
        {
            if (imageDragged == 1)
            {
                DragLbl1.DoDragDrop(DragLbl1.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl1";
                imageDragged = 0;

            }
            if (imageDragged == 2)
            {
                DragLbl2.DoDragDrop(DragLbl2.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl2";
                imageDragged = 0;


            }
            if (imageDragged == 3)
            {
                DragLbl3.DoDragDrop(DragLbl3.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl3";
                imageDragged = 0;

            }
            if (imageDragged == 4)
            {
                DragLbl4.DoDragDrop(DragLbl4.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl4";
                imageDragged = 0;

            }
            if (imageDragged == 5)
            {
                DragLbl5.DoDragDrop(DragLbl5.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl5";
                imageDragged = 0;


            }
            if (imageDragged == 6)
            {
                DragLbl6.DoDragDrop(DragLbl6.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl6";
                imageDragged = 0;

            }
            if (imageDragged == 7)
            {
                DragLbl7.DoDragDrop(DragLbl7.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl7";
                imageDragged = 0;

            }
            if (imageDragged == 8)
            {
                DragLbl8.DoDragDrop(DragLbl8.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl8";
                imageDragged = 0;


            }
            if (imageDragged == 9)
            {
                DragLbl9.DoDragDrop(DragLbl9.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl9";
                imageDragged = 0;

            }
            if (imageDragged == 10)
            {
                DragLbl10.DoDragDrop(DragLbl10.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl10";
                imageDragged = 0;

            }
            if (imageDragged == 11)
            {
                DragLbl11.DoDragDrop(DragLbl11.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl11";
                imageDragged = 0;


            }
            if (imageDragged == 12)
            {
                DragLbl12.DoDragDrop(DragLbl12.Image, DragDropEffects.Copy);
                pbAnswer2.Tag = "DragLbl12";
                imageDragged = 0;

            }
        }

        private void pbAnswer3_MouseEnter(object sender, EventArgs e)
        {
            if (imageDragged == 1)
            {
                DragLbl1.DoDragDrop(DragLbl1.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl1";
                imageDragged = 0;

            }
            if (imageDragged == 2)
            {
                DragLbl2.DoDragDrop(DragLbl2.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl2";
                imageDragged = 0;


            }
            if (imageDragged == 3)
            {
                DragLbl3.DoDragDrop(DragLbl3.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl3";
                imageDragged = 0;

            }
            if (imageDragged == 4)
            {
                DragLbl4.DoDragDrop(DragLbl4.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl4";
                imageDragged = 0;

            }
            if (imageDragged == 5)
            {
                DragLbl5.DoDragDrop(DragLbl5.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl5";
                imageDragged = 0;


            }
            if (imageDragged == 6)
            {
                DragLbl6.DoDragDrop(DragLbl6.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl6";
                imageDragged = 0;

            }
            if (imageDragged == 7)
            {
                DragLbl7.DoDragDrop(DragLbl7.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl7";
                imageDragged = 0;

            }
            if (imageDragged == 8)
            {
                DragLbl8.DoDragDrop(DragLbl8.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl8";
                imageDragged = 0;


            }
            if (imageDragged == 9)
            {
                DragLbl9.DoDragDrop(DragLbl9.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl9";
                imageDragged = 0;

            }
            if (imageDragged == 10)
            {
                DragLbl10.DoDragDrop(DragLbl10.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl10";
                imageDragged = 0;

            }
            if (imageDragged == 11)
            {
                DragLbl11.DoDragDrop(DragLbl11.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl11";
                imageDragged = 0;


            }
            if (imageDragged == 12)
            {
                DragLbl12.DoDragDrop(DragLbl12.Image, DragDropEffects.Copy);
                pbAnswer3.Tag = "DragLbl12";
                imageDragged = 0;

            }
        }

        private void SubmitLbl_Click(object sender, EventArgs e)
        {
            string currentQuestion = QuestionLbl.Text;
            bool correct = false;
            //check if all picture boxes contain an image
            if (picBox1ImageChanged && picBox2ImageChanged && picBox3ImageChanged)
            {
                //iterate through dictionary imagelbl dictionary to match image to string
                for (int i = 0; i < imageLBLDICT.Keys.Count(); i++)
                {
                    if (pbAnswer1.Tag == imageLBLDICT.Keys.ElementAt(i).Name)
                    {
                        imageDetails += imageLBLDICT.Values.ElementAt(i);

                    }
                }

                for (int i = 0; i < imageLBLDICT.Keys.Count(); i++)
                {
                    if (pbAnswer2.Tag == imageLBLDICT.Keys.ElementAt(i).Name)
                    {
                        imageDetails += imageLBLDICT.Values.ElementAt(i);

                    }
                }

                for (int i = 0; i < imageLBLDICT.Keys.Count(); i++)
                {
                    if (pbAnswer3.Tag == imageLBLDICT.Keys.ElementAt(i).Name)
                    {
                        imageDetails += imageLBLDICT.Values.ElementAt(i);

                    }
                }
            }

            for (int i = 0; i < myQuestionDICT.Count(); i++)
            {
                if (myQuestionDICT.Values.ElementAt(i) == imageDetails)
                {
                    if (currentQuestion == myQuestionDICT.Keys.ElementAt(i))
                    {
                        correct = true;
                    }
                }
               
            }

            if (correct)
            {
                CorrectLbl.Visible = true;
                IncorrectLbl.Visible = false;
            }
            else
            {
                CorrectLbl.Visible = false;
                IncorrectLbl.Visible = true;
            }


            num = rand.Next(0, myQuestionDICT.Count());
            QuestionLbl.Text = myQuestionDICT.Keys.ElementAt(num);

            pbAnswer1.Image = null;
            pbAnswer2.Image = null;
            pbAnswer3.Image = null;
            imageDetails = "";
        }

        private void BonusGamesHelplbl_Click(object sender, EventArgs e)
        {
            timesClicked++;
            BonusGameInfoLBL.Visible = true;
            if (timesClicked == 2)
            {
                BonusGameInfoLBL.Visible = false;
                timesClicked = 0;
            }

        }
    }
}
