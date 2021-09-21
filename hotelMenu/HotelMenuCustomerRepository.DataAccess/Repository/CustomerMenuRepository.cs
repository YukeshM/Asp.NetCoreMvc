using HotelMenuApplicationRepository.DataAccess.Data;
using HotelMenuApplicationRepository.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMenuCustomerRepository.DataAccess.Repository
{
    public class CustomerMenuRepository : ICustomerMenuRepository
    {
        private readonly CustomerApplicationDbContext _db;
        public CustomerMenuRepository(CustomerApplicationDbContext db)
        {
            this._db = db;
        }


        public IEnumerable<Menu> GetAllMenu()
        {
            return _db.MenuTable.ToList();
        }
    }
}
