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
        public User(string email, string password) 
        {
            BoardController BoardController = new BoardController(); //צריך לבנות בנאי ריק
            isLogged = false;
            this.email = email;
            this.password = password;
            Dictionary<string, Task> TaskList = new Dictionary<string, Task>();
            Dictionary<string, Board> BoardList = new Dictionary<string, Board>();
        }
        public bool validatePasswordMatch(string password) 
        {
            return password.Equals(this.password);
        }
        public void logout() 
        {
            this.setIslogged(false);
        }
        public bool addBoard(Board board) 
        {
            if (BoardList.ContainsKey(board.getId()) == true) //צריך לכתוב getID
            {
                Console.WriteLine("this board is already excist");
                return false;
            }
            else
            {
                BoardList.Add(board.getId(), board); 
                return true;
            }
        }
        public Board createBoard(string BoardName) 
        {
            Board board = new Board(BoardName, this.email);
            this.BoardController.addBoard(board);
            return board;
        }
        public Board removeBoard(string idBoard) 
        {
            if (BoardList.ContainsKey(idBoard) == true) 
            {
                Board removed = getBoard(idBoard);
                BoardList.Remove(idBoard);
                return removed;
            }
            else
            {
                throw new ArgumentException("this board is not excist");
            }
        }
        public bool equals(User other)
        {
            return this.email.Equals(other.email);
        }

        public Board getBoard(string idBoard)
        {
            if (BoardList.ContainsKey(idBoard) == true)
            {
                return BoardList[idBoard];
            }
            else
            {
                throw new ArgumentException("there is no board with this id");
            }
        }
        public Task getTasks(string idTask)
        {
            if (TaskList.ContainsKey(idTask) == true)
            {
                return TaskList[idTask];
            }
            else
            {
                throw new ArgumentException("there is no task with this id");
            }
        }

        public void setIslogged(bool logged)
        {
            isLogged = logged;
        }

    }
}
