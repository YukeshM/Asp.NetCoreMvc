using aug27.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aug27.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<Skills> Skills { get; set; }
    }
}
