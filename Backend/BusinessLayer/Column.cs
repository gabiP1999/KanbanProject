using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class Column
    {
        private string name;
        private int maxTasks;
        private Dictionary<string,Task> Tasks;
        public Column(string name) {
            this.name = name;
            Tasks = new Dictionary<string, Task>();
        
        }
        public Column(string name, int maxTasks) {
            this.name = name;
            this.maxTasks = maxTasks;
            Tasks = new Dictionary<string, Task>();
        }
        public void setMaxTasks(int maxTasks) {
            this.maxTasks = maxTasks;
        }
        public bool isBelong(Task task) {
            return Tasks.ContainsKey(task.getID());
        }
        public bool addTask(Task task) {
            bool added = Tasks.ContainsKey(task.getID());
            if(added)
                 Tasks[task.getID()] = task;
            return added;
        }
        public Task removeTask(Task task) {

            if (Tasks.ContainsKey(task.getID()))
                this.Tasks.Remove(task.getID());
            else
                Console.WriteLine("id is not found");
            return task;
        
        }

        public string getName() {
            return this.name;
        }
    }
}
