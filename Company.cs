using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Company.ConsoleApp
{
    internal class Company
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public bool chech { get; set; }
        User1[] users = new User1[0];

        public void Register()
        {

            bool check;
            Console.WriteLine("enter the name");
            string Name2 = Console.ReadLine();
            Console.WriteLine("enter the surname");
            string Surname2 = Console.ReadLine();
            
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$";
            string Username2 = $"{Name2}.{Surname2}";
            Console.WriteLine($"your username was created like that: {Name2}.{Surname2}");
            Console.WriteLine($"{Name2}.{Surname2} @gmail.com");
            bool isValidPassword = false;
            while (!isValidPassword)
            {
                Console.WriteLine("enter the password which has at least 8 characters,1 upperCase,1 Lowercase and one digit");
                string Password2 = Console.ReadLine();

                if (Regex.IsMatch(Password2, passwordPattern))
                {
                    Console.WriteLine("Password is valid.");
                    isValidPassword = true;
                    User1 user = new User1()
                    {
                        Name = Name2,
                        Surname = Surname2,
                        Password = Password2,
                        Username = Username2,
                    };
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user;

                }
                else
                {
                    Console.WriteLine("Password is invalid.");
                }


            }

        }
        bool check1 = true;
        int adjust;
        public void Login()
        {

            bool correctInfo = false;
            while (!correctInfo)
            {


                Console.WriteLine("enter your username");
                string Username1 = Console.ReadLine();
                Console.WriteLine("enter your password");
                string Password1 = Console.ReadLine();
                check1 = true;
                
                for (int i = 0; i < users.Length; i++)
                {

                    if (users[i].Username == Username1 && users[i].Password == Password1)
                    {
                        adjust = i;
                        Console.WriteLine("you successfully log in to the system");
                        chech = false;
                        check1 = false;
                        
                        correctInfo = true;

                        //Name = users[i].Name;
                        //Surname = users[i].Surname;
                        break;
                    }

                }
                if (!correctInfo)
                {
                    Console.WriteLine("The entered username or password is incorrect. Please try again.");
                }

            }
        }

        public void GetAll()
        {

            for (int i = 0; i < users.Length; i++)
            {

                Console.WriteLine(users[i].Username);

            }
        }
        public void GetByUserName()
        {
            bool checking = false;
            Console.WriteLine("enter the existing username for checking");
            string username = Console.ReadLine();
            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i].Username)
                {
                    Console.WriteLine("name:" + users[i].Name);
                    Console.WriteLine("surname:" + users[i].Surname);
                    checking = true;
                    break;
                }

            }
            if (!checking)
            {
                Console.WriteLine(" the entering user was not found in the system");
            }
        }
        public void UpdateByUsername()
        {
            if (!check1)
            {
                Console.Write("Enter the operation which you want to update:");
                string letter = Console.ReadLine();
                switch (letter)
                {
                    case "a":
                        Console.WriteLine("new name:");
                        string name = Console.ReadLine();
                        users[adjust].Name = name;
                        Console.WriteLine("the name was updated");
                        break;
                    case "b":
                        Console.WriteLine("new surname");
                        string surname = Console.ReadLine();
                        users[adjust].Surname = surname;
                        Console.WriteLine("the surname was updated");
                        break;
                    case "c":
                        Console.WriteLine("new username");
                        string username = Console.ReadLine();
                        users[adjust].Username = username;
                        Console.WriteLine("the username was updated");
                        break;
                    case "d":
                        Console.WriteLine("new email");
                        string email = Console.ReadLine();
                        users[adjust].Email = email;
                        Console.WriteLine("the email was updated");
                        break;

                    default:
                        Console.WriteLine("please enter the right value:");
                        break;
                }
            }
            else
            {
                Console.WriteLine("you should be log in into the system");

            }


        }
  
        public void DeleteByUserName()
        {
            bool deleted = false;
            Console.WriteLine("enter the username which you want to delete it ");
            string deletingName = Console.ReadLine();
            for (int i = 0; i < users.Length; i++)
            {
                if (deletingName == users[i].Username)
                {
                    users[i].Username = null;
                    deleted = true;
                }
            }
            Console.WriteLine("the username was deleted");
            if (!deleted)
            {
                Console.WriteLine("Username not found.");
            }

        }

    }
}
