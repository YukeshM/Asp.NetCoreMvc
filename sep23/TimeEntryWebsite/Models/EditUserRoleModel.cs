using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.Models
{
    public class EditUserRoleModel
    {

        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get; set;
        }

        public bool IsSelected
        {
            get; set;
        }
    }
}
