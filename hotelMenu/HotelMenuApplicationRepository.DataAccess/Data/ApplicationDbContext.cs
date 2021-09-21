using HotelMenuApplicationRepository.Models.Models;
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
        public DbSet<Menu> MenuTable { get; set; }
    }
}
