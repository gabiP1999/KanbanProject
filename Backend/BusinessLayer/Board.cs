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
            this.name = name;
            this.creatorEmail = email;
            this.id = name + email;
            backlog = new Column("Backlog");
            inProgress = new Column("In Progress");
            done = new Column("Done");
            }


        public bool addTask(DateTime creationTime, DateTime dueDate, string title, string description) {
            Task newTask = new Task(taskIndex.ToString() + getId(), creationTime, dueDate, title, description);
            return this.backlog.addTask(newTask);
        }
        public bool toInProgress(Task task) {
            if (!backlog.isBelong(task)) throw new Exception("Task does not belong to backlog");
            if (inProgress.isBelong(task)) throw new Exception("Task already belongs to in Progress");
            backlog.removeTask(task.getId());
            return inProgress.addTask(task);

        }
        public bool toDone(Task task) {
            if (!inProgress.isBelong(task)) throw new Exception("Task does not belong to in Progress");
            if (done.isBelong(task)) throw new Exception("Task already belongs to done");
            inProgress.removeTask(task.getId());
            task.setDone();
            return done.addTask(task);
        
        }
        public bool equals(Board other) {
            if (this.getId == other.getId) return true;
            return false;
                }
        public string getId() { return this.id; }
        public string getName() { return this.name; }
        public string getCreatorEmail() { return this.creatorEmail; }
    }
}
