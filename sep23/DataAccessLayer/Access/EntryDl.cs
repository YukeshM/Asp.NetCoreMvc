using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Access
{
    public class EntryDl
    {
        private readonly sep23WithDbFirstContext _db;
        public EntryDl()
        {
            this._db = new sep23WithDbFirstContext();
        }

        public List<EntryTime> GetEntry()
        {
            var result = _db.EntryTimes.ToList();
            return result;
        }

        public void CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void Create(EntryTime model)
        {
            _db.EntryTimes.Add(model);
            _db.SaveChanges();

        }

        public void CreateBreak(BreakTime breakTime)
        {
            _db.BreakTimes.Add(breakTime);
            _db.SaveChanges();
        }

        public List<EmployeeViewModel> GetEmployeeDetail()
        {
            List<EmployeeViewModel> data = new List<EmployeeViewModel>();
            IEnumerable<EntryTime> entryTimes = _db.EntryTimes;
            IEnumerable<User> user = _db.Users;
            foreach (var entry in entryTimes)
            {
                var employeeViewModel = new EmployeeViewModel();
                employeeViewModel.BreakList = _db.BreakTimes.Where(item => item.EntryId == entry.Id);
                foreach (var item in user)
                {
                    employeeViewModel.Name = _db.Users.Where(x => x.Id == entry.UserId).FirstOrDefault().Name;
                }
                employeeViewModel.Id = entry.Id;
                employeeViewModel.InDate = entry.InDate;
                employeeViewModel.OutTime = entry.OutTime;
                employeeViewModel.InTime = entry.InTime;
                data.Add(employeeViewModel);
            }
            return data;
        }
    }
}
