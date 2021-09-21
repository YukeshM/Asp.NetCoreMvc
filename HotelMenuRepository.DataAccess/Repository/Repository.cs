using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HotelMenuRepository.DataAccess.Data;

namespace HotelMenuRepository.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public void Delete(T entity)
        {
             _db.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAllMenu()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _db.Set<T>().Add(entity);
        }
    }
}
