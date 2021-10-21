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




        //public List<AdminViewModel> GetAllEmployee()
        //{
        //    List<AdminViewModel> adminViewModel = new List<AdminViewModel>();
        //    IEnumerable<EmployeeViewModel> employeeViewModel = GetEmployeeDetail();
        //    adminViewModel.Add(employeeViewModel);

        //    return adminViewModel;
        //}
        //public List<AdminViewModel> GetAllEmployee()
        //{



        //using (SqlConnection sqlConnection = new SqlConnection
        // ("Server=TRAINEE-03;Database=sep23WithDbFirst;UserId=sa;Password=@9543890461My;Trusted_Connection=false;MultipleActiveResultSets=true;"))
        // {
        //adminViewModel = sqlConnection..Query<AdminViewModel>("execute spGetAllEmployee").ToList();
        //using (SqlCommand sqlCommand = new SqlCommand("EXEC spGetAllEmployee", sqlConnection))
        //{
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    var adminViewModel = new AdminViewModel();

        //    var allemployeeViewModel = new AllEmployeeViewModel();
        //    sqlConnection.Open();

        //    using (var reader = sqlCommand.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {

        //        }
        //    }

        //}
        // }

        //SqlDataReader dataReader = null;

        //sqlConnection.Open();

        //SqlCommand sqlCommand = new SqlCommand("spGetAllEmployee", sqlConnection);
        //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

        //dataReader = sqlCommand.ExecuteReader();
        //return dataReader;

        //finally
        //{
        //    if (sqlConnection != null)
        //    {
        //        sqlConnection.Close();
        //    }
        //    if (dataReader != null)
        //    {
        //        dataReader.Close();
        //    }
        //}

        //}
    }
}
