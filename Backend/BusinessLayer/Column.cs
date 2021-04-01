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
        public Column(string name) { }
        public Column(string name, int maxTasks) { }
        public void setMaxTasks(int maxTasks) { }
        public bool isBelong(Task task) { }
        public bool addTask(Task task) { }
        public Task removeTask(string id) { }

    }
}
