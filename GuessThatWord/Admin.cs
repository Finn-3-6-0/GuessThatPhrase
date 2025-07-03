using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatWord
{
    public class Admin : User
    {
        public DataBase db = null;
        //admin constructer(parameratised)
        public Admin(string username, string password, string email):base(username, password, email)
        {
            base.setUsername(username);
            base.setPassword(password);
            base.setemail(email);
            db = new DataBase();
        }
        //method to edit user
        public bool updateUser(string user, int positionOfFieldToUpdate, string newValue)
        {
            try
            {
                db.editRecord(user, positionOfFieldToUpdate, newValue);
                return true;
            }
            catch (Exception ex2)
            {
                Console.WriteLine("This program did not work");
                return false;
                throw new ApplicationException("This program did not work :", ex2);
           
            }

        }
        //method to delete user
        public bool deleteUser(string username)
        {
            //if the edit record is given a certain number in position of search term it triggers a delete
            try
            {
                db.editRecord(username, 5, "");
                return true;
            }
            catch (Exception ex2)
            {
                Console.WriteLine("This program did not work");
                return false;
                throw new ApplicationException("This program did not work :", ex2);

            }

        }
    }
}
