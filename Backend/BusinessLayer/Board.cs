using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class Board
    {
        private string id;//id=name+email
        private string name;
        private string creatorEmail;
        private Column backlog;
        private Column inProgress;
        private Column done;
        private int taskIndex = 0;

        public Board(string name,string email){

            }


        public bool addTask(DateTime creationTime, DateTime durDate, string title, string description) { }
        public bool toInProgress(Task task) { }
        public bool toDone(Task task) { }
        public bool equals(Board other) { }

    }
}
