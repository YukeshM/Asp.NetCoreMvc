using System.ComponentModel.DataAnnotations;

namespace TimeEntryWebsite.ViewModel
{
    public class RegistrationViewModel
    {

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
