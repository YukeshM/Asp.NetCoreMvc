using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class EmployeeInformation
    {
        public int EmployeeInformationId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public virtual Role Role { get; set; }
    }
}
