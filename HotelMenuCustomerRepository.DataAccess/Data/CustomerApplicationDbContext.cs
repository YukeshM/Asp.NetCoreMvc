using HotelMenuApplicationRepository.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelMenuApplicationRepository.DataAccess.Data
{
    public class CustomerApplicationDbContext : DbContext
    {
        public CustomerApplicationDbContext(DbContextOptions<CustomerApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Menu> MenuTable { get; set; }
    }
}
