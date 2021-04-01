using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class UserController
    {
        private Dictionary<string, User> Users;
        public UserController() { }
        public User getUser(string email) { }
        public User login(string email, string password) { }
        public User register(string email, string password) { }
        private bool validateEmail(string email) { }
        private bool validatePasswordRules(string password) { }

    }
}
