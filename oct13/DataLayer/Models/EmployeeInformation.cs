using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class EmployeeInformation
    {
        public EmployeeInformation()
        {
            EmployeeRoleMappings = new HashSet<EmployeeRoleMapping>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public virtual ICollection<EmployeeRoleMapping> EmployeeRoleMappings { get; set; }
    }
}
