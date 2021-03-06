using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aug27.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string  Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password doesn't match with confirm password")]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
