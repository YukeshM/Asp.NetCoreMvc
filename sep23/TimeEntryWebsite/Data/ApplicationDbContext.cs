using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeEntryWebsite.Models;
using TimeEntryWebsite.ViewModel;

namespace TimeEntryWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<EntryTimeViewModel> EntryTimeTable
        {
            get;
            set;
        }
    }
}
