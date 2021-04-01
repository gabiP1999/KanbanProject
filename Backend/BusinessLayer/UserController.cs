using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class UserController
    {
        private Dictionary<string, User> users;
        public UserController() 
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
        }
        public User getUser(string email)
        {
            if (users.ContainsKey(email) == true)
            {
                return users[email];
            }
            else
            {
                throw new ArgumentException("there is no user with this email");
            }
        }
        public User login(string email, string password)
        {
            if (users.ContainsKey(email) == true)
            {
                if (this.getUser(email).validatePasswordMatch(password))
                {
                    this.getUser(email).setIslogged(true);
                    return this.getUser(email);
                }
                throw new ArgumentException("the password is not match");
            }  
            else
                throw new ArgumentException("the email is not excist");

        }
        public User register(string email, string password) 
        {
            if (validateEmail(email) == true & validatePasswordRules(password))
            {
                User newUser = new User(email,password);
                users.Add(email, newUser);
                return newUser;
            }
            else
                throw new ArgumentException("the email or the password is invalid");
        }
        private bool validateEmail(string email)
        {
            return !(users.ContainsKey(email) == true);
        }
        private bool validatePasswordRules(string password) 
        {
            bool foundUpper = false;
            bool foundNumber = false;
            bool foundSmall = false;

            if (!(password.Length >= 4 & password.Length <= 20))
                return false;
            for (int i = 0; i <= password.Length | (!foundSmall & !foundNumber & !foundUpper); i++)
            {
                if (Char.IsUpper(password[i]))
                    foundUpper = true;
                if (Char.IsDigit(password[i]))
                    foundNumber = true;
                if (Char.IsLetter(password[i]))
                    foundSmall = true;
            }

            if (foundSmall & foundNumber & foundUpper)
                return true;
            return false;
        }

    }
}
