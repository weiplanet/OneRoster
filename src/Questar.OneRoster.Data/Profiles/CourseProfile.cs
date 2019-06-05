using System.Linq;

namespace Questar.OneRoster.Data.Profiles
{
    public class CourseProfile : BaseProfile<Course, Models.Course>
    {
        public CourseProfile()
        {
            CreateMap()
                .ForMember(target => target.Subjects, config => config.MapFrom(source => source.Subjects.Select(subject => subject.Subject.Name)))
                .ForMember(target => target.SubjectCodes, config => config.MapFrom(source => source.Subjects.Select(subject => subject.Subject.Code)));
        }
    }
}