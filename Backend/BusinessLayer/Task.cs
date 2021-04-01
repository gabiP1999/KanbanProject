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
        public Task(string id,DateTime creationTime, DateTime dueDate,string title,string description) {
            this.id = id;
            this.creationTime = creationTime;
            this.dueDate = dueDate;

            while (!validateTitle(title)) {
                Console.WriteLine("invalid title, please enter a new one");
                title = Console.ReadLine();
            }
            
            this.title = title;


            while (!validateDescription(description))
            {
                Console.WriteLine("invalid description");
                description = Console.ReadLine();

            }
            this.description = description;
            isDone = false;
        }
        public bool changeTitle(string title) {
            while (!validateTitle(title))
            {
                Console.WriteLine("invalid title");
                title = Console.ReadLine();

            }
            bool changed = true;
            this.title = title;
            return changed;
        }
        private bool validateTitle(string title) {
            return title != null && title.Length <= 50;
        
        }
        private bool validateDescription(string description)
        {
            return description.Length <= 300;

        }
        public bool changeDescription(string description) {
            while (!validateDescription(description))
            {
                Console.WriteLine("invalid description");
                description = Console.ReadLine();
            }
            bool changed = true;
            this.description = description;
            return changed;
        }
        public bool equals(Task other)
        {
            return this.id == other.id;
        }

        public void setDone() {
            this.isDone = true;
        }

        public void setDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }
        public string getID() {
            return this.id;
        }
        public DateTime getCreationTime() {
            return this.creationTime;
        }
        public DateTime getDueDate() {
            return this.dueDate;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getDescription() {
            return this.description;
        }
        public bool getIsDone() {
            return this.isDone;    
        }
       
      




    }
}
