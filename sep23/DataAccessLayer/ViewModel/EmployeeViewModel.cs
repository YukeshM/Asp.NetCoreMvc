using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public DateTime InDate
        {
            get; set;
        }

        public DateTime InTime
        {
            get; set;
        }

        public DateTime OutTime
        {
            get; set;
        }

        public IEnumerable<BreakTime> BreakList
        {
            get; set;
        }
    }
}
