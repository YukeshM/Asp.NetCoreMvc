using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class Role
    {
        public Role()
        {
            EmployeeRoleMappings = new HashSet<EmployeeRoleMapping>();
        }

        public int Id { get; set; }
        public string Role1 { get; set; }

        public virtual ICollection<EmployeeRoleMapping> EmployeeRoleMappings { get; set; }
    }
}
