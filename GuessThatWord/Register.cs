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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        int timesPressed = 0;
        int avatarCount = 0;
        //Method to bring the user to the Login form
        private void RegisterOptionsLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

        private void submitRegisterLBL_Click(object sender, EventArgs e)
        {
            //get current avatar
            string avatar;
            if (avatarCount == 0)
            {
                avatar = "AvatarRegLBL1";
            }
            else if (avatarCount == 1)
            {
                avatar = "AvatarRegLBL2";
            }
            else
            {
                avatar = "AvatarRegLBL3";
            }
            //Validate fields on registration form
            string username = uNameRegisterTB.Text;
            string password = pWordRegisterTB.Text;
            string confirmPassword = pWordRegisterConfirmTB.Text;
            string email = eMailRegisterTB.Text;

            //Create a validation object of the useres credentials check password strength etc.
            Validation v = new Validation(username, password, confirmPassword, email);

            //If successful add new user in datatbase
            if (v.validateUsername() && v.validatePassword() && v.validateEmail())
            {
                //Create user DataBase object
                DataBase d = new DataBase(username, password, email, avatar, 0);
                bool success = d.addRecord("");

                //If register is vaild user is brought to login form
                if (success)
                {
                    MessageBox.Show("Success, please login");
                    this.Hide();
                    Welcome w = new Welcome();
                    w.Show();
                }
                else //only shows if all other fields on register are valid 
                {
                    MessageBox.Show("Username is taken");

                }

            }
            //Register error handling with field requirements
            if(pWordRegisterTB.Text != pWordRegisterConfirmTB.Text)
            {
                MessageBox.Show("Passwords do not match");

            }
            if (!v.validateUsername())
            {
                MessageBox.Show("Username does not meet requirements");

            }
            if (!v.validateEmail())
            {
                MessageBox.Show("Email does not meet requirements");

            }
            if (!v.validatePassword())
            {
                MessageBox.Show("Password does not meet requirements");

            }
        }
        //Clear fields method for register form
        private void clearRegisterLBL_Click(object sender, EventArgs e)
        {
            uNameRegisterTB.Text = "";
            eMailRegisterTB.Text = "";
            pWordRegisterTB.Text = "";
            pWordRegisterConfirmTB.Text = "";
        }
        //Make help label visible or not method
        private void QuestionMarkRegisterLBL_Click(object sender, EventArgs e)
        {
            timesPressed++;

            if (timesPressed == 2)
            {
                registerHelpScreenLBL.Visible = false;
                timesPressed = 0;
            }
            else
            {
                registerHelpScreenLBL.Visible = true;
                registerHelpScreenLBL.BringToFront();
            }
        }
        //Avatar scroll right method
        private void LBLScrollRight_Click(object sender, EventArgs e) 
        {
            avatarCount++;
            if (avatarCount == 0)
            {
                AvatarRegLBL1.Hide();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Show();
            }
            else if (avatarCount == 1)
            {
                AvatarRegLBL1.Hide();
                AvatarRegLBL2.Show();
                AvatarRegLBL3.Hide();
            }
            else if (avatarCount == 2)
            {
                AvatarRegLBL1.Show();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Hide();
            }
            else if (avatarCount == 3)
            {
                AvatarRegLBL1.Hide();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Show();
                avatarCount = 0;
            }

        }
        //Avatar scroll left method
        private void LBLScrollLeft_Click(object sender, EventArgs e)
        {
            avatarCount--;
            if (avatarCount == 0)
            {
                AvatarRegLBL1.Hide();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Show();
            }
            else if (avatarCount == 1)
            {
                AvatarRegLBL1.Hide();
                AvatarRegLBL2.Show();
                AvatarRegLBL3.Hide();
            }
            else if (avatarCount == 2)
            {
                AvatarRegLBL1.Show();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Hide();
            }
            else if (avatarCount == -1)
            {
                AvatarRegLBL1.Show();
                AvatarRegLBL2.Hide();
                AvatarRegLBL3.Hide();
                avatarCount = 2;
            }
        }
        //Show password and comfirm password fields
        private void openEyelbl_Click(object sender, EventArgs e)
        {
            //Default password char character
            pWordRegisterConfirmTB.PasswordChar = '\0';
            pWordRegisterTB.PasswordChar = '\0';
            closedEyelbl.Visible = true;
            openEyelbl.Visible = false;
        }

        //Hide password and comfirm password fields
        private void closedEyelbl_Click(object sender, EventArgs e)
        {
            openEyelbl.Visible = true;
            closedEyelbl.Visible = false;
            pWordRegisterConfirmTB.PasswordChar = '*';
            pWordRegisterTB.PasswordChar = '*';
        }
    }
}
