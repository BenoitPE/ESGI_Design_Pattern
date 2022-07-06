using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class User
    {
        public string Name { get; set; }
        private Schedule Schedule { get; set; }

        public User(string name)
        {
            this.Name = name;
            this.Schedule = Schedule.Instance();
            Console.WriteLine($"The user {Name} has been created");
        }

        public void AddToSchedule(Event e)
        {
            Schedule.AddEvent(e);    
        }

        public void SeeSchedule()
        {
            Console.WriteLine($"\n{Name} displays the schedule:");
            Schedule.SeeSchedule();
        }

    }
}
