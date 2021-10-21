using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeEntryWebsite.Models;

namespace TimeEntryWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<EntryTimeModel> EntryTimeTable
        {
            get;
            set;
        }

        public DbSet<BreakTimeModel> BreakTimeTable
        {
            get;
            set;
        }
    }
}
