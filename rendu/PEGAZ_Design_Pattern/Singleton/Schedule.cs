using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Schedule
    {
        public List<Event> events;
        private static Schedule _instance = null;

        private Schedule()
        {
            events = new List<Event>();
        }

        public static Schedule Instance()
        {
            if (_instance == null)
                _instance = new Schedule();
            return _instance;
        }

        public bool AddEvent(Event e)
        {
            if(events.Contains(e))
            {
                Console.WriteLine($"The event '{e.Name}' cannot be added because it already exists in schedule");
                return false;
            }

            events.Add(e);
            Console.WriteLine($"The event '{e.Name}' has been added to schedule");
            return true;
        }

        public bool RemoveEvent(Event e)
        {
            if(!events.Contains(e))
            {
                Console.WriteLine($"The event '{e.Name}' can't be removed because it doesn't exists in schedule");
                return false;
            }
                
            events.Remove(e);
            Console.WriteLine($"The event '{e.Name}' has been removed from schedule");
            return true;
        }

        public void SeeSchedule()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("| \t Date \t\t | \t\t Name \t\t\t |");
            Console.WriteLine("------------------------------------------------------------------");
            foreach(Event e in events)
            {
                Console.WriteLine($"| \t {e.Date.ToString("dd/MM/yyyy")} \t | \t {e.Name} \t |");
            }
            Console.WriteLine("------------------------------------------------------------------\n");
        }
    }
}
