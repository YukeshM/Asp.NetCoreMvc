using HotelMenuApplicationRepository.DataAccess.Data;
using HotelMenuApplicationRepository.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelMenuApplicationRepository.DataAccess.Repository
{
    public class MenuRepository : IMenuRepository
    {

        private readonly ApplicationDbContext _db;
        public MenuRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public void Delete(int id)
        {
            var menu = _db.MenuTable.Find(id);
            if(menu != null) _db.MenuTable.Remove(menu);
        }

        public IEnumerable<Menu> GetAllMenu()
        {
            return _db.MenuTable.ToList();
        }

        public Menu GetById(int id)
        {
            return _db.MenuTable.Find(id);
        }

        public void Insert(Menu entity)
        {
            _db.MenuTable.Add(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Menu entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        private bool disposed = false;
        public void Dispose(bool disposing)
        {

            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
