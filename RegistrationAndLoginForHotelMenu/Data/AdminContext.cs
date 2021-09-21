using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RegistrationAndLoginForHotelMenu.Data
{


    public class AdminContext : IdentityDbContext<IdentityUser, IdentityRole,
                 string, IdentityUserClaim<string>, IdentityUserRole<string>,
        IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>();
        }


    }

}
