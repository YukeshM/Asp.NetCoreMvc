using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class EmployeeRoleMapping
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }

        public virtual EmployeeInformation Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
