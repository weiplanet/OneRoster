namespace Questar.OneRoster.Data.Services
{
    using System;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.Extensions.ExpressionMapping;
    using DataServices;
    using DataServices.EntityFrameworkCore;
    using Models;
    using AcademicSession = Data.AcademicSession;
    using AcademicSessionType = Data.AcademicSessionType;

    public class TermRepository : BaseObjectRepository<Models.AcademicSession, AcademicSession>, ITermRepository
    {
        public TermRepository(OneRosterDbContext context, IMapper mapper)
            : base(context, mapper, context.Set<AcademicSession>().Where(session => session.Type == AcademicSessionType.Term))
        {
        }

        public IQuery<Class> GetClassesForTerm(string academicSessionId) =>
            Context.Classes
                .Where(@class => @class.Terms.Any(term => term.AcademicSessionId == Guid.Parse(academicSessionId)))
                .UseAsDataSource(Mapper)
                .For<Class>()
                .ToBaseQuery();


        public IQuery<Models.AcademicSession> GetGradingPeriodsForTerm(string academicSessionId) =>
            Context.AcademicSessions
                .Where(session => session.ParentId == Guid.Parse(academicSessionId))
                .UseAsDataSource(Mapper)
                .For<Models.AcademicSession>()
                .ToBaseQuery();
    }
}