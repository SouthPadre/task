using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Meeting
    {
        public string Num { get; set; }
        public string AgendaDueDate { get; set; }
        public string MaterialsDueDate { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public IEnumerable<IdDto> InvitedPersons { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}