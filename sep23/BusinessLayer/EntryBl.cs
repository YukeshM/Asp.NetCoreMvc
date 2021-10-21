using DataAccessLayer.Access;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EntryBl
    {
        private readonly EntryDl _entryDl;

        public EntryBl()
        {
            this._entryDl = new EntryDl();
        }

        public List<EntryTime> GetEntry()
        {
            var result = _entryDl.GetEntry();
            return result;
        }

        public void CreateUser(User user)
        {
            _entryDl.CreateUser(user);
        }
        public void Create( EntryTime entryTime)
        {
            _entryDl.Create( entryTime);    
        }

        public void CreateBreak(BreakTime breakTime)
        {
            _entryDl.CreateBreak(breakTime);
        }

        public List<EmployeeViewModel> GetEmployee()
        {
            return _entryDl.GetEmployeeDetail();
        }

        public List<EmployeeViewModel> GetAllEmployee()
        {
            return _entryDl.GetEmployeeDetail();
        }
    }
}
