using HotelMenuRepository.Model.Models;

namespace HotelMenuRepository.DataAccess.Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {
        void Update(Menu menu);
    }
}
