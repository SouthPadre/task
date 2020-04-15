using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var issuesData = Deserializer.IssuesDataDeserialize("IssuesData.json");

            var request = new Request();
            var auth = request.Authorization("badmin" , "badmin");
            
            var mapper = new Mapper();
            foreach (var meeting in issuesData.CollegialBody.Meetings)
            {
                var meetingDto = mapper.MapMeeting(issuesData.CollegialBody.Id, meeting);
                // var meetingCreate = request.SendCreateMeeting(meetingDto);
            
                foreach (var issue in meeting.Issues)
                {
                    var issueDto = mapper.MapIssue(issuesData.CollegialBody.Id, issue);
                    var issueCreate = request.SendCreateIssue(issueDto);
                }
            }
        }
    }
}