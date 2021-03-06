using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.Models
{
    public class EditRoleModel
    {
        public EditRoleModel()
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
