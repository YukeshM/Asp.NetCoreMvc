using HotelMenuRepository.DataAccess.Data;
using HotelMenuRepository.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenuRepository.DataAccess.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }
        void IMenuRepository.Update(Menu menu)
        {
            // TODO: 
        }
    }
}
