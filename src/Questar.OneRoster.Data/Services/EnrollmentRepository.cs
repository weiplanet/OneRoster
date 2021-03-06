namespace Questar.OneRoster.Data.Services
{
    using AutoMapper;
    using DataServices;
    using Models;
    using Enrollment = Data.Enrollment;

    public class EnrollmentRepository : BaseObjectRepository<Models.Enrollment, Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(OneRosterDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}