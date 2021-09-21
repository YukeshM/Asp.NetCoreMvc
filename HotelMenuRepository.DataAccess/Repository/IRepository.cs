using System.Collections.Generic;

namespace HotelMenuRepository.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllMenu();

        T GetById(int id);

        void Insert(T entity);

        void Delete(T entity);


    }
}
