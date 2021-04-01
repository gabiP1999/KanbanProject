using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class User
    {
        private BoardController BoardController;
        private bool isLogged;
        private string email;
        private string password;
        private Dictionary<string, Task> TaskList;
        private Dictionary<string, Board> BoardList;
        public User(string email, string password) { }
        public bool validatePasswordMatch(string password) { }
        public void logout() { }
        public bool addBoard(string Boardid) { }
        public Board createBoard(string BoardName) { }
        public Board removeBoard(string BoardID) { }
        public bool equals(User other) { }
        public List<Task> getTasks() { }

    }
}
