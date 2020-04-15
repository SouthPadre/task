using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class CollegialBody
    {
        public Guid Id { get; set; }
        public IEnumerable<Meeting> Meetings { get; set; }
    }
}