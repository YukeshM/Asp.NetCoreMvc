using HotelMenuRepository.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMenuRepository.DataAccess.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IMenuRepository MenuList { get; }

        void Save();
    }
}
