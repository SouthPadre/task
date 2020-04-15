using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class CreateMeetingDto
    {
        public CollegialBodyRefDto CollegialBodyRefDto { get; set; }
        public string Num { get; set; }
        public IEnumerable<IssueRefDto> Issues { get; set; }
        public DateTimeOffset AgendaDueDate { get; set; }
        public DateTimeOffset MaterialsDueDate { get; set; }
        public string _discriminator { get; set; } = "presential";
    }
}