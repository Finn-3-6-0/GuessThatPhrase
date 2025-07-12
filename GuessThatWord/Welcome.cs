using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GuessThatWord
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            forgottenPasswordSubmitLBL.Visible = false;
            forgottenPasswordTB.Visible = false;
            forgottenPassLbl1.Visible = false;
            label1.Visible = false;
        }

        //Method to allow user to travel to register forn
        private void loginOptionsLBL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        //Method to validate a useres Login and bring them to the Main Menu
        private void submitLoginLBL_Click(object sender, EventArgs e)
        {
            //Take the text the user has entered and assign variables
            string username = uNameLoginTB.Text;
            string password = pWordLoginTB.Text;
            //Create validation and DataBase objects
            Validation v = new Validation(username, password, "", "");
            DataBase db = new DataBase(username, password, "", "", 0);

            //Check to see if the user is an admin
            if (v.validateAdmin())
            {
                //Create a now valid admin object
                Admin a = new Admin(username, password, "");

                //when new admin created go to admin form
                this.Hide();
                AdminPage ap = new AdminPage(a);
                ap.Show();
            }

            //Check to see if the user has an account method
            else if (v.validateLogin())
            {
                var s = string.Join(",", db.readRecord(username, 0, "database.csv"));
                if (s == "Record not found")//String that read record method returns if false
                {
                    MessageBox.Show("Invalid username or password");
                }
                else
                {
                    var result = s.Split(',');
                    var passFromDB = result[1];
                    //Password check
                    if (password == passFromDB)
                    {
                        MessageBox.Show("Login succesful");
                        this.Hide();
                        //create new user object read email from database into user object 
                        User u = new User(username, passFromDB, "");
                        MainMenu m = new MainMenu(u);
                        m.Show();
                    }
                    else
                    {
                        //Generalised error message to enhance the platforms security
                        MessageBox.Show("Invalid username or password"); 
                    }
                }
            }
            else
            {
                //Generalised error message to enhance the platforms security
                MessageBox.Show("Invalid username or password");
            }

            
        }
       
        //Method to clear fields on login
        private void clearLoginLBL_Click(object sender, EventArgs e)
        {
            uNameLoginTB.Text ="";
            pWordLoginTB.Text ="";

        }

        //Mehtod to show password
        private void openEyelbl_Click(object sender, EventArgs e)
        {
            //Default password char character
            pWordLoginTB.PasswordChar = '\0';
            closedEyelbl.Visible = true;
            openEyelbl.Visible = false;
        }

        //Mehtod to hide password
        private void closedEyelbl_Click(object sender, EventArgs e)
        {
            openEyelbl.Visible = true;
            closedEyelbl.Visible = false;
            pWordLoginTB.PasswordChar = '*';
        }

        private void loginForgotpassLBL_Click(object sender, EventArgs e)
        {
            
            forgottenPasswordSubmitLBL.Visible = true;
            forgottenPasswordTB.Visible = true;
            label1.Visible = true;
            forgottenPassLbl1.Visible = true;


        }

        private void forgottenPasswordSubmitLBL_Click(object sender, EventArgs e)
        {
            string userRequest = "";
            if (forgottenPasswordTB.Text != "")
            {
                userRequest = forgottenPasswordTB.Text;
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                    //Authentication - ensures the program has a valid email to send from
                    NetworkCredential cred = new NetworkCredential("GuessThatPhrase@gmail.com", "EMAIL_KEY_HERE");

                    MailMessage msg = new MailMessage();

                    msg.From = new MailAddress("GuessThatPhrase@gmail.com");

                    msg.To.Add("GuessThatPhrase@gmail.com");

                    msg.Subject = "Forgotten Password Notification";

                    msg.Body = "Please update the following user's password: " + userRequest;

                    client.UseDefaultCredentials = false;

                    client.Credentials = cred;

                    //enabling SSL (Secure sockets layer, encryption) this is required by most email providers to send mail
                    client.EnableSsl = true;

                    client.Send(msg);

                    MessageBox.Show("Forgotten Password Request Received. You will be contacted within 24 hours");

                    forgottenPasswordSubmitLBL.Visible = false;
                    forgottenPasswordTB.Visible = false;
                    forgottenPassLbl1.Visible = false;
                    label1.Visible = false;
                }

                catch
                {
                    MessageBox.Show("Something went wrong..");
                }
            }
            else
            {
                MessageBox.Show("Please submit a valid request!");
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
