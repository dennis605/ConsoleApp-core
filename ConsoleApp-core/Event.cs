using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    class Event
    {
        private int eventId { get; set; }
        private string eventName { get; set; }

        private DateTime eventDatum { get; set; }
        private DateTime eventBeginn { get; set; }
        public DateTime EventEnd { get; set; }
        public int EventVorlauf { get; set; }
        public string EventOrt { get; set; }
        public string EventBeschreibung { get; set; }
        public string EventInfo { get; set; }


        public ICollection<Person> Persons { get; set; }
    }
}
