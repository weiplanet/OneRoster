using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Questar.OneRoster.Data.Services
{
    internal class OneRosterDbContextDesignTimeFactory : IDesignTimeDbContextFactory<OneRosterDbContext>
    {
        public OneRosterDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<OneRosterDbContext>();

            options.UseSqlServer(@"Data Source=.;Initial Catalog=OneRoster;Integrated Security=True");

            return new OneRosterDbContext(options.Options);
        }
    }
}