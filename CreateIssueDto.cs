using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class CreateIssueDto
    {
        public CollegialBodyRefDto CollegialBody { get; set; }
        public MultilingualTextDto Title { get; set; }
        public MultilingualTextDto Description { get; set; }
        public IEnumerable<LabelDto> Labels { get; set; }
        public DateTimeOffset Estimate { get; set; }
        public IEnumerable<EmployeeRefDto> Initiators { get; set; }
        public IEnumerable<EmployeeRefDto> Invitees { get; set; }
        public IEnumerable<EmployeeRefDto> Materials { get; set; }
        public Boolean IsConfidential { get; set; }
        public EditIssueReviewDto IssueReview { get; set; }
        public Boolean IsBitl { get; set; }
        public Boolean IsIssuer { get; set; }
        
    }
}