using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class Task
    {
        private string id;
        private DateTime creationTime;
        private DateTime dueDate;
        private string description;
        private string title;
        private bool isDone;
        public Task(string id,DateTime creationTime, DateTime durDate,string title,string description) {}
        public bool changeTitle(string title) { }
        public bool changeDescription(string description) { }
        public void setDone() { }
        public bool equals(Task other) { }




    }
}
