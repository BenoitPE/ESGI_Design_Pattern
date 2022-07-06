using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Event(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }
    }
}
