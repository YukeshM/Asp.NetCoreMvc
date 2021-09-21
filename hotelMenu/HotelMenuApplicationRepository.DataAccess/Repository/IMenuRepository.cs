using HotelMenuApplicationRepository.Models.Models;
using System;
using System.Collections.Generic;

namespace HotelMenuApplicationRepository.DataAccess.Repository
{
    public interface IMenuRepository : IDisposable
    {
        IEnumerable<Menu> GetAllMenu();

        Menu GetById(int id);

        void Insert(Menu menu);

        void Update(Menu menu);

        void Delete(int id);

        void Save();

        void Dispose();
    }
}
