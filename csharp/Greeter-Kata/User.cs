using System;
using System.Collections.Generic;

namespace Greeter_Kata
{
    public class User
    {
        private List<WorkItem> workItems;

        public User(string firstName, string lastName, DateTime birthdate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            workItems = new List<WorkItem>();
        }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime Birthdate { get; }

        public IEnumerable<WorkItem> WorkItems => workItems;

        public void AddWorkItem(WorkItem workItem)
        {
            workItems.Add(workItem);
        }
    }
}