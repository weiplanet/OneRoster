namespace Questar.OneRoster.Data.Profiles
{
    using System.Linq;
    using AutoMapper;
    using Models;
    using Class = Data.Class;

    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, Models.Class>()
                .ForMember(target => target.SourcedId, config => config.MapFrom(source => source.Id))
                .ForMember(target => target.DateLastModified, config => config.MapFrom(source => source.Modified))
                .ForMember(target => target.StatusType, config => config.MapFrom(source => (StatusType) source.Status))
                .ForMember(target => target.Metadata, config => config.MapFrom(source => source.MetadataCollection.Metadata))
                .ForMember(target => target.ClassCode, config => config.MapFrom(source => source.Code))
                .ForMember(target => target.ClassType, config => config.MapFrom(source => (ClassType) source.Type))
                .ForMember(target => target.Subjects, config => config.MapFrom(source => source.Subjects.Select(subject => subject.Subject.Name)))
                .ForMember(target => target.SubjectCodes, config => config.MapFrom(source => source.Subjects.Select(subject => subject.Subject.Code)))
                .ForMember(target => target.Periods, config => config.MapFrom(source => source.Periods.Select(period => period.Period)));
        }
    }
}