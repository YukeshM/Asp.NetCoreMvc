using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Role
    {
        public Role()
        {
            EmployeeInformations = new HashSet<EmployeeInformation>();
        }

        public int RoleId { get; set; }
        public string Role1 { get; set; }

        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
