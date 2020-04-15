using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Issue
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Estimate { get; set; }
        public IEnumerable<IdDto> Speakers { get; set; }
        public IEnumerable<IdDto> Initiators { get; set; }
        public IEnumerable<IdDto> Invitees { get; set; }  //id
        public IEnumerable<IdDto> Materials { get; set; }
    }
}