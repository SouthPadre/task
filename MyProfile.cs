using System;
using System.Threading;
using AutoMapper;

namespace ConsoleApp1
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<Tuple<Guid, Issue>, CreateIssueDto>()
                .ForMember(trg => trg.CollegialBody,
                    cfg => cfg.MapFrom(src => src.Item1))
                .ForMember(trg => trg.Description, cfg => cfg.MapFrom(src => src.Item2.Description))
                .ForMember(trg => trg.Estimate, cfg => cfg.MapFrom(src => src.Item2.Estimate))
                .ForMember(trg => trg.Initiators, cfg => cfg.MapFrom(src => src.Item2.Initiators))
                .ForMember(trg => trg.Invitees, cfg => cfg.MapFrom(src => src.Item2.Invitees))
                .ForMember(trg => trg.Materials, cfg => cfg.MapFrom(src => src.Item2.Materials))
                .ForMember(trg => trg.Title, cfg => cfg.MapFrom(src => src.Item2.Title));
            CreateMap<Guid, CollegialBodyRefDto>()
                .ForMember(trg => trg.Id, cfg => cfg.MapFrom(src => src));
            CreateMap<string, MultilingualTextDto>()
                .ForMember(trg => trg.Locale,
                    cfg => cfg.MapFrom(src => Thread.CurrentThread.CurrentCulture.DisplayName))
                .ForMember(trg => trg.Value, cfg => cfg.MapFrom(src => src));
            // CreateMap<string, DateTimeOffset>()
            //     .ForMember(trg => trg, cfg =>cfg.MapFrom(src=> DateTimeOffset.Parse(src)));
            CreateMap<IdDto, EmployeeRefDto>()
                .ForMember(trg => trg.Id, cfg => cfg.MapFrom(src => src.Id));
            CreateMap<Tuple<Guid, Meeting>, CreateMeetingDto>()
                .ForMember(trg => trg.CollegialBodyRefDto,
                    cfg => cfg.MapFrom(src => src.Item1))
                .ForMember(trg => trg.Num, cfg => cfg.MapFrom(src => src.Item2.Num))
                // .ForMember(trg => trg.Issues, cfg => cfg.MapFrom(src => src.Item2.Issues))
                .ForMember(trg => trg.AgendaDueDate, cfg => cfg.MapFrom(src => src.Item2.AgendaDueDate))
                .ForMember(trg => trg.MaterialsDueDate, cfg => cfg.MapFrom(src => src.Item2.MaterialsDueDate));
                ;CreateMap<IdDto, IssueRefDto>()
                .ForMember(trg => trg.Id, cfg => cfg.MapFrom(src => src.Id));
        }
    }
}