using System;
using AutoMapper;

namespace ConsoleApp1
{
    public class Mapper
    {
        public CreateIssueDto MapIssue(Guid collegialBodyId, Issue issue)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<Tuple<Guid, Issue>, CreateIssueDto>(new Tuple<Guid, Issue>(collegialBodyId, issue));
        }

        public CreateMeetingDto MapMeeting(Guid collegialBodyId, Meeting meeting)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<Tuple<Guid, Meeting>, CreateMeetingDto>(new Tuple<Guid, Meeting>(collegialBodyId, meeting));
                
        }

    }
}
            