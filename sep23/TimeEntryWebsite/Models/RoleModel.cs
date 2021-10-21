using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.Models
{
    public class RoleModel
    {
        [Required(ErrorMessage = "Role is required!")]
        [Display(Name = "Enter your Role: ")]
        public string Role
        {
            get; set;
        }

    }
}
