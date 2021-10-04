using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeEntryWebsite.Models;

namespace TimeEntryWebsite.ViewModel
{
    public class RoleViewModel
    {
         
        [Required(ErrorMessage = "Role is required!")]
        [Display(Name = "Enter your Role: ")]
        public string Role
        {
            get; set;
        }

       
    }
}
