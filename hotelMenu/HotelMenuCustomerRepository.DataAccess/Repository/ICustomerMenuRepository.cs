using HotelMenuApplicationRepository.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenuCustomerRepository.DataAccess.Repository
{
    public interface ICustomerMenuRepository
    {
        IEnumerable<Menu> GetAllMenu();

    }
}
