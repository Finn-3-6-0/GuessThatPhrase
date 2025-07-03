using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatWord
{
    class Validation
    {
        private string username;
        private string password;
        private string confirmPassword;
        private string email;

        //Login details for an admin theese are constant as there is only one admin
        private const string adminUsername = "admin1234";
        private const string adminPassword = "AA!!11adminpass";

        //Parameterised constructor
        public Validation(string username, string password, string confirmPassword, string email)
        {
            this.username = username;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.email = email;
        }

        //Username validator to ensure apropiate length andigit count
        public bool validateUsername()
        {
            if (!String.IsNullOrEmpty(username) && username.Length > 8 && username.Length < 15) 
            {
                int countDigits = 0;
                for (int i= 0;i < username.Length; i++)
                {
                    if (char.IsDigit(username[i]))
                    {
                        countDigits++;
                    }
                }
               
                if (countDigits >= 3)
                {
                    return true;
                }
            }
            return false;

        }

        //Password validation method to ensure password complexity
        public bool validatePassword()
        {
            bool validPassword = false;

            if (!String.IsNullOrEmpty(password) && password.Length >= 9)
            {
                int countDigits = 0, countUpper = 0, countPunctuation = 0, countWhiteSpace = 0;

                for (int i = 0; i < password.Length; i++) 
                {

                    if (Char.IsDigit(password[i]))
                    {
                        countDigits++;
                    }

                    if (Char.IsUpper(password[i]))
                    {
                        countUpper++;
                    }

                    if (Char.IsPunctuation(password[i]))
                    {
                        countPunctuation++;
                    }

                    if (Char.IsWhiteSpace(password[i]))
                    {
                        countWhiteSpace++;
                    }
                }
                if (countPunctuation >= 2 && countUpper >= 2 && countDigits >= 2 && countWhiteSpace == 0 && password == confirmPassword)
                {
                    validPassword = true;
                }
            }

            else
            {
                validPassword = false;
            }

            return validPassword;


        }

        //Email validation to ensure user provides a valid email adress
        public bool validateEmail()
        {
            if (!String.IsNullOrEmpty(email))
            {
                int countSymbol = 0;
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        countSymbol++;
                    }
                }

                if (countSymbol == 1)
                {
                    return true;
                }
            }
            return false;
        }

        //Method to validate fields on login form
        public bool validateLogin()
        {
            if(!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                return true;
            }
            return false;
        }

        //Method to check if the login creditionals passed in by the user are admin credentials
        public bool validateAdmin()
        {

            if(username == adminUsername && password == adminPassword)
            {
                return true;
            }
            return false;
        }
    }
}
