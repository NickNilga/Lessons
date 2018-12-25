using Microsoft.EntityFrameworkCore;

namespace SchoolJournal.Repositories.Database
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions contextOptions)
            : base(contextOptions)
        {
        }
    }
}