using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    class Person
    {
       // public Person()
        
       //     this.Events = new HashSet<Event>();
       // }
        public int PersonId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Rolle { get; set; }

        // Navigation Property für Event

        //public ICollection<Event> Events { get; set; }
        public List<PersonenEvent> PersonenEvents { get; set; }
        }
    }

