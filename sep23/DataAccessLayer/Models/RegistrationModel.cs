using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class RegistrationModel
    {

        //[Required(ErrorMessage = "Id is required!")]
        [Key]
        public int Id
        {
            get; set;
        }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        public string Email
        {
            get; set;
        }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }

        [Required(ErrorMessage = "Confirm Password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match.")]
        public string ConfirmPassword
        {
            get; set;
        }
    }
}
