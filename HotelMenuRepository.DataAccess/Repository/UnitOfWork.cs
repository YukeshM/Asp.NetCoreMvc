using HotelMenuRepository.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenuRepository.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            this._db = db;
            MenuList = new MenuRepository(_db);
            
        }

        public IMenuRepository MenuList { get; }
        

        void IDisposable.Dispose()
        {
            _db.Dispose();
        }

        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}
