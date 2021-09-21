using HotelMenuRepository.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelMenuRepository.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Menu> MenuTable { get; set; }

    }
}
