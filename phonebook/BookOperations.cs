using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{

    class BookOperations
    {
        List<User> userList = new List<User>();
       
       

        public void showMenu()
        {
            Console.WriteLine("Please select the action you want to do:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Registering a New Number");
            Console.WriteLine("(2) Deleting an Existing Number");
            Console.WriteLine("(3) Updating an Existing Number");
            Console.WriteLine("(4) Listing the Phone Book");
            Console.WriteLine("(5) Searching the Phone Book");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Username and Surname for Registering a New User ");
                    Console.Write("Enter Username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter User Surname: ");
                    string userSurname = Console.ReadLine();
                    Console.Write("Enter User Number: ");
                    string userNumber = Console.ReadLine();
                    addUser(userName, userSurname, userNumber);
                    returnMenu();
                    break;

                case "2":
                    Console.WriteLine("Enter Username and Surname for Deleting an User ");
                    Console.Write("Enter Username: ");
                    string uName = Console.ReadLine();
                    Console.Write("Enter User Surname: ");
                    string uSurname = Console.ReadLine();
                    deleteUser(uName, uSurname);
                    returnMenu();
                    break;

                case "3":
                    Console.WriteLine("Enter Username and Surname for Updating an User ");
                    Console.Write("Enter Username: ");
                    string un = Console.ReadLine();
                    Console.Write("Enter User Surname: ");
                    string us = Console.ReadLine();
                    updateUser(un, us);
                    returnMenu();
                    break;

                case "4":

                    listBook();
                    returnMenu();
                    break;

                case "5":
                    Console.WriteLine("Enter Username and Surname for Searching an User ");
                    Console.Write("Enter Username: ");
                    string uname = Console.ReadLine();
                    Console.Write("Enter User Surname: ");
                    string usurname = Console.ReadLine();
                    searchUserInBook(uname, usurname);
                    returnMenu();
                    break;
            }
        }

        void addUser(string name, string surname, string number)
        {
            User newUser = new User();
            newUser.Name = name;
            newUser.Surname = surname;
            newUser.Number = number;

            userList.Add(newUser);
        }
        void deleteUser(string uName, string uSurname)
        {
            foreach (var user in userList)
            {
                if(string.Equals(user.Name, uName) && string.Equals(user.Surname, uSurname))
                {

                    userList.Remove(user);
                    
                }
                else
                {
                    Console.WriteLine("User Not Found");
                    returnMenu();
                }

            }
        }
        void updateUser(string un, string us)
        {
            foreach (var user in userList)
            {
                if (string.Equals(user.Name, un) && string.Equals(user.Surname, us))
                {
                    Console.Write("Enter Username and Surname for Searching an User ");   
                    Console.Write("Enter New Username: ");
                    user.Name = Console.ReadLine();
                    Console.Write("Enter New User Surname: ");
                    user.Surname = Console.ReadLine();
                    Console.Write("Enter New User Number: ");
                    user.Number = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("User Not Found");
                    returnMenu();
                }

            }
        }
        void listBook()
        {
            foreach (var user in userList)
            {
                Console.WriteLine("Name: " + user.Name);
                Console.WriteLine("Surname: " + user.Surname);
                Console.WriteLine("Number: " + user.Number);
                Console.WriteLine("--------");

            }

        }
        void searchUserInBook(string uname, string usurname)
        {
            foreach (var user in userList)
            {
                if (string.Equals(user.Name, uname) && string.Equals(user.Surname, usurname))
                {
                    Console.WriteLine("User Found");
                    Console.WriteLine("Name: " + user.Name);
                    Console.WriteLine("Surname: " + user.Surname);
                    Console.WriteLine("Number: " + user.Number);
            

                }
                else
                {
                    Console.WriteLine("User Not Found");
                    returnMenu();
                }

            }

        }

        void returnMenu()
        {
            Console.WriteLine("Return Menu? (Y/N)");
            string answer = Console.ReadLine();

            if (answer.Equals("Y"))
            {
                showMenu();
            }
            else
            {
                
            }
        }
    }
}
