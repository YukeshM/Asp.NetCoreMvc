﻿using HotelMenuApplicationRepository.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelMenuApplicationRepository.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole,
                 string, IdentityUserClaim<string>, IdentityUserRole<string>,
        IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<IdentityUser>();
        //}

        public DbSet<Menu> MenuTable { get; set; }
    }
}
