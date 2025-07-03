using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatWord
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private string avatar;
        private int highScore;

        //parameratised constructor for user
        public User(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.avatar = "";
            this.highScore = 0;
        }
        //gets and sets for user information
        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
        public void setPassword(string password) 
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        public string getEmail()
        {
            return email;
        }
        public string getAvatar()
        {
            return avatar;
        }
        public int getHighScore()
        {
            return highScore;
        }
        public void setAvatar(string avatar)
        {
            this.avatar = avatar;
        }
        public void setHighScore(int highScore)
        {
            this.highScore = highScore;
        }
        //method to add user to csv file from the database class
        public bool addUser()
        {

            DataBase d = new DataBase(username, password, email, avatar, highScore);
            bool success = d.addRecord("");

            if (success)
            {
                return true;
            }
            return false;
            
        }
    }
}
