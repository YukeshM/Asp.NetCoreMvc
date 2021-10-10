﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeEntryWebsite.ViewModel
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            User = new List<string>();
        }

        public string Id
        {
            get; set;
        }

        [Required(ErrorMessage = "Role name is required!")]
        public string RoleName
        {
            get; set;
        }

        public List<string> User
        {
            get; set;
        }

    }
}
