using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GuessThatWord
{
    public class DataBase
    {

        private string usernameRecord;
        private string passwordRecord;
        private string emailRecord;
        private string avatarRecord;
        private int highScoreRecord;
        //States a constant unchanging variable as the filepath is always the same
        private const string Filepath = "database.csv"; 

        //Default and parameratised DataBase constructor
        public DataBase()
        {

        }
        public DataBase(string record1, string record2, string record3, string record4, int record5)
        {
            this.usernameRecord = record1;
            this.passwordRecord = record2;
            this.emailRecord = record3;
            this.avatarRecord = record4;
            this.highScoreRecord = record5;

        }

        public bool addRecord(string filePath)
        {
            string f = "database.csv";
            //check file exists if yes add user if not create file
            try
            {
                if (filePath != "")
                {
                    f = filePath;
                }
                string[] result = readRecord(usernameRecord, 0, f);
                if (result[0] == "Record not found")
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(f, true))
                    {
                        file.WriteLine(usernameRecord + "," + passwordRecord + "," + emailRecord + "," + avatarRecord + "," + highScoreRecord);
                        return true;
                    }
                }
                return false;

               
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did not work :", ex);
            }
        }

        public void updateHighScore(string searchTerm, int positionOfSearchTerm, int newValue)
        {
            string tempFile = "temp.csv";
            //logic to see if current score is bigger than score in csv

            string[] originalFields = readRecord(searchTerm, positionOfSearchTerm, Filepath);
            int currentHighScore = Convert.ToInt32(originalFields[4]);
            if (newValue > currentHighScore)
            {
                try
                {
                    string[] lines = File.ReadAllLines(Filepath);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');

                        if (i < lines.Length)
                        {
                            //add record manually
                            string[] result = readRecord(fields[0], 0, tempFile);
                            if (result[0] == "Record not found")
                            {
                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(tempFile, true))
                                {
                                    if (fields[0] != searchTerm)
                                    {
                                        file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                                    }
                                    else
                                    {

                                        file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + newValue);
                                    }
                                }
                            }
                            Console.WriteLine("Edited");
                        }
                    }

                    File.Delete(Filepath);

                    File.Move(tempFile, Filepath);

                    Console.WriteLine("Reccord edited");
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("This program did not work");
                    throw new ApplicationException("This program did not work :", ex2);
                }
            }
            
        }

        public void editRecord(string searchTerm, int positionOfNewValue, string newValue)
        {
            string tempFile = "temp.csv";
            //if positionOfNewValue = 5 that triggers the delete user and all fields are updated to empty
          
            try
            {
                string[] lines = File.ReadAllLines(Filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (i < lines.Length)
                    {
                        //add record manually
                        string[] result = readRecord(fields[0], 0, tempFile);
                        if (result[0] == "Record not found")
                        {
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(tempFile, true))
                            {
                                if (fields[0] != searchTerm)
                                {
                                    file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                                }
                                else
                                {
                                    //Find the position of the new value
                                    switch (positionOfNewValue)
                                    {
                                        case 1: file.WriteLine(fields[0] + "," + newValue + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                                            break;
                                        case 2: file.WriteLine(fields[0] + "," + fields[1] + "," + newValue + "," + fields[3] + "," + fields[4]);
                                            break;
                                        case 3: file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + newValue + "," + fields[4]);
                                            break;
                                        case 4: file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + newValue);
                                            break;
                                        case 5: file.WriteLine("" + "," + "" + "," + "" + "," + "" + "," + "");
                                            break;
                                        default: file.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                                            break;
                                    }
                                    
                                }
                            }
                        }
                        Console.WriteLine("Edited");
                    }
                }

                File.Delete(Filepath);

                File.Move(tempFile, Filepath);

                Console.WriteLine("Reccord edited");
            }
            catch (Exception ex2)
            {
                Console.WriteLine("This program did not work");
                throw new ApplicationException("This program did not work :", ex2);
            }
            
        }
        //reuseable method to read read the DataBase file and return a users information
        public string[] readRecord(string searchTerm, int positionOfSearchTerm, string filePath)        
        {
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        return fields;
                    }
                }
                return recordNotFound;
            }
            catch (Exception ex1)
            {
                return recordNotFound;
                throw new ApplicationException("This program did not work :", ex1);
            }


        }
        //Bring username and high score into a list to sort and return to leader board
        public List<User> getLeaderboardInfo()
        {
            int count = 0;
            List<User> users = new List<User>();
            //Search the csv file
            try
            {
                string[] lines = System.IO.File.ReadAllLines("database.csv");
                

                for (int i = 0; i < lines.Length; i++)
                {
                    if(lines[i] != ",,,,")//neede due to deleted user method not deleting commas(intented)
                    {
                        string[] fields = lines[i].Split(',');
                        User user = new User(fields[0], fields[1], fields[2]);
                        user.setHighScore(Convert.ToInt32(fields[4]));
                        users.Add(user);
                    }
                    
                }
                //sort the user list by descending
                var sortedUsers = users.OrderByDescending(u => u.getHighScore());
                List<User> highestScoringUsers = new List<User>(3);

                //only bring back top 3
                for(int i = 0; i<sortedUsers.Count(); i++)
                {
                    count++;
                    if (count <= 3)
                    {
                        highestScoringUsers.Add(sortedUsers.ElementAt(i));
                    }
                    else
                    {
                        break;
                    }
                }

                return highestScoringUsers;
            }
            catch (Exception ex1)
            {
                return users;
                throw new ApplicationException("This program did not work :", ex1);
            }

        }
        //method to put all users into a list for admin drop down
        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            //iterate through csv and add valid fields to list
            try
            {
                string[] lines = System.IO.File.ReadAllLines("database.csv");

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != ",,,,") //when information is removed commas remain
                    {
                        string[] fields = lines[i].Split(',');
                        User user = new User(fields[0], fields[1], fields[2]);
                        user.setAvatar(fields[3]);
                        user.setHighScore(Convert.ToInt32(fields[4]));
                        users.Add(user);
                    }
                    
                }

                return users;
            }
            catch (Exception ex1)
            {
                return users;
                throw new ApplicationException("This program did not work :", ex1);
            }
        }

        //method to check if the reccord matches the target reccord
        public bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            //if the logics search term matches the passed in search term return true
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }

    }
}
