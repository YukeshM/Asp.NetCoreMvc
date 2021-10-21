﻿using System.ComponentModel.DataAnnotations;

namespace TimeEntryWebsite.Models
{
    public class LoginModel
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

        [Display(Name = "Remember Me")]
        public bool RememberMe
        {
            get; set;
        }
    }
}
