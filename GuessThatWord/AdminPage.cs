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
    public partial class AdminPage : Form
    {
        public Admin currentAdmin = null;
        public DataBase db = new DataBase();
        public AdminPage(Admin a)
        {
            currentAdmin = a;
            InitializeComponent();
            label1.Enabled = false;
            List<User> users = db.getAllUsers();
            for(int i = 0; i<users.Count(); i++)
            {
                userDropDown.Items.Add(users[i].getUsername());
            }
        }

        private void userDropDown_TextUpdate(object sender, EventArgs e)
        {
          
        }

        private void userDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchTerm = userDropDown.Text;
            string[] fields = db.readRecord(searchTerm, 0, "database.csv");
            oldUsernamelbl.Text = fields[0];
            oldPasswordlbl.Text = fields[1];
            oldEmaillbl.Text = fields[2];
            oldAvatarlbl.Text = fields[3];
            oldScorelbl.Text = fields[4];
            label1.Enabled = true;           
        }
        //methods to individually change aspects of a users info
        private void passwordSubmit_Click(object sender, EventArgs e)
        {
            string searchTerm = oldUsernamelbl.Text;
            string newValue = newPasswordtb.Text;
            if(currentAdmin.updateUser(searchTerm, 1, newValue))
            {
               
                //send email to current user that their password has been changed
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                    //Authentication - ensures the program has a valid email to send from
                    NetworkCredential cred = new NetworkCredential("GuessThatPhrase@gmail.com", "boekdvvnrbyspxye");

                    MailMessage msg = new MailMessage();

                    msg.From = new MailAddress("GuessThatPhrase@gmail.com");

                    msg.To.Add(oldEmaillbl.Text);

                    msg.Subject = "Password Reset Notification";

                    msg.Body = "Your password has been updated to " + newPasswordtb.Text + " please login to your account!";

                    client.UseDefaultCredentials = false;

                    client.Credentials = cred;

                    //enabling SSL (Secure sockets layer, encryption) this is required by most email providers to send mail
                    client.EnableSsl = true;

                    client.Send(msg);

                    MessageBox.Show("Success, user has been notified of password update!");
                    this.Hide();
                    AdminPage ap = new AdminPage(currentAdmin);
                    ap.Show();
                }

                catch
                {
                    MessageBox.Show("Something went wrong..");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void emailSubmit_Click(object sender, EventArgs e)
        {
            string searchTerm = oldUsernamelbl.Text;
            string newValue = newEmailtb.Text;
            if (currentAdmin.updateUser(searchTerm, 2, newValue))
            {
                MessageBox.Show("Success!");
                this.Hide();
                AdminPage ap = new AdminPage(currentAdmin);
                ap.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void avatarSubmit_Click(object sender, EventArgs e)
        {
            string searchTerm = oldUsernamelbl.Text;
            string newValue = avatarCB.Text;
            if (currentAdmin.updateUser(searchTerm, 3, newValue))
            {
                MessageBox.Show("Success!");
                this.Hide();
                AdminPage ap = new AdminPage(currentAdmin);
                ap.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void highScoreSubmit_Click(object sender, EventArgs e)
        {
            string searchTerm = oldUsernamelbl.Text;
            string newValue = newScoretb.Text;
            if (currentAdmin.updateUser(searchTerm, 4, newValue))
            {
                MessageBox.Show("Success!");
                this.Hide();
                AdminPage ap = new AdminPage(currentAdmin);
                ap.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        //delete user method
        private void label1_Click(object sender, EventArgs e)
        {
            //method to delete user
            //add in are you sure
            string searchTerm = oldUsernamelbl.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user? Action cannot be undone", "Conformation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (currentAdmin.deleteUser(searchTerm))
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Action aborted");
            }
            
            //reload admin page
            this.Hide();
            AdminPage ap = new AdminPage(currentAdmin);
            ap.Show();
        }
        //admin exit brings to login
        private void adminExitlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
